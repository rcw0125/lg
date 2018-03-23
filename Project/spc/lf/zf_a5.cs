using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc.lf
{
    public partial class zf_a5 : spc.spclf
    {
        public zf_a5()
        {
            unit = "F5";
            qcitemcode = "Al2O3";
            qc_des = "5#LF������Al2O3";
            DataObject = @"XGMESLogic\LFMag\CLF_Unit_Mag\S45";
            maintype = "zhayang";
            InitializeComponent();
        }
    }
}
