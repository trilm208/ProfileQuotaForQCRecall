using QA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shell.DataView
{
    public partial class frmEditOE : ClientForm
    {
        public frmEditOE()
        {
            InitializeComponent();
        }

        public override void Process()
        {
            base.Process();
        }
        public string AnswerText
        {
            set
            {
                txtOE.Text = value;
              
            }
        }
        public string QuestionCode
        {
            set
            {
                lblQuestionCode.Text = value;
            }
        }
        public string AnswerID { get; set; }
        public string ProjectID { get; set; }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UI.Confirm("Bạn có chắc chắn chỉnh sửa câu trả lời này không?"))
            {
                var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewGenericFormValues_UpdateOE", new
                {
                    AnswerID,
                    ProjectID,
                    QuestionID,
                    UserID=Services.GetInformation("UserID"),
                    QuestionCode=lblQuestionCode.Text.Trim(),
                    FieldValue=txtOE.Text.Trim().ToUpper(),
                    AnswerText=txtOE.Text.Trim().ToUpper()
                });
                var ds = Services.Execute(query);
                if (ds == null)
                {
                    UI.ShowError(Services.LastError);
                    return;
                }
                UI.InformationSaved();
                DialogResult = DialogResult.OK;
            }

        }



        public string QuestionID { get; set; }
    }
}
