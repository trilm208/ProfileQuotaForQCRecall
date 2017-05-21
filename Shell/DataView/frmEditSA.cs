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
    public partial class frmEditSA : ClientForm
    {
        public frmEditSA()
        {
            InitializeComponent();
        }

        public string AnswerText
        {
            set
            {
               

            }
        }
        public string QuestionName
        {
            set
            {
                lblQuestionCode.Text = value;
            }
            get
            {
               return lblQuestionCode.Text;
            }
        }
        public string QuestionCode { get; set; }
        public string SingleChoice_Answer_AnswerList { get; set; }
        public override void Process()
        {
          
            base.Process();
            var dataValue = SingleChoice_Answer_AnswerList.JSONToDataTable();
            int count = dataValue.Rows.Count;

            int height_unit = (int)((customFlowLayoutPanel1.Height - 20) / count);

            foreach (DataRow row in dataValue.Rows)
            {
                GenSingleRadioButtonUnit _buttonUnit = new GenSingleRadioButtonUnit();
                //PanelControl panel = new PanelControl();

               
                bool _IsShow = true;
               
                _buttonUnit._SingleChoice_View_Answer_AnswerCodes_OtherSpecify_InType = row.Item("SingleChoice_View_Answer_AnswerCodes_OtherSpecify_InType");
                _buttonUnit._SingleChoice_View_Answer_AnswerCodes_OtherSpecify_VariableName = row.Item("SingleChoice_View_Answer_AnswerCodes_OtherSpecify_VariableName");
                _buttonUnit._SingleChoice_View_Answer_AnswerCodes_OtherSpecify = row.Item("SingleChoice_View_Answer_AnswerCodes_OtherSpecify");
                _buttonUnit._SingleChoice_View_Answer_AnswerCodes_CheckedCode = row.Item("SingleChoice_View_Answer_AnswerCodes_CheckedCode");
                _buttonUnit._SingleChoice_View_Answer_AnswerCodes_UnCheckedCode = row.Item("SingleChoice_View_Answer_AnswerCodes_UnCheckedCode");
                _buttonUnit._SingleChoice_View_Answer_AnswerCodes_VariableName = row.Item("SingleChoice_View_Answer_AnswerCodes_VariableName");
                _buttonUnit._SingleChoice_View_Answer_AnswerCoding = row.Item("SingleChoice_View_Answer_AnswerCoding");
                _buttonUnit._SingleChoice_View_Answer_AnswerIndex = row.Item("SingleChoice_View_Answer_AnswerCoding");
                _buttonUnit._SingleChoice_View_Answer_AnswerText = row.Item("SingleChoice_View_Answer_AnswerText");
                _buttonUnit.Width = customFlowLayoutPanel1.Width-10;
                _buttonUnit.CheckedChange += _buttonUnit_CheckedChange;
                _buttonUnit.Visible = _IsShow;

                _buttonUnit.Initialize(Services);
                _buttonUnit.Process();
                _buttonUnit.Width = customFlowLayoutPanel1.Width/2 - 10;
                if (_buttonUnit.Visible == false)
                {
                    _buttonUnit.Checked = false;
                }
                else
                {
                    //var oldValue = _dtResultValue._FindValue("FieldValue", "FieldName", QuestionCode);
                    //if (oldValue == row.Item("SingleChoice_View_Answer_AnswerCoding"))
                    //{
                    //    _buttonUnit.Checked = true;
                    //}
                    //else
                    //{
                    //    _buttonUnit.Checked = false;
                    //}

                    //if (_buttonUnit._textBox != null)
                    //{
                    //    _buttonUnit._textBox.Text = _dtResultValue._FindValue("FieldValue", "FieldName", row.Item("SingleChoice_View_Answer_AnswerCodes_OtherSpecify_VariableName"));
                    //}

                }
                //_buttonUnit_CheckedChange(null, null);
                customFlowLayoutPanel1.Controls.Add(_buttonUnit);

            }






        }
        private void _buttonUnit_CheckedChange(object sender, EventArgs e)
        {
            if ((sender as GenSingleRadioButtonUnit).Checked == true)
            {

                foreach (Control ctr in customFlowLayoutPanel1.Controls)
                {
                    if (ctr.GetType() == typeof(GenSingleRadioButtonUnit))
                    {
                        if ((sender as GenSingleRadioButtonUnit)._SingleChoice_View_Answer_AnswerIndex != (ctr as GenSingleRadioButtonUnit)._SingleChoice_View_Answer_AnswerIndex)
                        {
                            (ctr as GenSingleRadioButtonUnit).UnChecked();
                        }
                    }
                }
            }
        }

        public string AnswerID { get; set; }

        public string ProjectID { get; set; }

        public int NumberOfColumns { get; set; }
        public DataTable dataValue { get; set; }
        public bool IsRequired { get; set; }
        public DataTable dtResultValue
        {
            get
            {
                List<DataRow> List_OtherSpecify = new List<DataRow>();
                var table = new DataTable();
                table.Columns.Add("FieldName");
                table.Columns.Add("FieldValue");
                table.Columns.Add("Answer");

                var row = table.NewRow();

                row["FieldName"] = this.QuestionCode;

                string value = "";
                string answer = "";
                foreach (Control ctr in customFlowLayoutPanel1.Controls)
                {
                    if (ctr.GetType() == typeof(GenSingleRadioButtonUnit))
                    {
                        if ((ctr as GenSingleRadioButtonUnit).Checked == true)
                        {
                            value = (ctr as GenSingleRadioButtonUnit)._SingleChoice_View_Answer_AnswerCoding;
                            answer = (ctr as GenSingleRadioButtonUnit)._SingleChoice_View_Answer_AnswerText;
                            if (ConvertSafe.ToBoolean((ctr as GenSingleRadioButtonUnit)._SingleChoice_View_Answer_AnswerCodes_OtherSpecify) == true)
                            {
                                DataRow row_OtherSpecify = table.NewRow();
                                row_OtherSpecify["FieldName"] = (ctr as GenSingleRadioButtonUnit)._SingleChoice_View_Answer_AnswerCodes_OtherSpecify_VariableName;
                                if ((ctr as GenSingleRadioButtonUnit).OtherSpecifyFieldValue.IsEmpty())
                                {
                                    UI.ShowError("Vui lòng nhập Ghi rõ");
                                    (ctr as GenSingleRadioButtonUnit)._textBox.Focus();
                                    return null;
                                }
                                else
                                {
                                    row_OtherSpecify["FieldValue"] = (ctr as GenSingleRadioButtonUnit).OtherSpecifyFieldValue;
                                    row_OtherSpecify["Answer"] = (ctr as GenSingleRadioButtonUnit)._textBox.Text.Trim().ToUpper();
                                }
                                List_OtherSpecify.Add(row_OtherSpecify);
                            }
                        }
                        else
                        {
                            if (ConvertSafe.ToBoolean((ctr as GenSingleRadioButtonUnit)._SingleChoice_View_Answer_AnswerCodes_OtherSpecify) == true)
                            {
                                DataRow row_OtherSpecify = table.NewRow();

                                row_OtherSpecify["FieldName"] = (ctr as GenSingleRadioButtonUnit)._SingleChoice_View_Answer_AnswerCodes_OtherSpecify_VariableName;
                                row_OtherSpecify["FieldValue"] = "";
                                row_OtherSpecify["Answer"] = "";
                                List_OtherSpecify.Add(row_OtherSpecify);

                            }
                        }
                    }
                    else
                    {

                    }
                }
                row["FieldValue"] = value;
                row["Answer"] = answer;
                if (IsRequired == true)
                {
                    if (value.IsEmpty())
                    {
                        UI.ShowError("Vui lòng chọn một giá trị");
                        return null;
                    }
                }
                else
                {
                }
                table.Rows.Add(row);
                foreach (DataRow row_OtherSpecify in List_OtherSpecify)
                {
                    table.Rows.Add(row_OtherSpecify);
                }

                table.AcceptChanges();
                return table;
            }
        }
        internal bool CheckValidation()
        {
            if (dtResultValue == null)
            {
                return false;
            }
            return true;
        }
        internal void SelectValue(int p)
        {
            //kiem tra xem co textbox nao dang enable k???
            if (CheckExistEnable() == true)
            {
                return;
            }
            foreach (Control ctr in customFlowLayoutPanel1.Controls)
            {
                if (ctr.GetType() == typeof(GenSingleRadioButtonUnit))
                {

                    if (((GenSingleRadioButtonUnit)ctr)._SingleChoice_View_Answer_AnswerCoding == p.ToString() && ((GenSingleRadioButtonUnit)ctr).Visible == true && ConvertSafe.ToBoolean(((GenSingleRadioButtonUnit)ctr)._SingleChoice_View_Answer_AnswerCodes_OtherSpecify) == false)
                    {
                        (ctr as GenSingleRadioButtonUnit).Checked = true;
                        //this.RaiseEvent(KeyF1Press);
                    }
                    else
                    {
                        (ctr as GenSingleRadioButtonUnit).Checked = true;
                    }
                }


            }
        }

        internal bool CheckExistEnable()
        {
            foreach (Control ctr in customFlowLayoutPanel1.Controls)
            {
                if (ctr.GetType() == typeof(GenSingleRadioButtonUnit))
                {

                    if (((GenSingleRadioButtonUnit)ctr)._textBox != null && ((GenSingleRadioButtonUnit)ctr)._textBox.Enabled == true)
                    {
                        return true;
                    }
                }


            }
            return false;

        }

        internal void SelectStringValue(string p)
        {
            if (CheckExistEnable() == true)
            {
                return;
            }
            List<String> listAnswerCode = new List<string>();
            foreach (Control ctr in customFlowLayoutPanel1.Controls)
            {
                if (ctr.GetType() == typeof(GenSingleRadioButtonUnit) && ConvertSafe.ToBoolean(((GenSingleRadioButtonUnit)ctr)._SingleChoice_View_Answer_AnswerCodes_OtherSpecify) == false)
                {

                    listAnswerCode.Add(((GenSingleRadioButtonUnit)ctr)._SingleChoice_View_Answer_AnswerCoding);
                }
            }

            //lay ki tu cuoi cùng



            int maxCountLength = findMaxCountLengthAnswerCode(listAnswerCode);

            if (p.Length < maxCountLength)
            {
                return;
            }

            string lastAnswer = p.Substring(p.Length - maxCountLength, maxCountLength);
            foreach (Control ctr in customFlowLayoutPanel1.Controls)
            {
                if (ctr.GetType() == typeof(GenSingleRadioButtonUnit))
                {
                    string covertAnswerCode = ((GenSingleRadioButtonUnit)ctr)._SingleChoice_View_Answer_AnswerCoding;

                    while (covertAnswerCode.Length < maxCountLength)
                    {
                        covertAnswerCode = "0" + covertAnswerCode;
                    }

                    if (covertAnswerCode == lastAnswer && ((GenSingleRadioButtonUnit)ctr).Visible == true && ConvertSafe.ToBoolean(((GenSingleRadioButtonUnit)ctr)._SingleChoice_View_Answer_AnswerCodes_OtherSpecify) == false)
                    {
                        (ctr as GenSingleRadioButtonUnit).Checked = true;
                        //this.RaiseEvent(KeyF1Press);
                    }
                    else
                    {
                        (ctr as GenSingleRadioButtonUnit).Checked = false;
                    }

                 
                }


            }
        }

        private int findMaxCountLengthAnswerCode(List<string> listAnswerCode)
        {
            int resultCountLength = 0;
            foreach (string s in listAnswerCode)
            {
                if (s.Length > resultCountLength)
                    resultCountLength = s.Length;
            }

            return resultCountLength;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtResultValue == null)
                return;
            
            

            if (UI.Confirm("Bạn có chắc chắn chỉnh sửa câu trả lời này không?"))
            {
                foreach (DataRow row in dtResultValue.Rows)
                {
                    var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewGenericFormValues_UpdateSA", new
                    {
                        AnswerID,
                        ProjectID,
                        QuestionID,
                        UserID = Services.GetInformation("UserID"),
                        FieldName = row.Item("FieldName"),// lblQuestionCode.Text.Trim(),
                        FieldValue = row.Item("FieldValue"),
                        AnswerText = row.Item("Answer")
                    });
                    var ds = Services.Execute(query);
                    if (ds == null)
                    {
                        UI.ShowError(Services.LastError);
                        return;
                    }
                }
                UI.InformationSaved();
                DialogResult = DialogResult.OK;
            }
        
        }

        public string QuestionID { get; set; }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (UI.Confirm("Bạn có chắc chắn chỉnh sửa câu trả lời này không?"))
            {
                foreach (DataRow row in dtResultValue.Rows)
                {
                    var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewGenericFormValues_UpdateSA", new
                    {
                        AnswerID,
                        ProjectID,
                        QuestionID,
                        UserID = Services.GetInformation("UserID"),
                        FieldName = row.Item("FieldName"),// lblQuestionCode.Text.Trim(),
                        FieldValue = "",
                        AnswerText = ""
                    });
                    var ds = Services.Execute(query);
                    if (ds == null)
                    {
                        UI.ShowError(Services.LastError);
                        return;
                    }
                }
                UI.InformationSaved();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
