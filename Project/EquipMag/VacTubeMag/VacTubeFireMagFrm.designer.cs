﻿namespace EquipMag.VacTubeMag
{
    partial class VacTubeFireMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacTubeFireMagFrm));
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdMain = new AppSvrHMI.L3Command(this.components);
            this.cmdpMain = new AppSvrHMI.L3CommandParameter();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableVACTUBE_CODE = new System.Data.DataColumn();
            this.coldsMainL3DataTableINSTALL_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsMainL3DataTableUP_SLOT_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableBEL_SLOT_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableFIRE_START_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableFIRE_END_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLOG_PER = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableOBJECT_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableFIRE_SORUCE = new System.Data.DataColumn();
            this.cmdpM = new AppSvrHMI.L3CommandParameter();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.txtVacTubeCode = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbPosition = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBJECT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VACTUBE_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSTALL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSITION = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsPosition = new AppSvrHMI.L3DataSet();
            this.schemadsPosition = new System.Data.DataTable();
            this.coldsPositionL3DataTableCode = new System.Data.DataColumn();
            this.coldsPositionL3DataTableCode_Des = new System.Data.DataColumn();
            this.UP_SLOT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEL_SLOT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRESTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIREENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.lOGPERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRESORUCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvDetail = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACTUBECODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTALLIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBJECTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fACTTEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUNHEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gASFLOWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o2FLOWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lOGPERDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRESORUCEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetail = new AppSvrHMI.L3DataSet();
            this.cmdDetail = new AppSvrHMI.L3Command(this.components);
            this.cmdpDetail = new AppSvrHMI.L3CommandParameter();
            this.schemadsDetail = new System.Data.DataTable();
            this.coldsDetailL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNAME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableVACTUBE_CODE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableINSTALL_ID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableOBJECT_ID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableTIME_ID = new System.Data.DataColumn();
            this.coldsDetailL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsDetailL3DataTableFACT_TEMP = new System.Data.DataColumn();
            this.coldsDetailL3DataTableGUN_HEIGHT = new System.Data.DataColumn();
            this.coldsDetailL3DataTableGAS_FLOW = new System.Data.DataColumn();
            this.coldsDetailL3DataTableO2_FLOW = new System.Data.DataColumn();
            this.coldsDetailL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLOG_PER = new System.Data.DataColumn();
            this.coldsDetailL3DataTableFIRE_SORUCE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNOTE = new System.Data.DataColumn();
            this.bdN2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDelDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmDetail = new System.Windows.Forms.ToolStripButton();
            this.btnCancelDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPutDetial = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN2)).BeginInit();
            this.bdN2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            this.bsMain.CurrentChanged += new System.EventHandler(this.bsMain_CurrentChanged);
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "DeleteVacTubeFire";
            this.dsMain.InsertMethod = "InsertVacTubeFire";
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 60000;
            this.dsMain.SourceCommand = this.cmdMain;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "GetVacTubeFire";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsMain.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "UpdateVacTubeFire";
            this.dsMain.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdMain
            // 
            this.cmdMain.Adapter = null;
            this.cmdMain.MergeReturnTarget = false;
            this.cmdMain.Method = null;
            this.cmdMain.Object = null;
            this.cmdMain.Parameters.Add(this.cmdpMain);
            this.cmdMain.ReturnTarget = null;
            this.cmdMain.ReturnTargetProperty = null;
            this.cmdMain.Trigger = null;
            this.cmdMain.TriggerEvent = "Click";
            // 
            // cmdpMain
            // 
            this.cmdpMain.AcceptAfterExecuted = false;
            this.cmdpMain.ConstantValue = null;
            this.cmdpMain.MergeTarget = false;
            this.cmdpMain.SourceFilter = null;
            this.cmdpMain.SourceObject = null;
            this.cmdpMain.SourceProperty = null;
            this.cmdpMain.TargetObject = null;
            this.cmdpMain.TargetProperty = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableNAME,
            this.coldsMainL3DataTableINPUT_TIME,
            this.coldsMainL3DataTableVACTUBE_CODE,
            this.coldsMainL3DataTableINSTALL_ID,
            this.coldsMainL3DataTablePOSITION,
            this.coldsMainL3DataTableUP_SLOT_ID,
            this.coldsMainL3DataTableBEL_SLOT_ID,
            this.coldsMainL3DataTableFIRE_START_TIME,
            this.coldsMainL3DataTableFIRE_END_TIME,
            this.coldsMainL3DataTableTEAMID,
            this.coldsMainL3DataTableSHIFTID,
            this.coldsMainL3DataTableLOG_PER,
            this.coldsMainL3DataTableNOTE,
            this.coldsMainL3DataTableOBJECT_ID,
            this.coldsMainL3DataTableFIRE_SORUCE});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.DefaultValue = "";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableNAME
            // 
            this.coldsMainL3DataTableNAME.Caption = "NAME";
            this.coldsMainL3DataTableNAME.ColumnName = "NAME";
            this.coldsMainL3DataTableNAME.DefaultValue = "";
            this.coldsMainL3DataTableNAME.Namespace = "";
            // 
            // coldsMainL3DataTableINPUT_TIME
            // 
            this.coldsMainL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableVACTUBE_CODE
            // 
            this.coldsMainL3DataTableVACTUBE_CODE.Caption = "VACTUBE_CODE";
            this.coldsMainL3DataTableVACTUBE_CODE.ColumnName = "VACTUBE_CODE";
            this.coldsMainL3DataTableVACTUBE_CODE.DefaultValue = "";
            this.coldsMainL3DataTableVACTUBE_CODE.Namespace = "";
            // 
            // coldsMainL3DataTableINSTALL_ID
            // 
            this.coldsMainL3DataTableINSTALL_ID.Caption = "INSTALL_ID";
            this.coldsMainL3DataTableINSTALL_ID.ColumnName = "INSTALL_ID";
            this.coldsMainL3DataTableINSTALL_ID.DefaultValue = "";
            this.coldsMainL3DataTableINSTALL_ID.Namespace = "";
            // 
            // coldsMainL3DataTablePOSITION
            // 
            this.coldsMainL3DataTablePOSITION.Caption = "POSITION";
            this.coldsMainL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsMainL3DataTablePOSITION.DefaultValue = "";
            this.coldsMainL3DataTablePOSITION.Namespace = "";
            // 
            // coldsMainL3DataTableUP_SLOT_ID
            // 
            this.coldsMainL3DataTableUP_SLOT_ID.Caption = "UP_SLOT_ID";
            this.coldsMainL3DataTableUP_SLOT_ID.ColumnName = "UP_SLOT_ID";
            this.coldsMainL3DataTableUP_SLOT_ID.DefaultValue = "";
            this.coldsMainL3DataTableUP_SLOT_ID.Namespace = "";
            // 
            // coldsMainL3DataTableBEL_SLOT_ID
            // 
            this.coldsMainL3DataTableBEL_SLOT_ID.Caption = "BEL_SLOT_ID";
            this.coldsMainL3DataTableBEL_SLOT_ID.ColumnName = "BEL_SLOT_ID";
            this.coldsMainL3DataTableBEL_SLOT_ID.DefaultValue = "";
            this.coldsMainL3DataTableBEL_SLOT_ID.Namespace = "";
            // 
            // coldsMainL3DataTableFIRE_START_TIME
            // 
            this.coldsMainL3DataTableFIRE_START_TIME.Caption = "FIRE_START_TIME";
            this.coldsMainL3DataTableFIRE_START_TIME.ColumnName = "FIRE_START_TIME";
            this.coldsMainL3DataTableFIRE_START_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableFIRE_START_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableFIRE_END_TIME
            // 
            this.coldsMainL3DataTableFIRE_END_TIME.Caption = "FIRE_END_TIME";
            this.coldsMainL3DataTableFIRE_END_TIME.ColumnName = "FIRE_END_TIME";
            this.coldsMainL3DataTableFIRE_END_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableFIRE_END_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableTEAMID
            // 
            this.coldsMainL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsMainL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsMainL3DataTableTEAMID.DefaultValue = "";
            this.coldsMainL3DataTableTEAMID.Namespace = "";
            // 
            // coldsMainL3DataTableSHIFTID
            // 
            this.coldsMainL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.DefaultValue = "";
            this.coldsMainL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsMainL3DataTableLOG_PER
            // 
            this.coldsMainL3DataTableLOG_PER.Caption = "LOG_PER";
            this.coldsMainL3DataTableLOG_PER.ColumnName = "LOG_PER";
            this.coldsMainL3DataTableLOG_PER.DefaultValue = "";
            this.coldsMainL3DataTableLOG_PER.Namespace = "";
            // 
            // coldsMainL3DataTableNOTE
            // 
            this.coldsMainL3DataTableNOTE.Caption = "NOTE";
            this.coldsMainL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsMainL3DataTableNOTE.DefaultValue = "";
            this.coldsMainL3DataTableNOTE.Namespace = "";
            // 
            // coldsMainL3DataTableOBJECT_ID
            // 
            this.coldsMainL3DataTableOBJECT_ID.Caption = "OBJECT_ID";
            this.coldsMainL3DataTableOBJECT_ID.ColumnName = "OBJECT_ID";
            this.coldsMainL3DataTableOBJECT_ID.DefaultValue = "";
            this.coldsMainL3DataTableOBJECT_ID.Namespace = "";
            // 
            // coldsMainL3DataTableFIRE_SORUCE
            // 
            this.coldsMainL3DataTableFIRE_SORUCE.Caption = "FIRE_SORUCE";
            this.coldsMainL3DataTableFIRE_SORUCE.ColumnName = "FIRE_SORUCE";
            this.coldsMainL3DataTableFIRE_SORUCE.DataType = typeof(int);
            this.coldsMainL3DataTableFIRE_SORUCE.DefaultValue = 0;
            this.coldsMainL3DataTableFIRE_SORUCE.Namespace = "";
            // 
            // cmdpM
            // 
            this.cmdpM.AcceptAfterExecuted = false;
            this.cmdpM.ConstantValue = null;
            this.cmdpM.MergeTarget = false;
            this.cmdpM.SourceFilter = null;
            this.cmdpM.SourceObject = null;
            this.cmdpM.SourceProperty = null;
            this.cmdpM.TargetObject = null;
            this.cmdpM.TargetProperty = null;
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bdN1, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 3;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsMain;
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.txtVacTubeCode,
            this.toolStripLabel3,
            this.cmbPosition,
            this.toolStripLabel5,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel6});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 27;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel2.Text = "烘烤主信息";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtVacTubeCode
            // 
            this.txtVacTubeCode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtVacTubeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVacTubeCode.Name = "txtVacTubeCode";
            this.txtVacTubeCode.Size = new System.Drawing.Size(60, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "真空槽号:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel5.Text = "烘烤位置:";
            // 
            // dtEnd
            // 
            this.dtEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtEnd.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtEnd.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(100, 22);
            this.dtEnd.Text = "2008-11-16";
            this.dtEnd.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 884);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel4.Text = "-";
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 22);
            this.dtStart.Text = "2008-11-16";
            this.dtStart.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "录入日期:";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnOutPut});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 26;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "VacTubeFirebtn");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "VacTubeFirebtn");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "VacTubeFirebtn");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "VacTubeFirebtn");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "VacTubeFirebtn");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator3, "VacTubeFirebtn");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.splitContainer1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dvMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 632);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 34;
            // 
            // dvMain
            // 
            this.dvMain.AllowUserToAddRows = false;
            this.dvMain.AutoGenerateColumns = false;
            this.dvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.OBJECT_ID,
            this.VACTUBE_CODE,
            this.INSTALL_ID,
            this.POSITION,
            this.UP_SLOT_ID,
            this.BEL_SLOT_ID,
            this.fIRESTARTTIMEDataGridViewTextBoxColumn,
            this.fIREENDTIMEDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.lOGPERDataGridViewTextBoxColumn,
            this.fIRESORUCEDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(0, 0);
            this.dvMain.Margin = new System.Windows.Forms.Padding(0);
            this.dvMain.Name = "dvMain";
            this.dvMain.ReadOnly = true;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvMain.Size = new System.Drawing.Size(996, 158);
            this.dvMain.TabIndex = 33;
            this.dvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMain_CellDoubleClick);
            this.dvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvMain_DataBindingComplete);
            this.dvMain.Sorted += new System.EventHandler(this.dvMain_Sorted);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Frozen = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 120;
            // 
            // OBJECT_ID
            // 
            this.OBJECT_ID.DataPropertyName = "OBJECT_ID";
            this.OBJECT_ID.Frozen = true;
            this.OBJECT_ID.HeaderText = "主键";
            this.OBJECT_ID.Name = "OBJECT_ID";
            this.OBJECT_ID.ReadOnly = true;
            this.OBJECT_ID.Width = 80;
            // 
            // VACTUBE_CODE
            // 
            this.VACTUBE_CODE.DataPropertyName = "VACTUBE_CODE";
            this.VACTUBE_CODE.Frozen = true;
            this.VACTUBE_CODE.HeaderText = "真空槽编号";
            this.VACTUBE_CODE.Name = "VACTUBE_CODE";
            this.VACTUBE_CODE.ReadOnly = true;
            this.VACTUBE_CODE.Width = 80;
            // 
            // INSTALL_ID
            // 
            this.INSTALL_ID.DataPropertyName = "INSTALL_ID";
            this.INSTALL_ID.Frozen = true;
            this.INSTALL_ID.HeaderText = "组装编号";
            this.INSTALL_ID.Name = "INSTALL_ID";
            this.INSTALL_ID.ReadOnly = true;
            this.INSTALL_ID.Width = 80;
            // 
            // POSITION
            // 
            this.POSITION.DataPropertyName = "POSITION";
            this.POSITION.DataSource = this.dsPosition;
            this.POSITION.DisplayMember = "L3DataTable.Code_Des";
            this.POSITION.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.POSITION.Frozen = true;
            this.POSITION.HeaderText = "烘烤位置";
            this.POSITION.Name = "POSITION";
            this.POSITION.ReadOnly = true;
            this.POSITION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.POSITION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.POSITION.ValueMember = "L3DataTable.Code";
            this.POSITION.Width = 80;
            // 
            // dsPosition
            // 
            this.dsPosition.AutoSubscribe = false;
            this.dsPosition.DataSetName = "L3DataSet";
            this.dsPosition.DeleteMethod = "";
            this.dsPosition.InsertMethod = "";
            this.dsPosition.L3DataAdapter = this.Adapter;
            this.dsPosition.LoadEvent = "";
            this.dsPosition.LoadTrigger = null;
            this.dsPosition.RefreshValve = 60000;
            this.dsPosition.SourceCommand = null;
            this.dsPosition.SourceCondition = "Code_Group = \'VacTube_Position\' and Code <> \'1\' order by Code";
            this.dsPosition.SourceMethod = "";
            this.dsPosition.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPosition.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsPosition.SubscribeTarget = "";
            this.dsPosition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPosition});
            this.dsPosition.UpdateEvent = "";
            this.dsPosition.UpdateMethod = "";
            this.dsPosition.UpdateTrigger = null;
            // 
            // schemadsPosition
            // 
            this.schemadsPosition.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPositionL3DataTableCode,
            this.coldsPositionL3DataTableCode_Des});
            this.schemadsPosition.TableName = "L3DataTable";
            // 
            // coldsPositionL3DataTableCode
            // 
            this.coldsPositionL3DataTableCode.Caption = "Code";
            this.coldsPositionL3DataTableCode.ColumnName = "Code";
            this.coldsPositionL3DataTableCode.Namespace = "";
            // 
            // coldsPositionL3DataTableCode_Des
            // 
            this.coldsPositionL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsPositionL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsPositionL3DataTableCode_Des.Namespace = "";
            // 
            // UP_SLOT_ID
            // 
            this.UP_SLOT_ID.DataPropertyName = "UP_SLOT_ID";
            this.UP_SLOT_ID.HeaderText = "上部槽编号";
            this.UP_SLOT_ID.Name = "UP_SLOT_ID";
            this.UP_SLOT_ID.ReadOnly = true;
            this.UP_SLOT_ID.Width = 80;
            // 
            // BEL_SLOT_ID
            // 
            this.BEL_SLOT_ID.DataPropertyName = "BEL_SLOT_ID";
            this.BEL_SLOT_ID.HeaderText = "下部槽编号";
            this.BEL_SLOT_ID.Name = "BEL_SLOT_ID";
            this.BEL_SLOT_ID.ReadOnly = true;
            this.BEL_SLOT_ID.Width = 80;
            // 
            // fIRESTARTTIMEDataGridViewTextBoxColumn
            // 
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_START_TIME";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.HeaderText = "点火时间";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Name = "fIRESTARTTIMEDataGridViewTextBoxColumn";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Width = 120;
            // 
            // fIREENDTIMEDataGridViewTextBoxColumn
            // 
            this.fIREENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_END_TIME";
            this.fIREENDTIMEDataGridViewTextBoxColumn.HeaderText = "停火时间";
            this.fIREENDTIMEDataGridViewTextBoxColumn.Name = "fIREENDTIMEDataGridViewTextBoxColumn";
            this.fIREENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIREENDTIMEDataGridViewTextBoxColumn.Width = 120;
            // 
            // tEAMIDDataGridViewTextBoxColumn
            // 
            this.tEAMIDDataGridViewTextBoxColumn.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.tEAMIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tEAMIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tEAMIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn.Name = "tEAMIDDataGridViewTextBoxColumn";
            this.tEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tEAMIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tEAMIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.tEAMIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 60000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "Code_Group = \'TeamID\' order by Code";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // sHIFTIDDataGridViewTextBoxColumn
            // 
            this.sHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.sHIFTIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sHIFTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sHIFTIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn.Name = "sHIFTIDDataGridViewTextBoxColumn";
            this.sHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHIFTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHIFTIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.sHIFTIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 60000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "Code_Group = \'ShiftID\' order by Code";
            this.dsShiftID.SourceMethod = "";
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShiftID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftID});
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
            // 
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode,
            this.coldsShiftIDL3DataTableCode_Des});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // lOGPERDataGridViewTextBoxColumn
            // 
            this.lOGPERDataGridViewTextBoxColumn.DataPropertyName = "LOG_PER";
            this.lOGPERDataGridViewTextBoxColumn.HeaderText = "记录人";
            this.lOGPERDataGridViewTextBoxColumn.Name = "lOGPERDataGridViewTextBoxColumn";
            this.lOGPERDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOGPERDataGridViewTextBoxColumn.Width = 80;
            // 
            // fIRESORUCEDataGridViewTextBoxColumn
            // 
            this.fIRESORUCEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_SORUCE";
            this.fIRESORUCEDataGridViewTextBoxColumn.HeaderText = "烘烤信号来源";
            this.fIRESORUCEDataGridViewTextBoxColumn.Name = "fIRESORUCEDataGridViewTextBoxColumn";
            this.fIRESORUCEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRESORUCEDataGridViewTextBoxColumn.Width = 110;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn.Width = 200;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 462);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvDetail);
            this.tabPage1.Controls.Add(this.bdN2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(988, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "烘烤详细信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvDetail
            // 
            this.dvDetail.AllowUserToAddRows = false;
            this.dvDetail.AutoGenerateColumns = false;
            this.dvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn1,
            this.vACTUBECODEDataGridViewTextBoxColumn1,
            this.iNSTALLIDDataGridViewTextBoxColumn1,
            this.oBJECTIDDataGridViewTextBoxColumn1,
            this.gUIDDataGridViewTextBoxColumn1,
            this.nAMEDataGridViewTextBoxColumn1,
            this.tIMEIDDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn1,
            this.fACTTEMPDataGridViewTextBoxColumn,
            this.gUNHEIGHTDataGridViewTextBoxColumn,
            this.gASFLOWDataGridViewTextBoxColumn,
            this.o2FLOWDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn1,
            this.sHIFTIDDataGridViewTextBoxColumn1,
            this.lOGPERDataGridViewTextBoxColumn1,
            this.fIRESORUCEDataGridViewTextBoxColumn1,
            this.nOTEDataGridViewTextBoxColumn1});
            this.dvDetail.DataSource = this.bsDetail;
            this.dvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDetail.Location = new System.Drawing.Point(0, 25);
            this.dvDetail.Margin = new System.Windows.Forms.Padding(0);
            this.dvDetail.Name = "dvDetail";
            this.dvDetail.ReadOnly = true;
            this.dvDetail.RowTemplate.Height = 23;
            this.dvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDetail.Size = new System.Drawing.Size(988, 412);
            this.dvDetail.TabIndex = 28;
            this.dvDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvDetail_CellDoubleClick);
            this.dvDetail.Sorted += new System.EventHandler(this.dvDetail_Sorted);
            this.dvDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn1
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn1.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Frozen = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn1.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Name = "iNPUTTIMEDataGridViewTextBoxColumn1";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Width = 78;
            // 
            // vACTUBECODEDataGridViewTextBoxColumn1
            // 
            this.vACTUBECODEDataGridViewTextBoxColumn1.DataPropertyName = "VACTUBE_CODE";
            this.vACTUBECODEDataGridViewTextBoxColumn1.Frozen = true;
            this.vACTUBECODEDataGridViewTextBoxColumn1.HeaderText = "真空槽编号";
            this.vACTUBECODEDataGridViewTextBoxColumn1.Name = "vACTUBECODEDataGridViewTextBoxColumn1";
            this.vACTUBECODEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.vACTUBECODEDataGridViewTextBoxColumn1.Width = 90;
            // 
            // iNSTALLIDDataGridViewTextBoxColumn1
            // 
            this.iNSTALLIDDataGridViewTextBoxColumn1.DataPropertyName = "INSTALL_ID";
            this.iNSTALLIDDataGridViewTextBoxColumn1.Frozen = true;
            this.iNSTALLIDDataGridViewTextBoxColumn1.HeaderText = "组装编号";
            this.iNSTALLIDDataGridViewTextBoxColumn1.Name = "iNSTALLIDDataGridViewTextBoxColumn1";
            this.iNSTALLIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iNSTALLIDDataGridViewTextBoxColumn1.Width = 78;
            // 
            // oBJECTIDDataGridViewTextBoxColumn1
            // 
            this.oBJECTIDDataGridViewTextBoxColumn1.DataPropertyName = "OBJECT_ID";
            this.oBJECTIDDataGridViewTextBoxColumn1.Frozen = true;
            this.oBJECTIDDataGridViewTextBoxColumn1.HeaderText = "主信息主键";
            this.oBJECTIDDataGridViewTextBoxColumn1.Name = "oBJECTIDDataGridViewTextBoxColumn1";
            this.oBJECTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.oBJECTIDDataGridViewTextBoxColumn1.Width = 90;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            this.gUIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // nAMEDataGridViewTextBoxColumn1
            // 
            this.nAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            this.nAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn1.Visible = false;
            this.nAMEDataGridViewTextBoxColumn1.Width = 54;
            // 
            // tIMEIDDataGridViewTextBoxColumn
            // 
            this.tIMEIDDataGridViewTextBoxColumn.DataPropertyName = "TIME_ID";
            this.tIMEIDDataGridViewTextBoxColumn.HeaderText = "时间[H]";
            this.tIMEIDDataGridViewTextBoxColumn.Name = "tIMEIDDataGridViewTextBoxColumn";
            this.tIMEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIMEIDDataGridViewTextBoxColumn.Width = 72;
            // 
            // pOSITIONDataGridViewTextBoxColumn1
            // 
            this.pOSITIONDataGridViewTextBoxColumn1.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn1.DataSource = this.dsPosition;
            this.pOSITIONDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.pOSITIONDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pOSITIONDataGridViewTextBoxColumn1.HeaderText = "烘烤位置";
            this.pOSITIONDataGridViewTextBoxColumn1.Name = "pOSITIONDataGridViewTextBoxColumn1";
            this.pOSITIONDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pOSITIONDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOSITIONDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pOSITIONDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.pOSITIONDataGridViewTextBoxColumn1.Width = 78;
            // 
            // fACTTEMPDataGridViewTextBoxColumn
            // 
            this.fACTTEMPDataGridViewTextBoxColumn.DataPropertyName = "FACT_TEMP";
            this.fACTTEMPDataGridViewTextBoxColumn.HeaderText = "实际温度[℃]";
            this.fACTTEMPDataGridViewTextBoxColumn.Name = "fACTTEMPDataGridViewTextBoxColumn";
            this.fACTTEMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.fACTTEMPDataGridViewTextBoxColumn.Width = 102;
            // 
            // gUNHEIGHTDataGridViewTextBoxColumn
            // 
            this.gUNHEIGHTDataGridViewTextBoxColumn.DataPropertyName = "GUN_HEIGHT";
            this.gUNHEIGHTDataGridViewTextBoxColumn.HeaderText = "枪位高度[m]";
            this.gUNHEIGHTDataGridViewTextBoxColumn.Name = "gUNHEIGHTDataGridViewTextBoxColumn";
            this.gUNHEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUNHEIGHTDataGridViewTextBoxColumn.Width = 96;
            // 
            // gASFLOWDataGridViewTextBoxColumn
            // 
            this.gASFLOWDataGridViewTextBoxColumn.DataPropertyName = "GAS_FLOW";
            this.gASFLOWDataGridViewTextBoxColumn.HeaderText = "煤气流量[Nm3/h]";
            this.gASFLOWDataGridViewTextBoxColumn.Name = "gASFLOWDataGridViewTextBoxColumn";
            this.gASFLOWDataGridViewTextBoxColumn.ReadOnly = true;
            this.gASFLOWDataGridViewTextBoxColumn.Width = 120;
            // 
            // o2FLOWDataGridViewTextBoxColumn
            // 
            this.o2FLOWDataGridViewTextBoxColumn.DataPropertyName = "O2_FLOW";
            this.o2FLOWDataGridViewTextBoxColumn.HeaderText = "氧气流量[Nm3/h]";
            this.o2FLOWDataGridViewTextBoxColumn.Name = "o2FLOWDataGridViewTextBoxColumn";
            this.o2FLOWDataGridViewTextBoxColumn.ReadOnly = true;
            this.o2FLOWDataGridViewTextBoxColumn.Width = 120;
            // 
            // tEAMIDDataGridViewTextBoxColumn1
            // 
            this.tEAMIDDataGridViewTextBoxColumn1.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn1.DataSource = this.dsTeamID;
            this.tEAMIDDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.tEAMIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tEAMIDDataGridViewTextBoxColumn1.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn1.Name = "tEAMIDDataGridViewTextBoxColumn1";
            this.tEAMIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tEAMIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tEAMIDDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.tEAMIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // sHIFTIDDataGridViewTextBoxColumn1
            // 
            this.sHIFTIDDataGridViewTextBoxColumn1.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn1.DataSource = this.dsShiftID;
            this.sHIFTIDDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.sHIFTIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sHIFTIDDataGridViewTextBoxColumn1.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn1.Name = "sHIFTIDDataGridViewTextBoxColumn1";
            this.sHIFTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHIFTIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHIFTIDDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.sHIFTIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // lOGPERDataGridViewTextBoxColumn1
            // 
            this.lOGPERDataGridViewTextBoxColumn1.DataPropertyName = "LOG_PER";
            this.lOGPERDataGridViewTextBoxColumn1.HeaderText = "记录人";
            this.lOGPERDataGridViewTextBoxColumn1.Name = "lOGPERDataGridViewTextBoxColumn1";
            this.lOGPERDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lOGPERDataGridViewTextBoxColumn1.Width = 66;
            // 
            // fIRESORUCEDataGridViewTextBoxColumn1
            // 
            this.fIRESORUCEDataGridViewTextBoxColumn1.DataPropertyName = "FIRE_SORUCE";
            this.fIRESORUCEDataGridViewTextBoxColumn1.HeaderText = "烘烤信号来源";
            this.fIRESORUCEDataGridViewTextBoxColumn1.Name = "fIRESORUCEDataGridViewTextBoxColumn1";
            this.fIRESORUCEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fIRESORUCEDataGridViewTextBoxColumn1.Width = 102;
            // 
            // nOTEDataGridViewTextBoxColumn1
            // 
            this.nOTEDataGridViewTextBoxColumn1.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn1.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn1.Name = "nOTEDataGridViewTextBoxColumn1";
            this.nOTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn1.Width = 54;
            // 
            // bsDetail
            // 
            this.bsDetail.DataMember = "L3DataTable";
            this.bsDetail.DataSource = this.dsDetail;
            // 
            // dsDetail
            // 
            this.dsDetail.AutoSubscribe = false;
            this.dsDetail.DataSetName = "L3DataSet";
            this.dsDetail.DeleteMethod = "DeleteVacTubeFireInfo";
            this.dsDetail.InsertMethod = "InsertVacTubeFireInfo";
            this.dsDetail.L3DataAdapter = this.Adapter;
            this.dsDetail.LoadEvent = "";
            this.dsDetail.LoadTrigger = null;
            this.dsDetail.RefreshValve = 60000;
            this.dsDetail.SourceCommand = this.cmdDetail;
            this.dsDetail.SourceCondition = "";
            this.dsDetail.SourceMethod = "GetVacTubeFireInfo";
            this.dsDetail.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsDetail.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.dsDetail.SubscribeTarget = "";
            this.dsDetail.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDetail});
            this.dsDetail.UpdateEvent = "";
            this.dsDetail.UpdateMethod = "UpdateVacTubeFireInfo";
            this.dsDetail.UpdateTrigger = null;
            // 
            // cmdDetail
            // 
            this.cmdDetail.Adapter = null;
            this.cmdDetail.MergeReturnTarget = false;
            this.cmdDetail.Method = null;
            this.cmdDetail.Object = null;
            this.cmdDetail.Parameters.Add(this.cmdpDetail);
            this.cmdDetail.ReturnTarget = null;
            this.cmdDetail.ReturnTargetProperty = null;
            this.cmdDetail.Trigger = null;
            this.cmdDetail.TriggerEvent = "Click";
            // 
            // cmdpDetail
            // 
            this.cmdpDetail.AcceptAfterExecuted = false;
            this.cmdpDetail.ConstantValue = null;
            this.cmdpDetail.MergeTarget = false;
            this.cmdpDetail.SourceFilter = null;
            this.cmdpDetail.SourceObject = null;
            this.cmdpDetail.SourceProperty = null;
            this.cmdpDetail.TargetObject = null;
            this.cmdpDetail.TargetProperty = null;
            // 
            // schemadsDetail
            // 
            this.schemadsDetail.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDetailL3DataTableGUID,
            this.coldsDetailL3DataTableNAME,
            this.coldsDetailL3DataTableINPUT_TIME,
            this.coldsDetailL3DataTableVACTUBE_CODE,
            this.coldsDetailL3DataTableINSTALL_ID,
            this.coldsDetailL3DataTableOBJECT_ID,
            this.coldsDetailL3DataTableTIME_ID,
            this.coldsDetailL3DataTablePOSITION,
            this.coldsDetailL3DataTableFACT_TEMP,
            this.coldsDetailL3DataTableGUN_HEIGHT,
            this.coldsDetailL3DataTableGAS_FLOW,
            this.coldsDetailL3DataTableO2_FLOW,
            this.coldsDetailL3DataTableTEAMID,
            this.coldsDetailL3DataTableSHIFTID,
            this.coldsDetailL3DataTableLOG_PER,
            this.coldsDetailL3DataTableFIRE_SORUCE,
            this.coldsDetailL3DataTableNOTE});
            this.schemadsDetail.TableName = "L3DataTable";
            // 
            // coldsDetailL3DataTableGUID
            // 
            this.coldsDetailL3DataTableGUID.Caption = "GUID";
            this.coldsDetailL3DataTableGUID.ColumnName = "GUID";
            this.coldsDetailL3DataTableGUID.DefaultValue = "";
            this.coldsDetailL3DataTableGUID.Namespace = "";
            // 
            // coldsDetailL3DataTableNAME
            // 
            this.coldsDetailL3DataTableNAME.Caption = "NAME";
            this.coldsDetailL3DataTableNAME.ColumnName = "NAME";
            this.coldsDetailL3DataTableNAME.DefaultValue = "";
            this.coldsDetailL3DataTableNAME.Namespace = "";
            // 
            // coldsDetailL3DataTableINPUT_TIME
            // 
            this.coldsDetailL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsDetailL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsDetailL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsDetailL3DataTableVACTUBE_CODE
            // 
            this.coldsDetailL3DataTableVACTUBE_CODE.Caption = "VACTUBE_CODE";
            this.coldsDetailL3DataTableVACTUBE_CODE.ColumnName = "VACTUBE_CODE";
            this.coldsDetailL3DataTableVACTUBE_CODE.DefaultValue = "";
            this.coldsDetailL3DataTableVACTUBE_CODE.Namespace = "";
            // 
            // coldsDetailL3DataTableINSTALL_ID
            // 
            this.coldsDetailL3DataTableINSTALL_ID.Caption = "INSTALL_ID";
            this.coldsDetailL3DataTableINSTALL_ID.ColumnName = "INSTALL_ID";
            this.coldsDetailL3DataTableINSTALL_ID.DefaultValue = "";
            this.coldsDetailL3DataTableINSTALL_ID.Namespace = "";
            // 
            // coldsDetailL3DataTableOBJECT_ID
            // 
            this.coldsDetailL3DataTableOBJECT_ID.Caption = "OBJECT_ID";
            this.coldsDetailL3DataTableOBJECT_ID.ColumnName = "OBJECT_ID";
            this.coldsDetailL3DataTableOBJECT_ID.DefaultValue = "";
            this.coldsDetailL3DataTableOBJECT_ID.Namespace = "";
            // 
            // coldsDetailL3DataTableTIME_ID
            // 
            this.coldsDetailL3DataTableTIME_ID.Caption = "TIME_ID";
            this.coldsDetailL3DataTableTIME_ID.ColumnName = "TIME_ID";
            this.coldsDetailL3DataTableTIME_ID.DataType = typeof(int);
            this.coldsDetailL3DataTableTIME_ID.DefaultValue = 0;
            this.coldsDetailL3DataTableTIME_ID.Namespace = "";
            // 
            // coldsDetailL3DataTablePOSITION
            // 
            this.coldsDetailL3DataTablePOSITION.Caption = "POSITION";
            this.coldsDetailL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsDetailL3DataTablePOSITION.DefaultValue = "";
            this.coldsDetailL3DataTablePOSITION.Namespace = "";
            // 
            // coldsDetailL3DataTableFACT_TEMP
            // 
            this.coldsDetailL3DataTableFACT_TEMP.Caption = "FACT_TEMP";
            this.coldsDetailL3DataTableFACT_TEMP.ColumnName = "FACT_TEMP";
            this.coldsDetailL3DataTableFACT_TEMP.DataType = typeof(double);
            this.coldsDetailL3DataTableFACT_TEMP.DefaultValue = 0;
            this.coldsDetailL3DataTableFACT_TEMP.Namespace = "";
            // 
            // coldsDetailL3DataTableGUN_HEIGHT
            // 
            this.coldsDetailL3DataTableGUN_HEIGHT.Caption = "GUN_HEIGHT";
            this.coldsDetailL3DataTableGUN_HEIGHT.ColumnName = "GUN_HEIGHT";
            this.coldsDetailL3DataTableGUN_HEIGHT.DataType = typeof(double);
            this.coldsDetailL3DataTableGUN_HEIGHT.DefaultValue = 0;
            this.coldsDetailL3DataTableGUN_HEIGHT.Namespace = "";
            // 
            // coldsDetailL3DataTableGAS_FLOW
            // 
            this.coldsDetailL3DataTableGAS_FLOW.Caption = "GAS_FLOW";
            this.coldsDetailL3DataTableGAS_FLOW.ColumnName = "GAS_FLOW";
            this.coldsDetailL3DataTableGAS_FLOW.DataType = typeof(double);
            this.coldsDetailL3DataTableGAS_FLOW.DefaultValue = 0;
            this.coldsDetailL3DataTableGAS_FLOW.Namespace = "";
            // 
            // coldsDetailL3DataTableO2_FLOW
            // 
            this.coldsDetailL3DataTableO2_FLOW.Caption = "O2_FLOW";
            this.coldsDetailL3DataTableO2_FLOW.ColumnName = "O2_FLOW";
            this.coldsDetailL3DataTableO2_FLOW.DataType = typeof(double);
            this.coldsDetailL3DataTableO2_FLOW.DefaultValue = 0;
            this.coldsDetailL3DataTableO2_FLOW.Namespace = "";
            // 
            // coldsDetailL3DataTableTEAMID
            // 
            this.coldsDetailL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsDetailL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsDetailL3DataTableTEAMID.DefaultValue = "";
            this.coldsDetailL3DataTableTEAMID.Namespace = "";
            // 
            // coldsDetailL3DataTableSHIFTID
            // 
            this.coldsDetailL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsDetailL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsDetailL3DataTableSHIFTID.DefaultValue = "";
            this.coldsDetailL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsDetailL3DataTableLOG_PER
            // 
            this.coldsDetailL3DataTableLOG_PER.Caption = "LOG_PER";
            this.coldsDetailL3DataTableLOG_PER.ColumnName = "LOG_PER";
            this.coldsDetailL3DataTableLOG_PER.DefaultValue = "";
            this.coldsDetailL3DataTableLOG_PER.Namespace = "";
            // 
            // coldsDetailL3DataTableFIRE_SORUCE
            // 
            this.coldsDetailL3DataTableFIRE_SORUCE.Caption = "FIRE_SORUCE";
            this.coldsDetailL3DataTableFIRE_SORUCE.ColumnName = "FIRE_SORUCE";
            this.coldsDetailL3DataTableFIRE_SORUCE.DataType = typeof(int);
            this.coldsDetailL3DataTableFIRE_SORUCE.DefaultValue = 0;
            this.coldsDetailL3DataTableFIRE_SORUCE.Namespace = "";
            // 
            // coldsDetailL3DataTableNOTE
            // 
            this.coldsDetailL3DataTableNOTE.Caption = "NOTE";
            this.coldsDetailL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsDetailL3DataTableNOTE.DefaultValue = "";
            this.coldsDetailL3DataTableNOTE.Namespace = "";
            // 
            // bdN2
            // 
            this.bdN2.AddNewItem = null;
            this.bdN2.BindingSource = this.bsDetail;
            this.bdN2.CountItem = this.bindingNavigatorCountItem1;
            this.bdN2.DeleteItem = null;
            this.bdN2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator3,
            this.btnAddDetail,
            this.btnDelDetail,
            this.toolStripSeparator5,
            this.btnConfirmDetail,
            this.btnCancelDetail,
            this.toolStripSeparator4,
            this.btnOutPutDetial});
            this.bdN2.Location = new System.Drawing.Point(0, 0);
            this.bdN2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bdN2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bdN2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bdN2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bdN2.Name = "bdN2";
            this.bdN2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bdN2.Size = new System.Drawing.Size(988, 25);
            this.bdN2.TabIndex = 27;
            this.bdN2.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "/ {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "位置";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddDetail
            // 
            this.Adapter.SetAccessRight(this.btnAddDetail, "VacTubeFirebtn");
            this.btnAddDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDetail.Image")));
            this.btnAddDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(49, 22);
            this.btnAddDetail.Text = "新增";
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnDelDetail
            // 
            this.Adapter.SetAccessRight(this.btnDelDetail, "VacTubeFirebtn");
            this.btnDelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDelDetail.Image")));
            this.btnDelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(49, 22);
            this.btnDelDetail.Text = "删除";
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // toolStripSeparator5
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator5, "VacTubeFirebtn");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConfirmDetail
            // 
            this.Adapter.SetAccessRight(this.btnConfirmDetail, "VacTubeFirebtn");
            this.btnConfirmDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmDetail.Image")));
            this.btnConfirmDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmDetail.Name = "btnConfirmDetail";
            this.btnConfirmDetail.Size = new System.Drawing.Size(55, 22);
            this.btnConfirmDetail.Text = "确定 ";
            this.btnConfirmDetail.Click += new System.EventHandler(this.btnConfirmDetail_Click);
            // 
            // btnCancelDetail
            // 
            this.Adapter.SetAccessRight(this.btnCancelDetail, "VacTubeFirebtn");
            this.btnCancelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDetail.Image")));
            this.btnCancelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelDetail.Name = "btnCancelDetail";
            this.btnCancelDetail.Size = new System.Drawing.Size(49, 22);
            this.btnCancelDetail.Text = "取消";
            this.btnCancelDetail.Click += new System.EventHandler(this.btnCancelDetail_Click);
            // 
            // toolStripSeparator4
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator4, "VacTubeFirebtn");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOutPutDetial
            // 
            this.btnOutPutDetial.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPutDetial.Image")));
            this.btnOutPutDetial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPutDetial.Name = "btnOutPutDetial";
            this.btnOutPutDetial.Size = new System.Drawing.Size(91, 22);
            this.btnOutPutDetial.Text = "导出到Excel";
            this.btnOutPutDetial.Click += new System.EventHandler(this.btnOutPutDetial_Click);
            // 
            // VacTubeFireMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VacTubeFireMagFrm";
            this.TabText = "真空槽烘烤信息管理";
            this.Text = "真空槽烘烤信息管理";
            this.Load += new System.EventHandler(this.VacTubeFireMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN2)).EndInit();
            this.bdN2.ResumeLayout(false);
            this.bdN2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private AppSvrHMI.L3CommandParameter cmdpM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dvMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingSource bsDetail;
        private AppSvrHMI.L3Command cmdMain;
        private AppSvrHMI.L3CommandParameter cmdpMain;
        private AppSvrHMI.L3Command cmdDetail;
        private AppSvrHMI.L3CommandParameter cmdpDetail;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView dvDetail;
        private System.Windows.Forms.BindingNavigator bdN2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripButton btnAddDetail;
        private System.Windows.Forms.ToolStripButton btnDelDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirmDetail;
        private System.Windows.Forms.ToolStripButton btnCancelDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnOutPutDetial;
        private System.Windows.Forms.ToolStripTextBox txtVacTubeCode;
        private AppSvrHMI.L3DataSet dsMain;
        private AppSvrHMI.L3DataSet dsDetail;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsMainL3DataTableVACTUBE_CODE;
        private System.Data.DataColumn coldsMainL3DataTableINSTALL_ID;
        private System.Data.DataColumn coldsMainL3DataTablePOSITION;
        private System.Data.DataColumn coldsMainL3DataTableUP_SLOT_ID;
        private System.Data.DataColumn coldsMainL3DataTableBEL_SLOT_ID;
        private System.Data.DataColumn coldsMainL3DataTableFIRE_START_TIME;
        private System.Data.DataColumn coldsMainL3DataTableFIRE_END_TIME;
        private System.Data.DataColumn coldsMainL3DataTableTEAMID;
        private System.Data.DataColumn coldsMainL3DataTableSHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableLOG_PER;
        private System.Data.DataColumn coldsMainL3DataTableNOTE;
        private System.Data.DataColumn coldsMainL3DataTableOBJECT_ID;
        private System.Data.DataColumn coldsMainL3DataTableFIRE_SORUCE;
        private System.Data.DataTable schemadsDetail;
        private System.Data.DataColumn coldsDetailL3DataTableGUID;
        private System.Data.DataColumn coldsDetailL3DataTableNAME;
        private System.Data.DataColumn coldsDetailL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableVACTUBE_CODE;
        private System.Data.DataColumn coldsDetailL3DataTableINSTALL_ID;
        private System.Data.DataColumn coldsDetailL3DataTableOBJECT_ID;
        private System.Data.DataColumn coldsDetailL3DataTableTIME_ID;
        private System.Data.DataColumn coldsDetailL3DataTablePOSITION;
        private System.Data.DataColumn coldsDetailL3DataTableFACT_TEMP;
        private System.Data.DataColumn coldsDetailL3DataTableGUN_HEIGHT;
        private System.Data.DataColumn coldsDetailL3DataTableGAS_FLOW;
        private System.Data.DataColumn coldsDetailL3DataTableO2_FLOW;
        private System.Data.DataColumn coldsDetailL3DataTableTEAMID;
        private System.Data.DataColumn coldsDetailL3DataTableSHIFTID;
        private System.Data.DataColumn coldsDetailL3DataTableLOG_PER;
        private System.Data.DataColumn coldsDetailL3DataTableFIRE_SORUCE;
        private System.Data.DataColumn coldsDetailL3DataTableNOTE;
        private AppSvrHMI.L3DataSet dsPosition;
        private System.Data.DataTable schemadsPosition;
        private System.Data.DataColumn coldsPositionL3DataTableCode;
        private System.Data.DataColumn coldsPositionL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJECT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VACTUBE_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSTALL_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn POSITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn UP_SLOT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BEL_SLOT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRESTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIREENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGPERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRESORUCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACTUBECODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSTALLIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBJECTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pOSITIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACTTEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUNHEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gASFLOWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn o2FLOWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGPERDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRESORUCEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbPosition;
    }
}