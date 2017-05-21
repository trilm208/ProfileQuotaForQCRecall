using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Shell.Core;
using QA;


namespace Shell
{
    public partial class RespondentProfileInformation : ClientControl
    {
  
        public string ProjectID { get;  set; }

        private DataTable tblStreet;
        private DataTable tblQuotaControl;
        private DataTable dataHanhChanh;
      
        public RespondentProfileInformation()
        {
            InitializeComponent();

            DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lookUpProperties2;
            lookUpProperties2 = txtDistrict.Properties;
            lookUpProperties2.ImmediatePopup = true;

            DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lookUpProperties3;
            lookUpProperties3 = txtWard.Properties;
            lookUpProperties3.ImmediatePopup = true;

            
            DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lookUpProperties5;
            lookUpProperties5 = txtRecruit.Properties;
            lookUpProperties5.ImmediatePopup = true;


        }

        public string AnswerID { get; set; }
        public string ProjectNo { get; internal set; }

        public override void Process()
        {
            base.Process();
            

            var query = DataAccess.DataQuery.Create("KadenceDB", "ws_L_FaceListID_List");

            query += DataAccess.DataQuery.Create("KadenceDB", "ws_MDM_Street_ListAll");

            query += DataAccess.DataQuery.Create("Docs", "ws_DOC_QuotaControl_Get", new
            {
                ProjectID
            });

             query += DataAccess.DataQuery.Create("KadenceDB", "ws_L_WardDistrictCity_List");
           
            query += DataAccess.DataQuery.Create("KadenceDB", "ws_L_FaceListID_List");

            query += DataAccess.DataQuery.Create("KadenceDB", "ws_HR_PTEProject_List", new
            {
                ProjectID,
                IsFWRecuit=1,
                IsFWInterview=0
            });

            var ds = Services.Execute(query);
            if (ds == null)
            {
                UI.ShowError(Services.LastError);
                return;
            }
            
         
            tblStreet = ds.SecondTable();
            tblQuotaControl = ds.Tables[2];
            dataHanhChanh = ds.Tables[3];      
           
            txtRecruit.Properties.DataSource = ds.Tables[5];
            createQuotaInterface();

            //if (IsNeedPlaceProduct == false)
            //{
            //    datePlaceProduct.Visible = label8.Visible = false;
            //    rStatus.Height = 89;
            //}
            //else
            //{
            //    datePlaceProduct.Visible = label8.Visible = true;
            //    rStatus.Height = 50;
               

            //}

        }

        private void createQuotaInterface()
        {
            foreach (DataRow row in tblQuotaControl.Rows)
            {
                var c_quota = new QuotaGroup(row);
                c_quota.Height = flowQuota.Height - 7;
                c_quota.Width = c_quota.Height-30;
                flowQuota.Controls.Add(c_quota);
            }
        }
        private string _pathImage = "";
     
      

        void WriteLog(string logMessage)
        {

            LogWriter.LogWrite(logMessage);
            if (String.IsNullOrEmpty(logMessage) || logMessage == "\n")
            {

               
            }
            else
            {
                string timeStr = DateTime.Now.ToString("HH:mm:ss");
                string messaage = "[" + timeStr + "]: " + logMessage + Environment.NewLine;
                
                LogWriter.LogWrite(messaage);
            }


        }

      

        private void btnRD_Click(object sender, EventArgs e)
        {
            var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_GenericFormValues_SearchMultiRespondentCurrentProject", new
            {
                ProjectID,
                STT = "1@",               
                Name = txtName.Text.Trim().ToUpper().RemoveSign4VietnameseString().Replace("  ", String.Empty) + "@",
                Telephone = txtTelephone.Text.Trim().ToUpper().RemoveSign4VietnameseString().Replace("  ", String.Empty) + "@",
                Address = txtAddress.Text.Trim().ToUpper().RemoveSign4VietnameseString().Replace("  ", String.Empty) + "@",
                Street = txtStreet.Text.Trim().ToUpper().RemoveSign4VietnameseString().Replace("  ", String.Empty) + "@",
                MonthCheck = txtSoThang.Text.Trim(),
                ProjectType = "1@2"
            });
            var ds = Services.Execute(query);
            if (ds == null)
            {
                UI.ShowError(Services.LastError);
                Cursor.Current = Cursors.Default;
                return;
            }

