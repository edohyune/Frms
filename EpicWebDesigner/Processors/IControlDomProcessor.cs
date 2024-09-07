using EpicV004.Libs.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicWebDesigner.Processors
{
    public interface IControlDomProcessor
    {
        string Process(FrmEle element, CtrlDom ctrlDom, List<FrmEle> childElements, string domType);
    }
}
