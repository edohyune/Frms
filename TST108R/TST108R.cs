using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace EpicV004.Frms
{
    public partial class TST108R : DevExpress.XtraReports.UI.XtraReport
    {
        public TST108R()
        {
            InitializeComponent();
        }
        public TST108R(DataSet dSet)
        {
            InitializeComponent();
            SetDateSet(dSet);
        }
        private void SetDateSet(DataSet dSet)
        {
            //if (dSet.Tables.Count < 1)
            //{
            //    throw new ArgumentException("DataSet must contain at least one table.");
            //}

            //Master data from FieldSet
            //DetailReport.DataSource = dSet.Tables[0];
            DetailReport.DataSource = dSet.Tables[1];
            id.DataBindings.Add("Text", dSet.Tables[0], "id");
            first_name.DataBindings.Add("Text", dSet.Tables[0], "first_name");
            last_name.DataBindings.Add("Text", dSet.Tables[0], "last_name");
            tell.DataBindings.Add("Text", dSet.Tables[0], "tell");
            dept.DataBindings.Add("Text", dSet.Tables[0], "dept");
            eng_name.DataBindings.Add("Text", dSet.Tables[0], "eng_name");
            addr.DataBindings.Add("Text", dSet.Tables[0], "addr");

            // Detail data from the same table

            sq.DataBindings.Add("Text", dSet.Tables[1], "sq");
            person.DataBindings.Add("Text", dSet.Tables[1], "person");
            phone.DataBindings.Add("Text", dSet.Tables[1], "phone");
            position.DataBindings.Add("Text", dSet.Tables[1], "position");
            memo.DataBindings.Add("Text", dSet.Tables[1], "memo");


        }
        private void ImageBinding(DataTable dTable, DevExpress.XtraReports.UI.XRPictureBox PictureBoxControl, string ImageField)
        {
            if (dTable.Rows[0][ImageField] is DBNull)
            {
                PictureBoxControl.Image = null;
            }
            else
            {
                byte[] photo = (byte[])dTable.Rows[0][ImageField];
                using (MemoryStream ms = new MemoryStream(photo))
                {
                    PictureBoxControl.Image = new Bitmap(ms);
                    PictureBoxControl.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
                }
            }

        }
    }
}
