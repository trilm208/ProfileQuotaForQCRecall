
using DataAccess;
using QA;
using System;
using System.Data;
using System.Windows.Forms;

namespace Shell
{
    public partial class frmMain : ClientForm
    {
        public Control ControlContainer
        {
            get { return panel1; }
        }

        //public string UserID { get; set; }
        //public string UserName { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        //private string Reload;

        public override void Process()
        {

            this.Text = QAFunction.ReadFromConfigXMlFile("ApplicationName");
            LoadMenu();
        }

        private void LoadMenu()
        {
            var query = DataQuery.Cached("Application", "ws_Menu_Get");
            var ds = Services.Execute(query);
            var table = ds.FirstTable();
            if (ds == null)
            {
                UI.ShowError(Services.LastError);
                return;
            }
            foreach (DataRow row in table.Rows)
            {
                var category = row["Category"] + "";

                var name = row["Name"] + "";
                var icon = row["Icon"] + "";
                var controlType = row["ControlType"] + "";

                //if (name.ToUpper() == "TestMenu4".ToUpper())
                //{
                //    int a = 1;
                //}

                if (Services.HasPermission(String.Format("{0}.{1}", category, name)))
                {
                    //category = Services.Localize(row["Category"] + "");
                    //category = row["Category"] + "";
                    if (category.IsEmpty())
                    {
                        category = row["Catelogy"].ToString();
                    }
                    //name = Services.Localize(row["Name"] + "");
                    name = row["Name"] + "";
                    name = (name == "" ? row["Name"].ToString() : name);
                    navBar.Add(category, name, icon, controlType);
                }
            }

      
        }

        private void LoadLastFacilityOfUser()
        {
            var query = DataQuery.Create("Security", "ws_UserLogin_Get", new { ActionType = 1 });

            var ds = Services.Execute(query);
            if (ds == null)
            {
                MessageBox.Show(Services.LastError);
                return;
            }
            var table = ds.FirstTable();

            if (table.Rows.Count > 0)
            {
                Services.SetInformation("FacID", table.FirstRow().Item("FacLastID"));
                Services.SetInformation("FacName", table.FirstRow().Item("FacLastName"));
            }
        }

        private void navBar_Navigate(object sender, EventArgs e)
        {
            Services.LoadControl(navBar.ActiveLink);
        }

      

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseApp(sender, e);
        }

        private void CloseApp(object sender,FormClosingEventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("Thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

           
           
            if (Result == DialogResult.OK)
            {
                e.Cancel = false;

                // Xóa Session khia user logout hoac tat phan mem.
                var query = DataQuery.Create("Security", "ws_Session_Delete");

                var ds = Services.Execute(query);
                if (ds == null)
                {
                    MessageBox.Show(Services.LastError);
                    return;
                }

                return;
            }
            else if (Result == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

    }
}