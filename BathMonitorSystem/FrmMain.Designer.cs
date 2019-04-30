namespace BathMonitorSystem
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labCurrentUser = new System.Windows.Forms.Label();
            this.labCurrentTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.btnSysMaintenance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOPC = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTrend = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnCtrlProcess = new System.Windows.Forms.Button();
            this.btnPraraSet = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.Pannel = new System.Windows.Forms.Panel();
            this.panel_botton = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.timerSysterm = new System.Windows.Forms.Timer(this.components);
            this.cboxLanguage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel_Left.SuspendLayout();
            this.panel_botton.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_top);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_top.Controls.Add(this.cboxLanguage);
            this.panel_top.Controls.Add(this.label4);
            this.panel_top.Controls.Add(this.labCurrentUser);
            this.panel_top.Controls.Add(this.labCurrentTime);
            this.panel_top.Controls.Add(this.label3);
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Controls.Add(this.label1);
            resources.ApplyResources(this.panel_top, "panel_top");
            this.panel_top.Name = "panel_top";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // labCurrentUser
            // 
            resources.ApplyResources(this.labCurrentUser, "labCurrentUser");
            this.labCurrentUser.ForeColor = System.Drawing.Color.White;
            this.labCurrentUser.Name = "labCurrentUser";
            // 
            // labCurrentTime
            // 
            resources.ApplyResources(this.labCurrentTime, "labCurrentTime");
            this.labCurrentTime.ForeColor = System.Drawing.Color.White;
            this.labCurrentTime.Name = "labCurrentTime";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Name = "label1";
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel_botton);
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel_Left);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Pannel);
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.panel_Left.Controls.Add(this.btnSysMaintenance);
            this.panel_Left.Controls.Add(this.btnExit);
            this.panel_Left.Controls.Add(this.btnOPC);
            this.panel_Left.Controls.Add(this.btnReport);
            this.panel_Left.Controls.Add(this.btnTrend);
            this.panel_Left.Controls.Add(this.btnAlarm);
            this.panel_Left.Controls.Add(this.btnCtrlProcess);
            this.panel_Left.Controls.Add(this.btnPraraSet);
            this.panel_Left.Controls.Add(this.btnView);
            resources.ApplyResources(this.panel_Left, "panel_Left");
            this.panel_Left.Name = "panel_Left";
            // 
            // btnSysMaintenance
            // 
            this.btnSysMaintenance.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnSysMaintenance, "btnSysMaintenance");
            this.btnSysMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnSysMaintenance.Name = "btnSysMaintenance";
            this.btnSysMaintenance.UseVisualStyleBackColor = false;
            this.btnSysMaintenance.Click += new System.EventHandler(this.btnSysMaintenance_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOPC
            // 
            this.btnOPC.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnOPC, "btnOPC");
            this.btnOPC.ForeColor = System.Drawing.Color.White;
            this.btnOPC.Name = "btnOPC";
            this.btnOPC.UseVisualStyleBackColor = false;
            this.btnOPC.Click += new System.EventHandler(this.btnOPC_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Name = "btnReport";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTrend
            // 
            this.btnTrend.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnTrend, "btnTrend");
            this.btnTrend.ForeColor = System.Drawing.Color.White;
            this.btnTrend.Name = "btnTrend";
            this.btnTrend.UseVisualStyleBackColor = false;
            this.btnTrend.Click += new System.EventHandler(this.btnTrend_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnAlarm, "btnAlarm");
            this.btnAlarm.ForeColor = System.Drawing.Color.White;
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnCtrlProcess
            // 
            this.btnCtrlProcess.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnCtrlProcess, "btnCtrlProcess");
            this.btnCtrlProcess.ForeColor = System.Drawing.Color.White;
            this.btnCtrlProcess.Name = "btnCtrlProcess";
            this.btnCtrlProcess.UseVisualStyleBackColor = false;
            this.btnCtrlProcess.Click += new System.EventHandler(this.btnCtrlProcess_Click);
            // 
            // btnPraraSet
            // 
            this.btnPraraSet.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnPraraSet, "btnPraraSet");
            this.btnPraraSet.ForeColor = System.Drawing.Color.White;
            this.btnPraraSet.Name = "btnPraraSet";
            this.btnPraraSet.UseVisualStyleBackColor = false;
            this.btnPraraSet.Click += new System.EventHandler(this.btnParaSet_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Pannel
            // 
            this.Pannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Pannel, "Pannel");
            this.Pannel.Name = "Pannel";
            // 
            // panel_botton
            // 
            this.panel_botton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_botton.Controls.Add(this.label5);
            resources.ApplyResources(this.panel_botton, "panel_botton");
            this.panel_botton.Name = "panel_botton";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // timerSysterm
            // 
            this.timerSysterm.Tick += new System.EventHandler(this.timerSysterm_Tick);
            // 
            // cboxLanguage
            // 
            this.cboxLanguage.FormattingEnabled = true;
            this.cboxLanguage.Items.AddRange(new object[] {
            resources.GetString("cboxLanguage.Items"),
            resources.GetString("cboxLanguage.Items1")});
            resources.ApplyResources(this.cboxLanguage, "cboxLanguage");
            this.cboxLanguage.Name = "cboxLanguage";
            this.cboxLanguage.SelectedIndexChanged += new System.EventHandler(this.cboxLanguage_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel_Left.ResumeLayout(false);
            this.panel_botton.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel Pannel;
        private System.Windows.Forms.Panel panel_botton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labCurrentUser;
        private System.Windows.Forms.Label labCurrentTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnPraraSet;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnTrend;
        private System.Windows.Forms.Button btnSysMaintenance;
        private System.Windows.Forms.Button btnCtrlProcess;
        private System.Windows.Forms.Button btnOPC;
        private System.Windows.Forms.Timer timerSysterm;
        private System.Windows.Forms.ComboBox cboxLanguage;
    }
}

