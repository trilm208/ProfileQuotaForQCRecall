using QA;
using Shell.DataView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Shell
{
    public partial class frmViewData : ClientForm
    {
        public frmViewData()
        {
            InitializeComponent();
        }
        public override void Process()
        {
            base.Process();


            var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewGenericFormValues_ViewDataV2", new
            {
                AnswerID,
                ProjectID
            });
            query += DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewTime_Get", new
            {
                AnswerID,
                ProjectID
            });

            if (Services.GetInformation("tblBangCauHoi") == null)
            {
                query += DataAccess.DataQuery.Create("Docs", "ws_DOC_GenericFormQuestionAndroid_ViewDataV2", new
                {
                   
                    ProjectID
                });
            }
            //query += DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewImageRespontdents_Get", new
            //{
            //    AnswerID,
            //    ProjectID
            //});
         
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var ds = Services.Execute(query);
            if (ds == null)
            {
                UI.ShowError(Services.LastError);
                return;
            }
            watch.Stop();
            if (Services.GetInformation("tblBangCauHoi") == null)
            {
                Services.SetInformation("tblBangCauHoi", ds.LastTable());
            }
            var elapsedMs = watch.ElapsedMilliseconds;
            Debug.WriteLine("Get from server : " + watch.ElapsedMilliseconds);
            watch.Restart();
            //Process data
            gAnswer.DataSource = GetDataView(Services.GetInformation("tblBangCauHoi") as DataTable, ds.FirstTable());
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Debug.WriteLine("Convert : " + watch.ElapsedMilliseconds);
            
          
            imageRespondent1.Initialize(Services);
            imageRespondent1.ProjectID = this.ProjectID;
            imageRespondent1.AnswerID = this.AnswerID;
            //imageRespondent1.LoadImage(ds.Tables[2]);
            timeDuration1.Load(ds.Tables[1]);

        }

        private DataTable GetDataView(DataTable tblQuestion, DataTable tblData)
        {


            foreach (DataRow row in tblQuestion.Rows)
            {
                row["QuestionName"] = HtmlToPlainText(row.Item("QuestionNameHTMLText"));
                int QuestionTypeID = ConvertSafe.ToInt32(row.Item("QuestionTypeID"));
                if (QuestionTypeID == 1)
                {
                    //tim tat ca nhung cau tra loi
                    var values = tblData.Select(string.Format("QuestionCode='{0}'", row.Item("QuestionCode")));
                    if (values.Count() > 0)
                    {
                        //tim value da chon luc truoc.
                        string result = "";
                         bool IsLocked=false;
                        string valueSelect = tblData._FindValue("AnswerText", "FieldName", row.Item("QuestionCode"));
                        result = valueSelect;
                        //tim value khac
                        foreach (DataRow c_row in values)
                        {
                            if (c_row.Item("FieldName") != row.Item("QuestionCode"))
                            {
                                if (c_row.Item("AnswerText").IsNotEmpty())
                                {
                                    result += "[" + c_row.Item("AnswerText") + "]";
                                }
                            }

                            if (ConvertSafe.ToBoolean(c_row.Item("IsLocked")) == true)
                            {
                                IsLocked = true;
                            }
                        }
                        row["checked"] = IsLocked;
                        row["AnswerText"] = result;
                    }

                  
                   
                }
                if (QuestionTypeID == 2)
                {
                    var values = tblData.Select(string.Format("QuestionCode='{0}'", row.Item("QuestionCode")));
                    if (values.Count() > 0)
                    {
                        //tim value da chon luc truoc.
                        string result = "";
                        bool IsLocked = false;
                        var dt = row.Item("MultiChoice_Answer_AnswerList").JSONToDataTable();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var c_row = dt.Rows[i];
                            string var_name = c_row.Item("MultiChoice_View_Answer_AnswerCodes_VariableName");
                            string valuetext = tblData._FindValue("AnswerText", "FieldName", var_name);
                            if (valuetext.IsNotEmpty())
                            {
                                result += valuetext;
                                string valuetextOther = tblData._FindValue("AnswerText", "FieldName", row.Item("QuestionCode") + "_" + c_row.Item("MultiChoice_View_Answer_AnswerCodes_VariableName") + "_K");
                                if (valuetextOther.IsNotEmpty())
                                {
                                    result += "[" + valuetextOther + "]";
                                }
                                result += Environment.NewLine;
                            }
                           
                        }
                        foreach(var row_c in values)
                        {
                            if (ConvertSafe.ToBoolean(row_c.Item("IsLocked")) == true)
                            {
                                IsLocked = true;
                            }
                        }
                        row["checked"] = IsLocked;
                        row["AnswerText"] = result;
                    }
                }
                if (QuestionTypeID == 3)
                {
                    bool IsLocked = false;
                  

                    row["AnswerText"] = tblData._FindValue("AnswerText", "FieldName", row.Item("QuestionCode"));

                    var values = tblData.Select(string.Format("QuestionCode='{0}'", row.Item("QuestionCode")));
                    foreach (var row_c in values)
                    {
                        if (ConvertSafe.ToBoolean(row_c.Item("IsLocked")) == true)
                        {
                            IsLocked = true;
                        }
                    }
                    row["checked"] = IsLocked;

                }

                if (QuestionTypeID == 5)
                {

                }
                if (QuestionTypeID == 6)
                {

                }
                if (QuestionTypeID == 7)
                {
                    bool IsLocked = false;
                    row["AnswerText"] = tblData._FindValue("AnswerText", "FieldName", row.Item("QuestionCode"));
                  
                    var values = tblData.Select(string.Format("QuestionCode='{0}'", row.Item("QuestionCode")));
                    foreach (var row_c in values)
                    {
                        if (ConvertSafe.ToBoolean(row_c.Item("IsLocked")) == true)
                        {
                            IsLocked = true;
                        }
                    }
                 
                    row["checked"] = IsLocked;
                }

            }

            return tblQuestion;
        }
        string HtmlToPlainText(string html)
        {
            const string tagWhiteSpace = @"(>|$)(\W|\n|\r)+<";//matches one or more (white space or line breaks) between '>' and '<'
            const string stripFormatting = @"<[^>]*(>|$)";//match any character between '<' and '>', even when end tag is missing
            const string lineBreak = @"<(br|BR)\s{0,1}\/{0,1}>";//matches: <br>,<br/>,<br />,<BR>,<BR/>,<BR />
            var lineBreakRegex = new Regex(lineBreak, RegexOptions.Multiline);
            var stripFormattingRegex = new Regex(stripFormatting, RegexOptions.Multiline);
            var tagWhiteSpaceRegex = new Regex(tagWhiteSpace, RegexOptions.Multiline);

            var text = html;
            //Decode html specific characters
            text = System.Net.WebUtility.HtmlDecode(text);
            //Remove tag whitespace/line breaks
            text = tagWhiteSpaceRegex.Replace(text, "><");
            //Replace <br /> with line breaks
            text = lineBreakRegex.Replace(text, Environment.NewLine);
            //Strip formatting
            text = stripFormattingRegex.Replace(text, string.Empty);

            return text;
        }
        public string AnswerID { get; set; }

        public string ProjectID { get; set; }

        private void btnSupConfirm_Click(object sender, EventArgs e)
        {
            if (UI.Confirm("Xác nhận phiếu này đã được chấm bởi Sup"))
            {
                var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewTablet_UpdateSupervisorConfirmed", new
                {
                    AnswerID,
                    ProjectID,
                    CodeLock =(gAnswer.DataSource as DataTable).GetSplit("QuestionCode","~","checked='True'"),
                    UserID = Services.GetInformation("UserID")
                });
                var ds = Services.Execute(query);
                if (ds == null)
                {
                    UI.ShowError(Services.LastError);
                    return;
                }
                MessageBox.Show("Đã khóa nội dung bảng câu trả lời.Nếu có bất cứ thay đổi, vui lòng liên hệ DMS team");
                DialogResult = DialogResult.OK;
            }
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            var query = new DataAccess.RequestCollection();

            query += DataAccess.DataQuery.Create("Docs", "ws_DOC_Answers_UpdateRespondentStatus", new
            {
                AnswerID,
                RespondentStatus = "Ok"

            });
            var ds = Services.Execute(query);
            if (ds == null)
            {
                UI.ShowError(Services.LastError);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            var query = new DataAccess.RequestCollection();

            query += DataAccess.DataQuery.Create("Docs", "ws_DOC_Answers_UpdateRespondentStatus", new
            {
                AnswerID,
                RespondentStatus = "Extra"

            });
            var ds = Services.Execute(query);
            if (ds == null)
            {
                UI.ShowError(Services.LastError);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var query = new DataAccess.RequestCollection();

            query += DataAccess.DataQuery.Create("Docs", "ws_DOC_Answers_UpdateRespondentStatus", new
            {
                AnswerID,
                RespondentStatus = "Cancel"

            });
            var ds = Services.Execute(query);
            if (ds == null)
            {
                UI.ShowError(Services.LastError);
                return;
            }

            DialogResult = DialogResult.OK;
        }

     

      

        private void TabControls_Click(object sender, EventArgs e)
        {
            if (TabControls.SelectedTabPage.Name == "TabPic")
            {
                imageRespondent1.control_ReloadImage(null,null);
            }
        }

        private void gvAnswer_DoubleClick(object sender, EventArgs e)
        {
            var row = gvAnswer.GetDataRow(gvAnswer.FocusedRowHandle);
            if (row == null)
                return;
            if (row.Item("QuestionTypeID") == "3")
            {
             
                using (var frm = new frmEditOE())
                {
                    frm.Initialize(Services);
                    frm.AnswerID = AnswerID;
                    frm.ProjectID = ProjectID;
                    frm.Process(row);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewGenericFormValues_ViewDataV2", new
                        {
                            AnswerID,
                            ProjectID
                        });
                       
                        var ds = Services.Execute(query);
                        if (ds == null)
                        {
                            UI.ShowError(Services.LastError);
                            return;
                        }
                        //Process data

                        gAnswer.DataSource = GetDataView(Services.GetInformation("tblBangCauHoi") as DataTable, ds.FirstTable());
                        gvAnswer.SelectARowInGridView("QuestionCode", row.Item("QuestionCode"));
                    }


                }
            }

            if (row.Item("QuestionTypeID") == "1")
            {

                using (var frm = new frmEditSA())
                {
                    frm.Initialize(Services);
                    frm.AnswerID = AnswerID;
                    frm.ProjectID = ProjectID;
                 
                    frm.Process(row);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewGenericFormValues_ViewDataV2", new
                        {
                            AnswerID,
                            ProjectID
                        });

                        var ds = Services.Execute(query);
                        if (ds == null)
                        {
                            UI.ShowError(Services.LastError);
                            return;
                        }
                        //Process data

                        gAnswer.DataSource = GetDataView(Services.GetInformation("tblBangCauHoi") as DataTable, ds.FirstTable());
                        gvAnswer.SelectARowInGridView("QuestionCode", row.Item("QuestionCode"));
                    }


                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool state = true;
            for (int i = 0; i < gvAnswer.DataRowCount; i++)
            {
                var row = gvAnswer.GetDataRow(i);
                string tempCode = row.Item("QuestionCode");
                if (row.Item("QuestionCode").StartsWith("D"))
                {

                    string temp2 = tempCode.Replace(txtSearch.Text.Trim().ToUpper(), "");

                    if (row.Item("QuestionCode").StartsWith(txtSearch.Text.Trim().ToUpper()))
                    {
                        if (txtSearch.Text.Trim().ToUpper().Contains("A")
                          || txtSearch.Text.Trim().ToUpper().Contains("B"))
                        {
                            gvAnswer.SetRowCellValue(i, "checked", state);
                        }
                        else
                        {
                            if (!temp2.StartsWith("0") && !temp2.StartsWith("1")
                               && !temp2.StartsWith("2")
                               && !temp2.StartsWith("3")
                               && !temp2.StartsWith("4")
                               && !temp2.StartsWith("5")
                               && !temp2.StartsWith("6")
                               && !temp2.StartsWith("7")
                               && !temp2.StartsWith("8")
                               && !temp2.StartsWith("9"))
                            {
                                gvAnswer.SetRowCellValue(i, "checked", state);
                            }
                        }
                    }
                    else
                    {
                    }
                }
                else
                {
                    if (row.Item("QuestionCode").StartsWith(txtSearch.Text.Trim().ToUpper()))
                        gvAnswer.SetRowCellValue(i, "checked", state);
                }

            }
            MessageBox.Show("Đã check xong");
        }

        private void btnUncheck_Click(object sender, EventArgs e)
        {
            bool state = false;
            for (int i = 0; i < gvAnswer.DataRowCount; i++)
            {
                var row = gvAnswer.GetDataRow(i);
                string tempCode = row.Item("QuestionCode");
                if (row.Item("QuestionCode").StartsWith("D"))
                {

                    string temp2 = tempCode.Replace(txtSearch.Text.Trim().ToUpper(), "");

                    if (row.Item("QuestionCode").StartsWith(txtSearch.Text.Trim().ToUpper()))
                    {
                        if (txtSearch.Text.Trim().ToUpper().Contains("A")
                          || txtSearch.Text.Trim().ToUpper().Contains("B"))
                        {
                            gvAnswer.SetRowCellValue(i, "checked", state);
                        }
                        else
                        {
                            if (!temp2.StartsWith("0") && !temp2.StartsWith("1")
                               && !temp2.StartsWith("2")
                               && !temp2.StartsWith("3")
                               && !temp2.StartsWith("4")
                               && !temp2.StartsWith("5")
                               && !temp2.StartsWith("6")
                               && !temp2.StartsWith("7")
                               && !temp2.StartsWith("8")
                               && !temp2.StartsWith("9"))
                            {
                                gvAnswer.SetRowCellValue(i, "checked", state);
                            }
                        }
                    }
                    else
                    {
                    }
                }
                else
                {
                    if (row.Item("QuestionCode").StartsWith(txtSearch.Text.Trim().ToUpper()))
                        gvAnswer.SetRowCellValue(i, "checked", state);
                }

            }
          
            MessageBox.Show("Đã un-check xong");
        }
    }
}
