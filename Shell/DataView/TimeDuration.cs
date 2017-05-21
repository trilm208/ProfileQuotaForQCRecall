using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QA;

namespace Shell.DataView
{
    public partial class TimeDuration : ClientControl
    {
        public TimeDuration()
        {
            InitializeComponent();
        }

        public  void Load(DataTable dt)
        {
            gridControl1.DataSource = dt;
        }
    }
}
