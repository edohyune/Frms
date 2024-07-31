using DevExpress.DataProcessing.InMemoryDataProcessor;
using EpicV004.Libs.Repo;
using EpicV004.Libs.Syntax;
using EpicV004.Libs;
using System.ComponentModel;

namespace EpicV004.Frms
{
    public partial class WorkSetGet : FrmBase
    {
        private BindingList<WorkSetGet_GRDWRKGET> wrkGetbs;

        public WorkSetGet()
        {
            InitializeComponent();
        }

        private void btnLoadField_Click(object sender, EventArgs e)
        {
            wrkGetbs = (BindingList<WorkSetGet_GRDWRKGET>)grdWrkGet.DataSource;
            string selectQuery;

            if (string.IsNullOrWhiteSpace(GenFunc.GetSql(new { FrwId = frwId.Text, FrmId = frmId.Text, WrkId = wrkId.Text, CRUDM = "R" })))
            {
                MessageBox.Show("Select 쿼리를 먼저 입력하세요.");
                return;
            }
            else
            {
                selectQuery = GenFunc.GetSql(new { FrwId = frwId.Text, FrmId = frmId.Text, WrkId = wrkId.Text, CRUDM = "R" });
            }

            SyntaxExtractor extractor = new SyntaxExtractor();
            SyntaxMatch cvariables = extractor.ExtractVariables(selectQuery);

            foreach (var kvp in cvariables.OPatternMatch)
            {
                //wrkGets에 있으면 update 없으면 insert
                var wrkGet = wrkGetbs.Where(x => x.FldNm == kvp.Key).FirstOrDefault();
                if (wrkGet == null)
                {
                    wrkGet = wrkGetbs.Where(x => x.FldNm.ToLower() == kvp.Key.ToLower()).FirstOrDefault();
                    if (wrkGet != null)
                    {
                        wrkGet.FldNm = kvp.Key;
                        wrkGet.ChangedFlag = MdlState.Updated;
                    }
                    else
                    {
                        wrkGetbs.Add(new WorkSetGet_GRDWRKGET
                        {
                            FrwId = frwId.Text,
                            FrmId = frmId.Text,
                            WrkId = wrkId.Text,
                            FldNm = kvp.Key,
                            ChangedFlag = MdlState.Inserted
                        });
                    }
                }
            }
        }
    }
}