            gICMA.Populate(ds.FirstTable());

            if (ds.FirstTable().Rows.Count == 0)
            {
                MessageBox.Show("Đã kiểm tra xong ICMA Data Detection: không phát hiện trùng data");
                return;
            }
            else
            {
                MessageBox.Show(String.Format("Đã kiểm tra xong ICMA Data Detection: phát hiện {0}", ds.FirstTable().Rows.Count));
                return;
            }
        }

        private void txtRespondentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtSearchID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                // binding data
                var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_Answers_FWSearchByGreenID", new
                {
                    ProjectID,

                    GreenID = txtSearchID.Text.Trim(),
                    UserID = Services.GetInformation("UserID")
                });

               

                var ds = Services.Execute(query);
                if (ds == null)
                {
                    ClearOldData();
                    UI.ShowError(Services.LastError);
                    return;
                }
                if (ds.FirstTable().Rows.Count == 0)
                {
                    UI.ShowError("Không tìm thấy dữ liệu mã đáp viên này");
                  
                    ClearOldData();
                    return;
                }
                AnswerID = ds.FirstRow().Item("AnswerID");

                //map data
                txtRespondentNo.Text =txtGreenID.Text= ds.FirstRow().Item("GreenID");
                txtName.Text= ds.FirstRow().Item("RespondentFullName");
                dateDOB.Text = ds.FirstRow().Item("RespondentYoB");
                txtStreet.Text= ds.FirstRow().Item("RespondentStreet");
                txtAddress.Text= ds.FirstRow().Item("RespondentAddressLandmark");
                txtTelephone.Text= ds.FirstRow().Item("RespondentTelephone");
                rGender.EditValue = ds.FirstRow().Item("RespondentGender");
                rCity.EditValue= ds.FirstRow().Item("RespondentCity");
                txtDistrict.EditValue= ds.FirstRow().Item("RespondentDistrict");
                txtWard.EditValue= ds.FirstRow().Item("RespondentWard"); 
                rStatus.EditValue= ds.FirstRow().Item("RespondentStatus");
                txtRecruit.EditValue = ds.FirstRow().Item("RecruitCode");
                txtEmail.Text = ds.FirstRow().Item("EmailAddress");
             
                btnSave.Enabled = btnRD.Enabled = true;

                #region  MapDataQuota

                foreach(var control in flowQuota.Controls)
                {
                    if(control.GetType()==typeof(QuotaGroup))
                    {
                        string value = ds.SecondTable()._FindValue("FieldValue", "FieldName", ((QuotaGroup)control).QuotaFieldName);
                        ((QuotaGroup)control).QuotaFieldValue = value;
                    }
                }


                #endregion
                e.Handled = true;
            }
        }

        private void ClearOldData()
        {
            _pathImage = "";
            AnswerID = "";

          txtGreenID.Text=  txtRespondentNo.Text = txtName.Text = dateDOB.Text = txtAddress.Text = txtTelephone.Text = txtStreet.Text = txtEmail.Text ="" ;
            rCity.EditValue = rGender.EditValue = txtDistrict.EditValue = txtWard.EditValue = "";
            rStatus.EditValue = "";
            txtRecruit.EditValue="";
            btnSave.Enabled =  btnRD.Enabled = false;
            txtSearchID.Text = string.Empty;

            foreach (var control in flowQuota.Controls)
            {
                if (control.GetType() == typeof(QuotaGroup))
                {
                    ((QuotaGroup)control).QuotaFieldValue = "";
                }
            }
            gICMA.DataSource = null;

         
            txtSearchID.Focus();

        }

        private void rCity_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtDistrict.Properties.DataSource = dataHanhChanh.Select(string.Format("City='{0}'", rCity.EditValue.ToString())).CopyToDataTable().Distinct("District");
                txtDistrict.EditValue = null;
            }
            catch
            {

            }
            FindFaceListID();
        }

        private string FindFaceListID()
        {
            
            if (rGender.EditValue != null && rCity.EditValue != null && dateDOB.Text.IsNotEmpty())
            {
                string find_value = "";

                if (rCity.EditValue.ToString() == "HỒ CHÍ MINH")
                    find_value += "hcm";
                if (rCity.EditValue.ToString() == "HÀ NỘI")
                    find_value += "hn";

                if (rGender.EditValue.ToString() == "Nam")
                    find_value += "_nam";
                if (rGender.EditValue.ToString() == "Nữ")
                    find_value += "_nu";

                int currentyear = DateTime.Now.Year;

                string currentmonth = DateTime.Now.Month.ToString();

                if (currentmonth.Length < 2)
                    currentmonth = "0" + currentmonth;

                int namsinh = 0;
                if (int.TryParse(dateDOB.Text.ToString(), out namsinh))
                {
                    if (namsinh == 0)
                    {
                        return "";
                     
                    }
                    if (namsinh > currentyear)
                    {
                        return "";
                        
                    }
                    if (currentyear - namsinh >= 18)
                    {
                        find_value += "_nguoilon";
                    }
                    else
                    {
                        find_value += "_treem";
                    }
                }
                find_value += "_" + currentmonth + currentyear.ToString();
                return find_value;
            }
            else
            {
                return "";
            }
        }

        private void txtDistrict_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDistrict.EditValue == null || txtDistrict.Text.IsEmpty())
                {
                    txtWard.Properties.DataSource = dataHanhChanh.Select(string.Format("City='{0}'", rCity.EditValue.ToString())).CopyToDataTable().Distinct("Ward");
                }

                else
                {
                    txtWard.Properties.DataSource = dataHanhChanh.Select(string.Format("City='{0}' AND District='{1}'", rCity.EditValue.ToString(), (txtDistrict.EditValue == null || txtDistrict.EditValue.ToString().IsEmpty()) ? "" : txtDistrict.EditValue.ToString())).CopyToDataTable().Distinct("Ward");

                }
                txtWard.EditValue = null;
            }
            catch
            {

            }
        }

        private void txtDistrict_Popup(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated)
            {
                return;
            }
            FilterLookupDistrict(sender);
        }

        private void FilterLookupDistrict(object sender)
        {
            DevExpress.XtraEditors.GridLookUpEdit edit = sender as DevExpress.XtraEditors.GridLookUpEdit;
            DevExpress.XtraGrid.Views.Grid.GridView gridView = edit.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
            System.Reflection.FieldInfo fi = gridView.GetType().GetField("extraFilter", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            //Text = edit.AutoSearchText;
            DevExpress.Data.Filtering.BinaryOperator op1 = new DevExpress.Data.Filtering.BinaryOperator("District", "%" + edit.AutoSearchText + "%", DevExpress.Data.Filtering.BinaryOperatorType.Like);

            string filterCondition = new DevExpress.Data.Filtering.GroupOperator(DevExpress.Data.Filtering.GroupOperatorType.Or, new DevExpress.Data.Filtering.CriteriaOperator[] { op1 }).ToString();
            fi.SetValue(gridView, filterCondition);

            System.Reflection.MethodInfo mi = gridView.GetType().GetMethod("ApplyColumnsFilterEx", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            mi.Invoke(gridView, null);
        }

        private void txtDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtWard.Focus();
                // SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

      
       
        private void txtDistrict_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!this.IsHandleCreated)
            {
                return;
            }
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                FilterLookupDistrict(sender);
            }));
        }

        private void txtWard_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtWard_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!this.IsHandleCreated)
            {
                return;
            }
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                FilterLookupWard(sender);
            }));
        }

        private void txtWard_Popup(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated)
            {
                return;
            }

            FilterLookupWard(sender);
        }
        private void FilterLookupWard(object sender)
        {
            DevExpress.XtraEditors.GridLookUpEdit edit = sender as DevExpress.XtraEditors.GridLookUpEdit;
            DevExpress.XtraGrid.Views.Grid.GridView gridView = edit.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
            System.Reflection.FieldInfo fi = gridView.GetType().GetField("extraFilter", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            //Text = edit.AutoSearchText;
            DevExpress.Data.Filtering.BinaryOperator op1 = new DevExpress.Data.Filtering.BinaryOperator("Ward", "%" + edit.AutoSearchText + "%", DevExpress.Data.Filtering.BinaryOperatorType.Like);

            string filterCondition = new DevExpress.Data.Filtering.GroupOperator(DevExpress.Data.Filtering.GroupOperatorType.Or, new DevExpress.Data.Filtering.CriteriaOperator[] { op1 }).ToString();
            fi.SetValue(gridView, filterCondition);

            System.Reflection.MethodInfo mi = gridView.GetType().GetMethod("ApplyColumnsFilterEx", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            mi.Invoke(gridView, null);
        }
        private void txtWard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtStreet.Focus();
                // SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

        private void rGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

        private void dateDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

        private void rCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }

        public bool IsNeedPlaceProduct = false;

        private void rQCStatus_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private  void btnSave_Click(object sender, EventArgs e)
        {
            //save
            try
            {
                var query = new DataAccess.RequestCollection();

                if (CheckValidateInput() == false)
                    return;

                query += DataAccess.DataQuery.Create("Docs", "ws_DOC_Answers_SupReUpdate", new
                {
                    AnswerID,   
                    GreenID=txtGreenID.Text.Trim(),
                    ProjectID,
                    RespondentFullName = txtName.Text.Trim().ToUpper(),
                    RespondentAddressLandmark = txtAddress.Text.Trim().ToUpper(),
                    RespondentStreet = txtStreet.Text.Trim().ToUpper(),
                    RespondentWard = (txtWard.EditValue == null || txtWard.EditValue.ToString().IsEmpty()) ? "" : txtWard.Text.ToString().Trim(),
                    RespondentDistrict = (txtDistrict.EditValue == null || txtDistrict.EditValue.ToString().IsEmpty()) ? "" : txtDistrict.Text.ToString(),
                    RespondentCity = rCity.EditValue.ToString(),
                    RespondentTelephone = txtTelephone.Text.Trim(),
                    RespondentGender = rGender.EditValue == null ? "" : rGender.EditValue.ToString(),
                    RespondentStatus=rStatus.EditValue.ToString(),
                    RespondentYoB = dateDOB.Text.Trim(),
                    RecruitCode = txtRecruit.EditValue.ToString(),
                    EmailAddress=txtEmail.Text.Trim(),
                    UserID = Services.GetInformation("UserID")              
                });

                foreach (Control ctr in flowQuota.Controls)
                {
                    if (ctr.GetType() == typeof(QuotaGroup))
                    {                    
                        query += DataAccess.DataQuery.Create("Docs", "ws_DOC_QuotaControlValues_Save", new
                        {
                            AnswerID,
                            ProjectID,
                            FieldName = (ctr as QuotaGroup).QuotaFieldName,
                            FieldValue = (ctr as QuotaGroup).QuotaFieldValue,
                            UserID = Services.GetInformation("UserID")
                        });
                    }
                }
                var ds = Services.Execute(query);
                if (ds == null)
                {
                    WriteLog(Services.LastError);
                    MessageBox.Show(Services.LastError);
                    return;
                }
                WriteLog(String.Format("Đã lưu thành công thông tin của đáp viên {0} {1}", txtRespondentNo.Text,AnswerID));
               
                UI.InformationSaved();
                ClearOldData();
            }

            catch (Exception ex)
            {
                WriteLog(string.Format(ex.Message));
                UI.ShowError(ex.Message);
                return;
            }
        }

        private bool CheckValidateInput()
        {

            if (txtName.Text.IsEmpty())
            {
                UI.ShowError("Vui lòng nhập Họ và tên");
                txtName.Focus();
                return false;

            }
            if (dateDOB.Text.IsEmpty())
            {
                UI.ShowError("Vui lòng nhập năm sinh");
                dateDOB.Focus();
                return false;
            }
            if (txtStreet.Text.IsEmpty())
            {
                UI.ShowError("Vui lòng nhập tên đường");
                txtStreet.Focus();
                return false;
            }
            if (txtAddress.Text.IsEmpty())
            {
                UI.ShowError("Vui lòng nhập địa chỉ");
                txtAddress.Focus();
                return false;
            }
            
            if (txtTelephone.Text.IsEmpty())
            {
                UI.ShowError("Vui lòng nhập điện thoại");
                txtTelephone.Focus();
                return false;
            }
            
            if (rGender.EditValue == null || rGender.EditValue.ToString().IsEmpty())
            {
                UI.ShowError("Vui lòng chọn giới tính");
                rGender.Focus();
                return false;
            }

            if (rCity.EditValue == null || rCity.EditValue.ToString().IsEmpty())
            {
                UI.ShowError("Vui lòng thành phố");
                rCity.Focus();
                return false;
            }

            if (txtDistrict.EditValue == null || txtDistrict.EditValue.ToString().IsEmpty())
            {
                UI.ShowError("Vui lòng quận");
                txtDistrict.Focus();
                return false;
            }

            if (txtWard.EditValue == null || txtWard.EditValue.ToString().IsEmpty())
            {
                UI.ShowError("Vui lòng nhập phường");
                txtWard.Focus();
                return false;
            }

            if (txtRecruit.EditValue == null || txtRecruit.EditValue.ToString().IsEmpty())
            {
                UI.ShowError("Vui lòng nhập PVV");
                txtRecruit.Focus();
                return false;
            }

            foreach (Control ctr in flowQuota.Controls)
            {
                if (ctr.GetType() == typeof(QuotaGroup))
                {
                    if ((ctr as QuotaGroup).QuotaFieldValue == null || (ctr as QuotaGroup).QuotaFieldValue.IsEmpty())
                    {
                        UI.ShowError("Vui lòng chọn đầy đủ thông tin quota của đáp viên");
                        return false;
                    }
                   
                }
            }
            
            return true;
        }

        private void txtRecruit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!this.IsHandleCreated)
            {
                return;
            }
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                FilterLookupStaff(sender);
            }));
        }
        private void FilterLookupStaff(object sender)
        {
            DevExpress.XtraEditors.GridLookUpEdit edit = sender as DevExpress.XtraEditors.GridLookUpEdit;
            DevExpress.XtraGrid.Views.Grid.GridView gridView = edit.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
            System.Reflection.FieldInfo fi = gridView.GetType().GetField("extraFilter", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            //Text = edit.AutoSearchText;
            DevExpress.Data.Filtering.BinaryOperator op1 = new DevExpress.Data.Filtering.BinaryOperator("StaffID", "%" + edit.AutoSearchText + "%", DevExpress.Data.Filtering.BinaryOperatorType.Like);
            DevExpress.Data.Filtering.BinaryOperator op2 = new DevExpress.Data.Filtering.BinaryOperator("FullName", "%" + edit.AutoSearchText + "%", DevExpress.Data.Filtering.BinaryOperatorType.Like);
            string filterCondition = new DevExpress.Data.Filtering.GroupOperator(DevExpress.Data.Filtering.GroupOperatorType.Or, new DevExpress.Data.Filtering.CriteriaOperator[] { op1, op2 }).ToString();
            fi.SetValue(gridView, filterCondition);

            System.Reflection.MethodInfo mi = gridView.GetType().GetMethod("ApplyColumnsFilterEx", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            mi.Invoke(gridView, null);
        }

        private void luStaffID_Popup(object sender, EventArgs e)
        {
            if (!this.IsHandleCreated)
            {
                return;
            }

            FilterLookupStaff(sender);
        }



        public DataTable tblNhanSu { get; set; }

        private void txtRecruit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
                e.Handled = true;
            }
        }
    }
}
