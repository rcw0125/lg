using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class RHHeatRemarkFrm : Form
    {
        public RHHeatRemarkFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.Session = session;

            return ShowDialog();
        }
    }
}