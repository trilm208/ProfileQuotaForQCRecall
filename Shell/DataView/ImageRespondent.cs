using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using QA;

namespace Shell.DataView
{
    public partial class ImageRespondent : ClientControl
    {
        public ImageRespondent()
        {
            InitializeComponent();
        }

        internal void LoadImage(DataTable dataTable)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                var image = Base64ToImage(row.Item("Image"));
                var control = new ImageItem(image,row.Item("ID"));
                control.Services = this.Services;
                control.Height = 700;
                control.Width = 700;
                control.ReloadImage+=control_ReloadImage;
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        public void control_ReloadImage(object sender, EventArgs e)
        {
            
            var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewImageRespontdents_Get", new
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
           
            this.LoadImage(ds.Tables[0]);
          
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            Image image;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }

        public string ProjectID { get; set; }

        public string AnswerID { get; set; }
    }
}
