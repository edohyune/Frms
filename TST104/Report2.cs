using DevExpress.CodeParser;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace TST104
{
    public partial class Report2 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report2()
        {
            InitializeComponent();
        }

        public Report2(DataSet dSet)
        {
            InitializeComponent();
            SetDateSet(dSet);
        }

        private void SetDateSet(DataSet dSet)
        {
            if (dSet.Tables.Count < 1)
            {
                throw new ArgumentException("DataSet must contain at least one table.");
            }

            // Master data from FieldSet
            DetailReport.DataSource = dSet.Tables[0];
            id.DataBindings.Add("Text", dSet.Tables[0], "id");
            first_name.DataBindings.Add("Text", dSet.Tables[0], "first_name");
            last_name.DataBindings.Add("Text", dSet.Tables[0], "last_name");
            tell.DataBindings.Add("Text", dSet.Tables[0], "tell");
            dept.DataBindings.Add("Text", dSet.Tables[0], "dept");
            eng_name.DataBindings.Add("Text", dSet.Tables[0], "eng_name");
            addr.DataBindings.Add("Text", dSet.Tables[0], "addr");

            // Detail data from the same table
            sq.DataBindings.Add("Text", dSet.Tables[0], "sq");
            person.DataBindings.Add("Text", dSet.Tables[0], "person");
            phone.DataBindings.Add("Text", dSet.Tables[0], "phone");
            position.DataBindings.Add("Text", dSet.Tables[0], "position");
            memo.DataBindings.Add("Text", dSet.Tables[0], "memo");
            //--test1
            //if (dSet.Tables.Count < 1)
            //{
            //    throw new ArgumentException("DataSet must contain at least one table.");
            //}

            //// Master data from FieldSet
            //DetailReport.DataSource = dSet.Tables[0];
            //id.DataBindings.Add("Text", dSet.Tables[0], "id");
            //first_name.DataBindings.Add("Text", dSet.Tables[0], "first_name");
            //last_name.DataBindings.Add("Text", dSet.Tables[0], "last_name");
            //tell.DataBindings.Add("Text", dSet.Tables[0], "tell");
            //dept.DataBindings.Add("Text", dSet.Tables[0], "dept");
            //eng_name.DataBindings.Add("Text", dSet.Tables[0], "eng_name");
            //addr.DataBindings.Add("Text", dSet.Tables[0], "addr");

            //// Detail data from GridSet
            //if (dSet.Tables.Count > 1)
            //{
            //    DetailReport.DataSource = dSet.Tables[1];
            //    sq.DataBindings.Add("Text", dSet.Tables[1], "sq");
            //    person.DataBindings.Add("Text", dSet.Tables[1], "person");
            //    phone.DataBindings.Add("Text", dSet.Tables[1], "phone");
            //    position.DataBindings.Add("Text", dSet.Tables[1], "position");
            //    memo.DataBindings.Add("Text", dSet.Tables[1], "memo");
            //}
            //else
            //{
            //    MessageBox.Show("Warning: Second table not found in DataSet. Detail report may be empty.");
            //}

            //--test0

            //Check if the DataSet has at least two tables
            //if (dSet.Tables.Count < 2)
            //    return;

            //master data from FieldSet
            //DetailReport.DataSource = dSet.Tables[0];
            //id.DataBindings.Add("Text", dSet.Tables[0], "id");
            //first_name.DataBindings.Add("Text", dSet.Tables[0], "first_name");
            //last_name.DataBindings.Add("Text", dSet.Tables[0], "last_name");
            //tell.DataBindings.Add("Text", dSet.Tables[0], "tell");
            //dept.DataBindings.Add("Text", dSet.Tables[0], "dept");
            //eng_name.DataBindings.Add("Text", dSet.Tables[0], "eng_name");
            //addr.DataBindings.Add("Text", dSet.Tables[0], "addr");

            //Detail data from GridSet
            //DetailReport.DataSource = dSet.Tables[0];
            //sq.DataBindings.Add("Text", dSet.Tables[0], "sq");
            //person.DataBindings.Add("Text", dSet.Tables[0], "person");
            //phone.DataBindings.Add("Text", dSet.Tables[0], "phone");
            //position.DataBindings.Add("Text", dSet.Tables[0], "position");
            //memo.DataBindings.Add("Text", dSet.Tables[0], "memo");

            //DetailReport.DataSource = dSet.Tables[1];
            //sq.DataBindings.Add("Text", dSet.Tables[1], "sq");
            //person.DataBindings.Add("Text", dSet.Tables[1], "person");
            //phone.DataBindings.Add("Text", dSet.Tables[1], "phone");
            //position.DataBindings.Add("Text", dSet.Tables[1], "position");
            //memo.DataBindings.Add("Text", dSet.Tables[1], "memo");

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
