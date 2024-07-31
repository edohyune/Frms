using EpicV004.Libs.Repo;
using EpicV004.Libs;
using System.Data;
using System.ComponentModel;

namespace EpicV004.Frms
{
    public partial class GridSetColumn : FrmBase
    {
        private BindingList<GridSetColumn_GRDWRKFLD> wrkFldbs;

        public GridSetColumn()
        {
            InitializeComponent();
        }

        private void btnGetColumns_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GenFunc.GetSql(new { FrwId = frwId.Text, FrmId = frmId.Text, WrkId = wrkId.Text, CRUDM = "R" })))
            {
                MessageBox.Show("Select 쿼리를 먼저 입력하세요.");
                return;
            }

            using (var db = new GaiaHelper())
            {
                wrkFldbs = (BindingList<GridSetColumn_GRDWRKFLD>)grdWrkFld.DataSource;

                DataSet dSet = db.GetSelectColumns(new { FrwId = frwId.Text, FrmId = frmId.Text, WrkId = wrkId.Text, CRUDM = "R" });
                if (dSet != null)
                {
                    foreach (DataColumn cols in dSet.Tables[0].Columns)
                    {
                        var wrkFld = wrkFldbs.Where(x => x.CtrlNm == $"{wrkId.Text}.{cols.ColumnName}").FirstOrDefault();

                        if (wrkFld != null)
                        {
                            wrkFld.FrwId = frwId.Text;
                            wrkFld.FrmId = frmId.Text;
                            wrkFld.WrkId = wrkId.Text;
                            wrkFld.CtrlCls = "Column";
                            wrkFld.CtrlNm = $"{wrkId.Text}.{cols.ColumnName}";
                            wrkFld.FldNm = cols.ColumnName;
                            wrkFld.FldTy = GetFieldType(cols.DataType);
                            wrkFld.FldTitle = cols.ColumnName;
                            wrkFld.ChangedFlag = MdlState.Updated;
                        }
                        else
                        {
                            wrkFldbs.Add(new GridSetColumn_GRDWRKFLD
                            {
                                FrwId = frwId.Text,
                                FrmId = frmId.Text,
                                WrkId = wrkId.Text,
                                CtrlCls = "Column",
                                CtrlNm = $"{wrkId.Text}.{cols.ColumnName}",
                                FldNm = cols.ColumnName,
                                FldTy = GetFieldType(cols.DataType),
                                FldTitle = cols.ColumnName,
                                ShowYn = true,
                                EditYn = true,
                                ChangedFlag = MdlState.Inserted
                            });
                        }
                    }
                    grdWrkFld.DataSource = wrkFldbs;
                }
            }
        }
        private string GetFieldType(Type dataType)
        {
            return dataType.Name switch
            {
                "Int32" => "Int",
                "String" => "Text",
                "DateTime" => "DateTime",
                "Date" => "Date",
                "Decimal" => "Decimal",
                "Double" => "Decimal",
                "Boolean" => "bool",
                _ => "Text",
            };
        }
    }
}

