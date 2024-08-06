using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Libs.Repo
{
    #region POPEDT LookUpEdit -----------------------------------------------------------||
    public class PopEdt : MdlBase
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
    public class SMPDAT : MdlBase
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
        public override string ToString()
        {
            return NM;
        }
    }

    public class SMPDATRepo
    {
        public List<SMPDAT> GetSampleData()
        {
            string sql = @"
select ID=cd, NM, PID=null
  from syscde
 where isnull(subcd,'*')='*'
 union all
select id=cd, nm, pid=pcd
  from syscde
 where isnull(subcd,'*')<>'*'
";
            using (var db = new GaiaHelper())
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
                        item.ChangedFlag = MdlState.None;
                    }
                }

                return result;
            }
        }
    }
    public class Menu : MdlBase
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

        private string tag;
        public string Tag
        {
            get { return tag; }
            set => Set(ref tag, value);
        }

        private string img;
        public string Img
        {
            get { return img; }
            set => Set(ref img, value);
        }

        public override string ToString()
        {
            return NM;
        }
    }

    public class MenuRepo
    {
        public List<Menu> GetMenuData()
        {
            string sql = @"
select ID=cd, NM, PID=null
  from syscde
 where isnull(subcd,'*')='*'
 union all
select id=cd, nm, pid=pcd
  from syscde
 where isnull(subcd,'*')<>'*'
";
            using (var db = new GaiaHelper())
            {
                var result = db.Query<Menu>(sql, null).ToList();
                if (result == null)
                {
                    return null;
                }
                else
                {
                    foreach (var item in result)
                    {
                        item.ChangedFlag = MdlState.None;
                    }
                }

                return result;
            }
        }
    }
    #endregion

}
