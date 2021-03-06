using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace NCTelDataMag
{
    public partial class  IronQualityFrm : DockContent, IMESForm
    {
        public IronQualityFrm()
        {
            InitializeComponent();
        }

        #region IMESForm 成员

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            dsMain.Tables[0].Clear();
            dsMaterial1.Tables[0].Clear();
            dsMaterial2.Tables[0].Clear();
            if (txbHeatID.Text != "")
            {
                cmdMain.Parameters[0].ConstantValue = txbHeatID.Text;
                cmdMain.Execute();
            }

        }

        private void btnUpdateSend_Click(object sender, EventArgs e)
        {
            //if (TelComm.deleteXml() == false)
            //{
            //    MessageBox.Show("请手动删除DataSent文件中的MES_Data.xml文件!");
            //    return;
            //}
            string strXslt = @"updateIronQualityJudgeInfor.xslt";
            //组织发送记录集
            DataSet dsM = new DataSet();

            if (dsMain.Tables[0].Rows.Count > 0)
            {
                //组织主表记录集
                DataTable tbM = new DataTable();
                tbM = dsMain.Tables[0].Clone();
                tbM = dsMain.Tables[0].Copy();
                tbM.TableName = "M";
                dsM.Tables.Add(tbM);
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }

            //组织从表记录集1
            if (dsMaterial1.Tables[0].Rows.Count > 0)
            {
                DataTable tbS1 = new DataTable();
                tbS1 = dsMaterial1.Tables[0].Clone();
                tbS1 = dsMaterial1.Tables[0].Copy();
                tbS1.TableName = "s1";
                dsM.Tables.Add(tbS1);
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }
            //组织从表记录集2
            if (dsMaterial2.Tables[0].Rows.Count > 0)
            {
                DataTable tbS2 = new DataTable();
                tbS2 = dsMaterial2.Tables[0].Clone();
                tbS2 = dsMaterial2.Tables[0].Copy();
                tbS2.TableName = "s2";
                dsM.Tables.Add(tbS2);
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }

            string strXML = TelComm.TranslateDataSetToNC(strXslt, dsM);
            string strRet = TelComm.TransferXML(strXML);
            if (strRet != "")
            {
                if (strRet == "1")
                {
                    //组建成功记录集
                    dsLog.Clear();
                    DataRow row = dsLog.Tables[0].NewRow();
                    row["HeatID"] = dsM.Tables[0].Rows[0]["HeatID"].ToString();
                    row["BillType"] = strXslt;
                    row["Other1"] = dsM.Tables[0].Rows[0]["Flag"].ToString();
                    row["Flag"] = "0";
                    dsLog.Tables[0].Rows.Add(row);

                    AppSvrIF.Command cmdLog = null;
                    int iRet = Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, @"XGMESLogic\BaseDataMag\CBaseData_Mag\BaseData_Mag", "WriteLogFromNC", ref cmdLog);
                    if (iRet != 0)
                        return;
                    cmdLog.set_Parameters(0, dsLog);
                    Adapter.Session.Execute(cmdLog);
                }
                else
                {
                    //组建失败记录集
                    dsLog.Clear();
                    DataRow row = dsLog.Tables[0].NewRow();
                    row["HeatID"] = dsM.Tables[0].Rows[0]["HeatID"].ToString();
                    row["BillType"] = strXslt;
                    row["Other1"] = dsM.Tables[0].Rows[0]["Flag"].ToString();
                    row["Flag"] = "1";
                    row["Remark"] = strRet;
                    dsLog.Tables[0].Rows.Add(row);

                    AppSvrIF.Command cmdLog = null;
                    int iRet = Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, @"XGMESLogic\BaseDataMag\CBaseData_Mag\BaseData_Mag", "WriteLogFromNC", ref cmdLog);
                    if (iRet != 0)
                        return;
                    cmdLog.set_Parameters(0, dsLog);
                    Adapter.Session.Execute(cmdLog);
                }
            }
            else
            {
                MessageBox.Show("发送失败!");
            }
        }

        private void btnAddSend_Click(object sender, EventArgs e)
        {
            //if (TelComm.deleteXml() == false)
            //{
            //    MessageBox.Show("请手动删除DataSent文件中的MES_Data.xml文件!");
            //    return;
            //}
            string strXslt = @"IronQualityJudgeInfor.xslt";
            //组织发送记录集
            DataSet dsM = new DataSet();

            if (dsMain.Tables[0].Rows.Count > 0)
            {
                //组织主表记录集
                DataTable tbM = new DataTable();
                tbM = dsMain.Tables[0].Clone();
                tbM = dsMain.Tables[0].Copy();
                tbM.TableName = "M";
                dsM.Tables.Add(tbM);
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }

            //组织从表记录集1
            if (dsMaterial1.Tables[0].Rows.Count > 0)
            {
                DataTable tbS1 = new DataTable();
                tbS1 = dsMaterial1.Tables[0].Clone();
                tbS1 = dsMaterial1.Tables[0].Copy();
                tbS1.TableName = "s1";
                dsM.Tables.Add(tbS1);
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }
            //组织从表记录集2
            if (dsMaterial2.Tables[0].Rows.Count > 0)
            {
                DataTable tbS2 = new DataTable();
                tbS2 = dsMaterial2.Tables[0].Clone();
                tbS2 = dsMaterial2.Tables[0].Copy();
                tbS2.TableName = "s2";
                dsM.Tables.Add(tbS2);
            }
            else
            {
                MessageBox.Show("请查询出需要上传的数据!");
                return;
            }

            string strXML = TelComm.TranslateDataSetToNC(strXslt, dsM);
            string strRet = TelComm.TransferXML(strXML);
            if (strRet != "")
            {
                if (strRet == "1")
                {
                    //组建成功记录集
                    dsLog.Clear();
                    DataRow row = dsLog.Tables[0].NewRow();
                    row["HeatID"] = dsM.Tables[0].Rows[0]["HeatID"].ToString();
                    row["BillType"] = strXslt;
                    row["Other1"] = dsM.Tables[0].Rows[0]["Flag"].ToString();
                    row["Flag"] = "0";
                    dsLog.Tables[0].Rows.Add(row);

                    AppSvrIF.Command cmdLog = null;
                    int iRet = Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, @"XGMESLogic\BaseDataMag\CBaseData_Mag\BaseData_Mag", "WriteLogFromNC", ref cmdLog);
                    if (iRet != 0)
                        return;
                    cmdLog.set_Parameters(0, dsLog);
                    Adapter.Session.Execute(cmdLog);
                }
                else
                {
                    //组建失败记录集
                    dsLog.Clear();
                    DataRow row = dsLog.Tables[0].NewRow();
                    row["HeatID"] = dsM.Tables[0].Rows[0]["HeatID"].ToString();
                    row["BillType"] = strXslt;
                    row["Other1"] = dsM.Tables[0].Rows[0]["Flag"].ToString();
                    row["Flag"] = "1";
                    row["Remark"] = strRet;
                    dsLog.Tables[0].Rows.Add(row);

                    AppSvrIF.Command cmdLog = null;
                    int iRet = Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, @"XGMESLogic\BaseDataMag\CBaseData_Mag\BaseData_Mag", "WriteLogFromNC", ref cmdLog);
                    if (iRet != 0)
                        return;
                    cmdLog.set_Parameters(0, dsLog);
                    Adapter.Session.Execute(cmdLog);
                }
            }
            else
            {
                MessageBox.Show("发送失败!");
            }
        }

        private void dvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

       
    }
}