﻿namespace EquipMag.VacTubeMag
{
    partial class VacTubeOnLineFrm
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfrim = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtVacTubeCode = new System.Windows.Forms.TextBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableVacTube_Code = new System.Data.DataColumn();
            this.coldsBaseL3DataTableInstall_ID = new System.Data.DataColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myLine1 = new buttonHide.MyLine();
            this.rdbtnB = new System.Windows.Forms.RadioButton();
            this.rdbtnA = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdpUpID = new AppSvrHMI.L3CommandParameter();
            this.cmdpDownID = new AppSvrHMI.L3CommandParameter();
            this.cmdpPositon = new AppSvrHMI.L3CommandParameter();
            this.cmdpType = new AppSvrHMI.L3CommandParameter();
            this.cmdOnLine = new AppSvrHMI.L3Command(this.components);
            this.cmdOffLine = new AppSvrHMI.L3Command(this.components);
            this.cmdCheck = new AppSvrHMI.L3Command(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfrim);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(396, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(318, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfrim
            // 
            this.btnConfrim.Location = new System.Drawing.Point(237, 3);
            this.btnConfrim.Name = "btnConfrim";
            this.btnConfrim.Size = new System.Drawing.Size(75, 23);
            this.btnConfrim.TabIndex = 0;
            this.btnConfrim.Tag = "";
            this.btnConfrim.Text = "操作";
            this.btnConfrim.UseVisualStyleBackColor = true;
            this.btnConfrim.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 203);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtVacTubeCode);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.myLine1);
            this.tabPage1.Controls.Add(this.rdbtnB);
            this.tabPage1.Controls.Add(this.rdbtnA);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "真空槽信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtVacTubeCode
            // 
            this.txtVacTubeCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "VacTube_Code", true));
            this.txtVacTubeCode.Location = new System.Drawing.Point(116, 89);
            this.txtVacTubeCode.Name = "txtVacTubeCode";
            this.txtVacTubeCode.ReadOnly = true;
            this.txtVacTubeCode.Size = new System.Drawing.Size(219, 21);
            this.txtVacTubeCode.TabIndex = 4;
            this.txtVacTubeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // dsBase
            // 
            this.dsBase.AutoSubscribe = false;
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = "";
            this.dsBase.InsertMethod = "";
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 60000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = "";
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsBase.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsBase.SubscribeTarget = "";
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "";
            this.dsBase.UpdateMethod = "";
            this.dsBase.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableVacTube_Code,
            this.coldsBaseL3DataTableInstall_ID});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableVacTube_Code
            // 
            this.coldsBaseL3DataTableVacTube_Code.Caption = "VacTube_Code";
            this.coldsBaseL3DataTableVacTube_Code.ColumnName = "VacTube_Code";
            this.coldsBaseL3DataTableVacTube_Code.Namespace = "";
            // 
            // coldsBaseL3DataTableInstall_ID
            // 
            this.coldsBaseL3DataTableInstall_ID.Caption = "Install_ID";
            this.coldsBaseL3DataTableInstall_ID.ColumnName = "Install_ID";
            this.coldsBaseL3DataTableInstall_ID.Namespace = "";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Install_ID", true));
            this.textBox1.Location = new System.Drawing.Point(116, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(219, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(32, 52);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(323, 10);
            this.myLine1.TabIndex = 3;
            // 
            // rdbtnB
            // 
            this.rdbtnB.AutoSize = true;
            this.rdbtnB.Location = new System.Drawing.Point(223, 30);
            this.rdbtnB.Name = "rdbtnB";
            this.rdbtnB.Size = new System.Drawing.Size(65, 16);
            this.rdbtnB.TabIndex = 2;
            this.rdbtnB.TabStop = true;
            this.rdbtnB.Tag = "B";
            this.rdbtnB.Text = "B处理位";
            this.rdbtnB.UseVisualStyleBackColor = true;
            this.rdbtnB.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbtnA
            // 
            this.rdbtnA.AutoSize = true;
            this.rdbtnA.Location = new System.Drawing.Point(98, 30);
            this.rdbtnA.Name = "rdbtnA";
            this.rdbtnA.Size = new System.Drawing.Size(65, 16);
            this.rdbtnA.TabIndex = 2;
            this.rdbtnA.TabStop = true;
            this.rdbtnA.Tag = "A";
            this.rdbtnA.Text = "A处理位";
            this.rdbtnA.UseVisualStyleBackColor = true;
            this.rdbtnA.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "真空槽号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "组装编号:";
            // 
            // cmdpUpID
            // 
            this.cmdpUpID.AcceptAfterExecuted = false;
            this.cmdpUpID.ConstantValue = null;
            this.cmdpUpID.MergeTarget = false;
            this.cmdpUpID.SourceFilter = null;
            this.cmdpUpID.SourceObject = null;
            this.cmdpUpID.SourceProperty = null;
            this.cmdpUpID.TargetObject = null;
            this.cmdpUpID.TargetProperty = null;
            // 
            // cmdpDownID
            // 
            this.cmdpDownID.AcceptAfterExecuted = false;
            this.cmdpDownID.ConstantValue = null;
            this.cmdpDownID.MergeTarget = false;
            this.cmdpDownID.SourceFilter = null;
            this.cmdpDownID.SourceObject = null;
            this.cmdpDownID.SourceProperty = null;
            this.cmdpDownID.TargetObject = null;
            this.cmdpDownID.TargetProperty = null;
            // 
            // cmdpPositon
            // 
            this.cmdpPositon.AcceptAfterExecuted = false;
            this.cmdpPositon.ConstantValue = null;
            this.cmdpPositon.MergeTarget = false;
            this.cmdpPositon.SourceFilter = null;
            this.cmdpPositon.SourceObject = null;
            this.cmdpPositon.SourceProperty = null;
            this.cmdpPositon.TargetObject = null;
            this.cmdpPositon.TargetProperty = null;
            // 
            // cmdpType
            // 
            this.cmdpType.AcceptAfterExecuted = false;
            this.cmdpType.ConstantValue = null;
            this.cmdpType.MergeTarget = false;
            this.cmdpType.SourceFilter = null;
            this.cmdpType.SourceObject = null;
            this.cmdpType.SourceProperty = null;
            this.cmdpType.TargetObject = null;
            this.cmdpType.TargetProperty = null;
            // 
            // cmdOnLine
            // 
            this.cmdOnLine.Adapter = this.Adapter;
            this.cmdOnLine.MergeReturnTarget = false;
            this.cmdOnLine.Method = "VactubeOnLine";
            this.cmdOnLine.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdOnLine.ReturnTarget = null;
            this.cmdOnLine.ReturnTargetProperty = null;
            this.cmdOnLine.Trigger = null;
            this.cmdOnLine.TriggerEvent = "Click";
            // 
            // cmdOffLine
            // 
            this.cmdOffLine.Adapter = this.Adapter;
            this.cmdOffLine.MergeReturnTarget = false;
            this.cmdOffLine.Method = "VactubeOffLine";
            this.cmdOffLine.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdOffLine.ReturnTarget = null;
            this.cmdOffLine.ReturnTargetProperty = null;
            this.cmdOffLine.Trigger = null;
            this.cmdOffLine.TriggerEvent = "Click";
            // 
            // cmdCheck
            // 
            this.cmdCheck.Adapter = this.Adapter;
            this.cmdCheck.MergeReturnTarget = false;
            this.cmdCheck.Method = "VacTubeCheck";
            this.cmdCheck.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdCheck.ReturnTarget = null;
            this.cmdCheck.ReturnTargetProperty = null;
            this.cmdCheck.Trigger = null;
            this.cmdCheck.TriggerEvent = "Click";
            // 
            // VacTubeOnLineFrm
            // 
            this.AcceptButton = this.btnConfrim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(396, 253);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VacTubeOnLineFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "真空槽处理";
            this.Load += new System.EventHandler(this.VacTubeOnLineFrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3CommandParameter cmdpUpID;
        private AppSvrHMI.L3CommandParameter cmdpDownID;
        private buttonHide.MyLine myLine1;
        private System.Windows.Forms.RadioButton rdbtnB;
        private System.Windows.Forms.RadioButton rdbtnA;
        private System.Windows.Forms.TextBox txtVacTubeCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableVacTube_Code;
        private System.Data.DataColumn coldsBaseL3DataTableInstall_ID;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.Button btnConfrim;
        private AppSvrHMI.L3CommandParameter cmdpPositon;
        private AppSvrHMI.L3CommandParameter cmdpType;
        private AppSvrHMI.L3Command cmdOnLine;
        private AppSvrHMI.L3Command cmdOffLine;
        private AppSvrHMI.L3Command cmdCheck;
        private System.Windows.Forms.Button btnCancel;
    }
}