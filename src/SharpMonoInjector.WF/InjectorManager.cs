using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SharpMonoInjector.WF
{
    public class InjectorManager
    {
        public static void Log(string info,int type = 0)
        {
            Console.WriteLine(info);
        }

        public static void StartInjectTo(string processName,string dllPath,string className,string methodName)
        {
            #region Check vaild
            if(string.IsNullOrEmpty(processName))
            {
                Log("processName is invaild");
                return;
            }

            if (string.IsNullOrEmpty(dllPath))
            {
                Log("dllPath is invaild");
                return;
            }

            if (string.IsNullOrEmpty(className))
            {
                Log("className is invaild");
                return;
            }

            if (string.IsNullOrEmpty(methodName))
            {
                Log("methodName is invaild");
                return;
            }

            #endregion

            #region get Namespace
            int indexDot = className.LastIndexOf('.');
            string spName = "";
            if (indexDot > -1)
            {
                spName = className.Remove(indexDot);
                className = className.Substring(indexDot+1);
            }

            #endregion

            Process[] pss = Process.GetProcesses();
            Process target = null;
            foreach (Process ps in pss)
            {
                if(ps.ProcessName.Contains(processName))
                {
                    target = ps;
                    break;
                }
#if DEBUG
                else
                {
                    //Console.WriteLine(ps.ProcessName);
                }
#endif
            }

            if (target == null)
            {
                Log("Can not find "+processName);
                return;
            }

            IntPtr handle = Native.OpenProcess(ProcessAccessRights.PROCESS_ALL_ACCESS, false, target.Id);
            if (handle == IntPtr.Zero)
            {
                Log("Failed to open process");
                return;
            }

            IntPtr mono = IntPtr.Zero;
            if(!ProcessUtils.GetMonoModule(handle,out mono))
            {
                Log("Failed to get mono module");
            }

            byte[] file;

            try
            {
                file = File.ReadAllBytes(dllPath);
            }
            catch (IOException)
            {
                Log ("Failed to read the file " + dllPath);
                return;
            }

            using (Injector injector = new Injector(handle,mono))
            {
                try
                {
                    IntPtr asm = injector.Inject(file, spName, className, methodName);
                    Log("Injection successful");
                }
                catch (InjectorException ie)
                {
                    Log("Injection failed: " + ie.Message);
                }
                catch (Exception e)
                {
                    Log("Injection failed (unknown error): " + e.Message);
                }
            }
        }
    }
}
