﻿using DevExpress.Map.Native;
using EpicV004.Libs.Repo;
using EpicWebDesigner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicWebDesigner.Processors
{
    public class GridUnitProc : IControlDomProcessor
    {
        public string Process(FrmEle element, CtrlDom ctrlDom, List<FrmEle> childElements, string domType)
        {
            // Tabs의 DOM 처리 로직
            string distance = string.Empty;//element.Memo.Contains("distance") ? ExtractValue(element.Memo, "distance") : "100";
            string orientation = string.Empty;//element.Memo.Contains("orientation") ? ExtractValue(element.Memo, "orientation") : "Horizontal";

            string startTag = ctrlDom.StTag.Replace("<#distance#>", distance)
                                           .Replace("<#orientation#>", orientation);

            string content = string.Empty;


            return $"{startTag}{content}{ctrlDom.EdTag}";
        }
        private string ExtractValue(string memo, string key)
        {
            return string.Empty;
        }
    }
}
