using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QA;
using DevExpress.XtraEditors;

namespace Shell.DataView
{
    public partial class GenSingleRadioButtonUnit : ClientControl
    {
        public GenSingleRadioButtonUnit()
        {
            InitializeComponent();
        }
        public event EventHandler CheckedChange;

    
        public override void Process()
        {
            base.Process();

            _radioButton = new RadioButton();
            _radioButton.Text = _SingleChoice_View_Answer_AnswerText;
            _radioButton.AutoSize = true;
            _radioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _radioButton.Location = new System.Drawing.Point(3, 3);
            _radioButton.UseVisualStyleBackColor = true;

            _radioButton.CheckedChanged += _radioButton_CheckedChanged;
            customFlowLayoutPanel1.Controls.Add(_radioButton);

            if (ConvertSafe.ToBoolean(_SingleChoice_View_Answer_AnswerCodes_OtherSpecify) == true)
            {
                _radioButton.Width = 350;
                _textBox = new TextEdit();
                _textBox.Width = customFlowLayoutPanel1.Width - _radioButton.Width - 150;
                _textBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                customFlowLayoutPanel1.Controls.Add(_textBox);
            }

            _radioButton_CheckedChanged(null, null);
            customFlowLayoutPanel1_Resize(null, null);
        }

        private void _radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (_radioButton.Checked == true)
            {
                _radioButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                _radioButton.ForeColor = System.Drawing.Color.Red;

                if (_textBox != null)
                {
                    _textBox.Enabled = true;
                    _textBox.Focus();
                }

                this.RaiseEvent(CheckedChange);
            }
            else
            {
                _radioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                _radioButton.ForeColor = System.Drawing.Color.Black;
                if (_textBox != null)
                {
                    _textBox.Enabled = false;
                }

            }
        }

        private void customFlowLayoutPanel1_Resize(object sender, EventArgs e)
        {
        }

        public string _SingleChoice_View_Answer_AnswerCodes_OtherSpecify_InType { get; set; }

        public string _SingleChoice_View_Answer_AnswerCodes_OtherSpecify_VariableName { get; set; }

        public string _SingleChoice_View_Answer_AnswerCodes_OtherSpecify { get; set; }

        public string _SingleChoice_View_Answer_AnswerCodes_CheckedCode { get; set; }

        public string _SingleChoice_View_Answer_AnswerCodes_UnCheckedCode { get; set; }

        public string _SingleChoice_View_Answer_AnswerCodes_VariableName { get; set; }

        public string _SingleChoice_View_Answer_AnswerCoding { get; set; }

        public string _SingleChoice_View_Answer_AnswerIndex { get; set; }

        public string _SingleChoice_View_Answer_AnswerText { get; set; }

        internal void UnChecked()
        {
            _radioButton.Checked = false;
            _radioButton_CheckedChanged(null, null);
        }

        public RadioButton _radioButton { get; set; }

        public bool Checked
        {
            get
            {
                if (_radioButton == null || _radioButton.Checked == null)
                    return false;
                return _radioButton.Checked;
            }
            set
            {
                _radioButton.Checked = value;
                _radioButton_CheckedChanged(null, null);
            }
        }

        public TextEdit _textBox { get; set; }

        public string OtherSpecifyFieldValue
        {
            set
            {
                if (_textBox != null)
                {
                    _textBox.Text = value;
                }
            }
            get
            {
                if (_textBox != null && _textBox.Enabled == true)
                {
                    return _textBox.Text.Trim();
                }
                else
                {
                    return "";
                }
            }
        }




    }
}
