using EpicV004.Libs.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicWebDesigner.Services
{
    // 파일: DomConverter.cs
    public class DomConverter
    {
        private readonly FrmEleRepo frmEles;
        private readonly CtrlDomRepo ctrlDoms;

        public DomConverter(FrmEleRepo frmEleRepo, CtrlDomRepo ctrlDomRepo)
        {
            frmEles = frmEleRepo;
            ctrlDoms = ctrlDomRepo;
        }

        //public string ConvertToDom(string frwId, string frmId)
        //{
        //    var rootElement = frmEles.GetRootElement(frwId, frmId);

        //    if (rootElement == null)
        //        throw new Exception("Root element not found");

        //    return GenerateDomRecursive(rootElement);
        //}

        public string ConvertToDom(FrmEle rootElement, string domType)
        {
            return GenerateDomRecursive(rootElement, domType);
        }

        public string GenerateDomRecursive(FrmEle element, string domType)
        {
            CtrlDom ctrlDom = ctrlDoms.GetByToolNm(element.ToolNm, domType);

            if (ctrlDom == null)
            {
                MessageBox.Show($"CtrlDom for {element.ToolNm} not found");
                return string.Empty;
            }


            //var childElements = frmEles.GetChildElements(element.FrmId, element.PathId);
            var childElements = frmEles.GetChildElements(element.FrmId, element.Id);
            var processorFactory = new Processors.ControlDomProcessorFactory(this);
            var processor = processorFactory.GetProcessor(element.ToolNm, domType);

            return processor.Process(element, ctrlDom, childElements, domType);

        }
    }

}
