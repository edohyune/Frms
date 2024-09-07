using EpicV004.Libs.Repo;
using EpicWebDesigner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicWebDesigner.Processors
{
    public class ComboProc : IControlDomProcessor
    {
        public string Process(FrmEle element, CtrlDom ctrlDom, List<FrmEle> childElements, string domType)
        {
            string frwId = string.Empty;//element.Memo.Contains("FrwId") ? ExtractValue(element.Memo, "FrwId") : "";
            string frmId = string.Empty;//element.Memo.Contains("FrmId") ? ExtractValue(element.Memo, "FrmId") : "";

            string startTag = ctrlDom.StTag.Replace("<#FrwId#>", frwId)
                                           .Replace("<#FrmId#>", frmId)
                                           .Replace("<#CtrlNm#>", element.CtrlNm);

            string middleTag = string.IsNullOrEmpty(ctrlDom.MdTag) ? string.Empty : ctrlDom.MdTag;

            return $"{startTag}{middleTag}{ctrlDom.EdTag}";
        }

        private string ExtractValue(string memo, string key)
        {
            return string.Empty;
        }
    }

}
