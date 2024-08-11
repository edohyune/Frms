using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    #region POPEDT LookUpEdit -----------------------------------------------------------||
    public class PopEdt : Libs.MdlBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    #endregion
    #region GRDPOP GridLookUpEdit--------------------------------------------------------||
    public class GrdPop
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    #endregion
    #region SCHPOP SearchLookUpEdit------------------------------------------------------||
    public class SrchPop
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    #endregion
    #region TREPOP TreeListLookUpEdit----------------------------------------------------||
    public class TrePop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ParentID { get; set; }
    }
    #endregion
    #region GRDTRE TreeList--------------------------------------------------------------||
    public class GrdTre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ParentID { get; set; }
    }
    #endregion
    
    #region Sample Data -----------------------------------------------------------------||
    public class SMPDAT : Libs.MdlBase
    {
        private string id;
        public string ID
        {
            get { return id; }
            set => Set(ref id, value);
        }

        private string nm;
        public string NM
        {
            get { return nm; }
            set => Set(ref nm, value);
        }

        private string pid;
        public string PID
        {
            get { return pid; }
            set => Set(ref pid, value);
        }
        public string Tag { get; set; }
    }

    public class SMPDATRepo
    {
        public List<SMPDAT> GetSampleData()
        {
            string sql = @"
select ID=cd, NM, PID=null, Tag='tagText'
  from syscde
 where isnull(subcd,'*')='*'
 union all
select id=cd, nm, pid=pcd, Tag='tagText'
  from syscde
 where isnull(subcd,'*')<>'*'
";
            using (var db = new Libs.GaiaHelper())
            {
                var result = db.Query<SMPDAT>(sql, null).ToList();
                if (result == null)
                {
                    throw new KeyNotFoundException($"A record was not found.");
                }
                else
                {
                    foreach (var item in result)
                    {
                        item.ChangedFlag = Libs.MdlState.None;
                    }
                }

                return result;
            }
        }
    }
    #endregion
    public class LOOKUP_GRDFRWFRM : Libs.MdlBase
    {
        private string _FrwId;
        public string FrwId
        {
            get => _FrwId;
            set => Set(ref _FrwId, value);
        }

        private string _FrmId;
        public string FrmId
        {
            get => _FrmId;
            set => Set(ref _FrmId, value);
        }

        private string _FrmNm;
        public string FrmNm
        {
            get => _FrmNm;
            set => Set(ref _FrmNm, value);
        }

        private int _UsrRegId;
        public int UsrRegId
        {
            get => _UsrRegId;
            set => Set(ref _UsrRegId, value);
        }

        private string _FilePath;
        public string FilePath
        {
            get => _FilePath;
            set => Set(ref _FilePath, value);
        }

        private string _FileNm;
        public string FileNm
        {
            get => _FileNm;
            set => Set(ref _FileNm, value);
        }

        private string _NmSpace;
        public string NmSpace
        {
            get => _NmSpace;
            set => Set(ref _NmSpace, value);
        }

        private bool _FldYn;
        public bool FldYn
        {
            get => _FldYn;
            set => Set(ref _FldYn, value);
        }

        private string _PId;
        public string PId
        {
            get => _PId;
            set => Set(ref _PId, value);
        }

        private string _Memo;
        public string Memo
        {
            get => _Memo;
            set => Set(ref _Memo, value);
        }

    }
}
