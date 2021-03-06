using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.VacTubeMag
{
    public partial class VacTubeFireMagShowFrm : Form
    {
        public VacTubeFireMagShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            bsMain.DataSource = null;
            bsMain.DataSource = dsData;
            bsMain.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort = strSort;
            bsMain.Position = nPosition;

            return ShowDialog();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsMain.EndEdit();
            this.Close();
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            this.Close();
        }

        private void VacTubeFireMagShowFrm_Load(object sender, EventArgs e)
        {
          
        }
    }
}