using QA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shell
{
    public partial class frmFWRecall : ClientForm
    {
        public frmFWRecall()
        {
            InitializeComponent();

          
        }

        public string ProjectID { get;  set; }
        public string ProjectNo { get; internal set; }
        public bool IsNeedPlaceProduct;
        public override void Process()
        {
            base.Process();
          
            respondentProfileInformation1.Initialize(Services);
            respondentProfileInformation1.ProjectID = this.ProjectID;
            respondentProfileInformation1.ProjectNo = this.ProjectNo;
            respondentProfileInformation1.IsNeedPlaceProduct = this.IsNeedPlaceProduct;
            respondentProfileInformation1.Process();

            summaryQC1.Initialize(Services);
            summaryQC1.ProjectID = this.ProjectID;
            summaryQC1.Process();

            summaryVal1.Initialize(Services);
            summaryVal1.ProjectID = this.ProjectID;
            summaryVal1.Process();
            
            
            summarySupInterview1.Initialize(Services);
            summarySupInterview1.ProjectID = this.ProjectID;
            summarySupInterview1.Process();

            summarySupRecuit1.Initialize(Services);
            summarySupRecuit1.ProjectID = this.ProjectID;
            summarySupRecuit1.Process();


            waittingList1.Initialize(Services);
            waittingList1.ProjectID = this.ProjectID;
            waittingList1.Process();


            fwProfile1.Initialize(Services);
            fwProfile1.ProjectID = this.ProjectID;
            fwProfile1.Process();
        }

        private void TabCollection_Click(object sender, EventArgs e)
        {
            if (TabCollection.SelectedTabPage.Name == "TabSummaryQC")
            {
                summaryQC1.LoadQuota();
            }

            if (TabCollection.SelectedTabPage.Name == "TabSummaryInterview")
            {
                 summarySupInterview1.LoadQuota();             
            }

            if (TabCollection.SelectedTabPage.Name == "TabSummaryRecuit")
            {
                summarySupRecuit1.LoadQuota();


            }

            if (TabCollection.SelectedTabPage.Name == "TabValSummary")
            {

                summaryVal1.LoadQuota();


            }

            if (TabCollection.SelectedTabPage.Name == "TabWaitting")
            {
                waittingList1.LoadData();
            }
            if (TabCollection.SelectedTabPage.Name == "TabReport")
            {

                fwProfile1.LoadQuota();
            }
        }

    }
}
