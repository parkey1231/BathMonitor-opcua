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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTrend = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnCtrlProcess = new System.Windows.Forms.Button();
            this.btnPraraSet = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.Pannel = new System.Windows.Forms.Panel();
            this.panel_botton = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOPC = new System.Windows.Forms.Button();
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
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_top);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1366, 768);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_top.Controls.Add(this.label4);
            this.panel_top.Controls.Add(this.labCurrentUser);
            this.panel_top.Controls.Add(this.labCurrentTime);
            this.panel_top.Controls.Add(this.label3);
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1366, 86);
            this.panel_top.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(938, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "当前用户：";
            // 
            // labCurrentUser
            // 
            this.labCurrentUser.AutoSize = true;
            this.labCurrentUser.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCurrentUser.ForeColor = System.Drawing.Color.White;
            this.labCurrentUser.Location = new System.Drawing.Point(1191, 49);
            this.labCurrentUser.Name = "labCurrentUser";
            this.labCurrentUser.Size = new System.Drawing.Size(69, 26);
            this.labCurrentUser.TabIndex = 1;
            this.labCurrentUser.Text = "管理员";
            // 
            // labCurrentTime
            // 
            this.labCurrentTime.AutoSize = true;
            this.labCurrentTime.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCurrentTime.ForeColor = System.Drawing.Color.White;
            this.labCurrentTime.Location = new System.Drawing.Point(1134, 9);
            this.labCurrentTime.Name = "labCurrentTime";
            this.labCurrentTime.Size = new System.Drawing.Size(188, 26);
            this.labCurrentTime.TabIndex = 1;
            this.labCurrentTime.Text = "2019-4-8 12:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(938, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "当前时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "QTouch";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel_botton);
            this.splitContainer2.Size = new System.Drawing.Size(1366, 678);
            this.splitContainer2.SplitterDistance = 622;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel_Left);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Pannel);
            this.splitContainer3.Size = new System.Drawing.Size(1366, 622);
            this.splitContainer3.SplitterDistance = 179;
            this.splitContainer3.TabIndex = 0;
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
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(179, 622);
            this.panel_Left.TabIndex = 0;
            // 
            // btnSysMaintenance
            // 
            this.btnSysMaintenance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSysMaintenance.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSysMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnSysMaintenance.Location = new System.Drawing.Point(12, 473);
            this.btnSysMaintenance.Name = "btnSysMaintenance";
            this.btnSysMaintenance.Size = new System.Drawing.Size(146, 50);
            this.btnSysMaintenance.TabIndex = 0;
            this.btnSysMaintenance.Text = "系统维护";
            this.btnSysMaintenance.UseVisualStyleBackColor = false;
            this.btnSysMaintenance.Click += new System.EventHandler(this.btnSysMaintenance_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(13, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 50);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReport.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(12, 309);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(146, 50);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "数据报表";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTrend
            // 
            this.btnTrend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTrend.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTrend.ForeColor = System.Drawing.Color.White;
            this.btnTrend.Location = new System.Drawing.Point(13, 253);
            this.btnTrend.Name = "btnTrend";
            this.btnTrend.Size = new System.Drawing.Size(146, 50);
            this.btnTrend.TabIndex = 0;
            this.btnTrend.Text = "趋势曲线";
            this.btnTrend.UseVisualStyleBackColor = false;
            this.btnTrend.Click += new System.EventHandler(this.btnTrend_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlarm.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAlarm.ForeColor = System.Drawing.Color.White;
            this.btnAlarm.Location = new System.Drawing.Point(13, 197);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(146, 50);
            this.btnAlarm.TabIndex = 0;
            this.btnAlarm.Text = "故障报警";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnCtrlProcess
            // 
            this.btnCtrlProcess.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCtrlProcess.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCtrlProcess.ForeColor = System.Drawing.Color.White;
            this.btnCtrlProcess.Location = new System.Drawing.Point(12, 85);
            this.btnCtrlProcess.Name = "btnCtrlProcess";
            this.btnCtrlProcess.Size = new System.Drawing.Size(146, 50);
            this.btnCtrlProcess.TabIndex = 0;
            this.btnCtrlProcess.Text = "控制流程";
            this.btnCtrlProcess.UseVisualStyleBackColor = false;
            this.btnCtrlProcess.Click += new System.EventHandler(this.btnCtrlProcess_Click);
            // 
            // btnPraraSet
            // 
            this.btnPraraSet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPraraSet.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPraraSet.ForeColor = System.Drawing.Color.White;
            this.btnPraraSet.Location = new System.Drawing.Point(12, 141);
            this.btnPraraSet.Name = "btnPraraSet";
            this.btnPraraSet.Size = new System.Drawing.Size(146, 50);
            this.btnPraraSet.TabIndex = 0;
            this.btnPraraSet.Text = "参数设置";
            this.btnPraraSet.UseVisualStyleBackColor = false;
            this.btnPraraSet.Click += new System.EventHandler(this.btnParaSet_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Green;
            this.btnView.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(12, 29);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(146, 50);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "集中监控";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Pannel
            // 
            this.Pannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.Pannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pannel.Location = new System.Drawing.Point(0, 0);
            this.Pannel.Name = "Pannel";
            this.Pannel.Size = new System.Drawing.Size(1183, 622);
            this.Pannel.TabIndex = 0;
            // 
            // panel_botton
            // 
            this.panel_botton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel_botton.Controls.Add(this.label5);
            this.panel_botton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_botton.Location = new System.Drawing.Point(0, 0);
            this.panel_botton.Name = "panel_botton";
            this.panel_botton.Size = new System.Drawing.Size(1366, 52);
            this.panel_botton.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1366, 52);
            this.label5.TabIndex = 0;
            this.label5.Text = "楚天科技股份有限公司";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOPC
            // 
            this.btnOPC.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOPC.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOPC.ForeColor = System.Drawing.Color.White;
            this.btnOPC.Location = new System.Drawing.Point(12, 365);
            this.btnOPC.Name = "btnOPC";
            this.btnOPC.Size = new System.Drawing.Size(146, 50);
            this.btnOPC.TabIndex = 0;
            this.btnOPC.Text = "OPC 数据";
            this.btnOPC.UseVisualStyleBackColor = false;
            this.btnOPC.Click += new System.EventHandler(this.btnOPC_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
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
    }
}

