using EpicV004.Libs;
using System.ComponentModel;
using System.Data;

namespace EpicV004.Frms
{
    public partial class WorkSetSet : FrmBase
    {
        private BindingList<WorkSetSet_GRDWRKSET> wrkSetbs;

        public WorkSetSet()
        {
            InitializeComponent();
        }

        private void btnLoadField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GenFunc.GetSql(new { FrwId = frwId.Text, FrmId = frmId.Text, WrkId = wrkId.Text, CRUDM = "R" })))
            {
                MessageBox.Show("Select 쿼리를 먼저 입력하세요.");
                return;
            }

            using (var db = new GaiaHelper())
            {
                wrkSetbs = (BindingList<WorkSetSet_GRDWRKSET>)grdWrkSet.DataSource;

                DataSet dSet = db.GetSelectColumns(new { FrwId = frwId.Text, FrmId = frmId.Text, WrkId = wrkId.Text, CRUDM = "R" });
                if (dSet != null)
                {
                    foreach (DataColumn cols in dSet.Tables[0].Columns)
                    {
                        var wrkFld = wrkSetbs.Where(x => x.FldNm == cols.ColumnName).FirstOrDefault();

                        if (wrkFld == null)
                        {
                            wrkSetbs.Add(new WorkSetSet_GRDWRKSET
                            {
                                FrwId = frwId.Text,
                                FrmId = frmId.Text,
                                WrkId = wrkId.Text,
                                FldNm = cols.ColumnName,
                                ChangedFlag = MdlState.Inserted
                            });
                        }
                    }
                    grdWrkSet.DataSource = wrkSetbs;
                }
            }
        }
    }
}
