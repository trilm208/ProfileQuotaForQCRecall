using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shell.DataView
{
    class CustomFlowLayoutPanel : FlowLayoutPanel
    {
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            this.OnResize(EventArgs.Empty);
        }


        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);

           
        }
    }
}
