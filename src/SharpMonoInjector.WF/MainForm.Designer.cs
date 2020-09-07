namespace SharpMonoInjector.WF
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInjector = new System.Windows.Forms.Panel();
            this.btnInjectStart = new System.Windows.Forms.Button();
            this.lbClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnLoadDll = new System.Windows.Forms.Button();
            this.txtInjectorPath = new System.Windows.Forms.TextBox();
            this.lbProcessName = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.lbMFName = new System.Windows.Forms.Label();
            this.txtMFName = new System.Windows.Forms.TextBox();
            this.panelInjector.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInjector
            // 
            this.panelInjector.Controls.Add(this.lbMFName);
            this.panelInjector.Controls.Add(this.txtMFName);
            this.panelInjector.Controls.Add(this.btnInjectStart);
            this.panelInjector.Controls.Add(this.lbClassName);
            this.panelInjector.Controls.Add(this.txtClassName);
            this.panelInjector.Controls.Add(this.btnLoadDll);
            this.panelInjector.Controls.Add(this.txtInjectorPath);
            this.panelInjector.Controls.Add(this.lbProcessName);
            this.panelInjector.Controls.Add(this.txtProcessName);
            this.panelInjector.Location = new System.Drawing.Point(5, 5);
            this.panelInjector.Margin = new System.Windows.Forms.Padding(5);
            this.panelInjector.Name = "panelInjector";
            this.panelInjector.Size = new System.Drawing.Size(270, 350);
            this.panelInjector.TabIndex = 0;
            // 
            // btnInjectStart
            // 
            this.btnInjectStart.Location = new System.Drawing.Point(51, 191);
            this.btnInjectStart.Name = "btnInjectStart";
            this.btnInjectStart.Size = new System.Drawing.Size(177, 23);
            this.btnInjectStart.TabIndex = 8;
            this.btnInjectStart.Text = "Inject!";
            this.btnInjectStart.UseVisualStyleBackColor = true;
            this.btnInjectStart.Click += new System.EventHandler(this.btnInjectStart_Click);
            // 
            // lbClassName
            // 
            this.lbClassName.AutoSize = true;
            this.lbClassName.Location = new System.Drawing.Point(7, 118);
            this.lbClassName.Name = "lbClassName";
            this.lbClassName.Size = new System.Drawing.Size(65, 12);
            this.lbClassName.TabIndex = 7;
            this.lbClassName.Text = "Class Name";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(88, 115);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(179, 21);
            this.txtClassName.TabIndex = 6;
            // 
            // btnLoadDll
            // 
            this.btnLoadDll.Location = new System.Drawing.Point(235, 32);
            this.btnLoadDll.Name = "btnLoadDll";
            this.btnLoadDll.Size = new System.Drawing.Size(32, 23);
            this.btnLoadDll.TabIndex = 3;
            this.btnLoadDll.Text = "...";
            this.btnLoadDll.UseVisualStyleBackColor = true;
            this.btnLoadDll.Click += new System.EventHandler(this.btnLoadDll_Click);
            // 
            // txtInjectorPath
            // 
            this.txtInjectorPath.Location = new System.Drawing.Point(3, 35);
            this.txtInjectorPath.Name = "txtInjectorPath";
            this.txtInjectorPath.Size = new System.Drawing.Size(225, 21);
            this.txtInjectorPath.TabIndex = 2;
            // 
            // lbProcessName
            // 
            this.lbProcessName.AutoSize = true;
            this.lbProcessName.Location = new System.Drawing.Point(7, 11);
            this.lbProcessName.Name = "lbProcessName";
            this.lbProcessName.Size = new System.Drawing.Size(77, 12);
            this.lbProcessName.TabIndex = 1;
            this.lbProcessName.Text = "Process Name";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(88, 8);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(179, 21);
            this.txtProcessName.TabIndex = 0;
            // 
            // lbMFName
            // 
            this.lbMFName.AutoSize = true;
            this.lbMFName.Location = new System.Drawing.Point(7, 145);
            this.lbMFName.Name = "lbMFName";
            this.lbMFName.Size = new System.Drawing.Size(71, 12);
            this.lbMFName.TabIndex = 10;
            this.lbMFName.Text = "Method Name";
            // 
            // txtMFName
            // 
            this.txtMFName.Location = new System.Drawing.Point(88, 142);
            this.txtMFName.Name = "txtMFName";
            this.txtMFName.Size = new System.Drawing.Size(179, 21);
            this.txtMFName.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panelInjector);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "SharpMonoInjector.WF";
            this.panelInjector.ResumeLayout(false);
            this.panelInjector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInjector;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label lbProcessName;
        private System.Windows.Forms.TextBox txtInjectorPath;
        private System.Windows.Forms.Button btnLoadDll;
        private System.Windows.Forms.Label lbClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnInjectStart;
        private System.Windows.Forms.Label lbMFName;
        private System.Windows.Forms.TextBox txtMFName;
    }
}

