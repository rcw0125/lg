using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFMain03 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public BOFMain03()
        {
            MainUnitType = UnitType.BOF;
            CurUnitID = 3;

            InitializeComponent();
        }
    }
}
