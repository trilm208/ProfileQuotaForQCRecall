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
    public partial class ImageItem : ClientControl
    {
        private Image image;

        public ImageItem()
        {
            InitializeComponent();
        }

        public string ID { get; set; }
        public ImageItem(Image image,string id)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            ID = id;
            pictureEdit1.Image = image;
        }

        public Image _pic { get; set; }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UI.ConfirmDelete() == true)
            {
                var query = DataAccess.DataQuery.Create("Docs", "ws_DOC_InterviewImageRespontdents_Delete", new
                {
                    ID=ID,
                    UserID=Services.GetInformation("UserID")
                });

                var ds = Services.Execute(query);
                if (ds == null)
                {
                    UI.ShowError(Services.LastError);
                    return;
                }
                UI.InformationDeleted();
                this.RaiseEvent(ReloadImage);
            }
        }

        public event EventHandler ReloadImage;
    }
}
