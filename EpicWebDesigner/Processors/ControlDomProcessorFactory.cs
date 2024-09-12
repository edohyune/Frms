using EpicV004.Ctrls;
using EpicV004.Frms;
using EpicV004.UsrCtrl;
using EpicWebDesigner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicWebDesigner.Processors
{
    public class ControlDomProcessorFactory
    {
        private DomConverter domConverter;
        public ControlDomProcessorFactory(DomConverter dc)
        {
            domConverter = dc;
        }
        public IControlDomProcessor GetProcessor(string toolNm, string domType)
        {
            switch (toolNm)
            {
                case "UCGridSet":
                    return new GridUnitProc();
                case "UCSplit":
                case "SplitContainer":
                    return new SplitContainerProc(domConverter);
                case "GroupControl":
                case "GroupBox":
                case "UCPanel":
                case "SplitterPanel":
                case "XtraTabPage":
                    return new PanelProc(domConverter);
                case "LabelText":
                case "UCDateBox":
                case "UCTextBox":
                case "UCRichText":
                    return new UCTextBoxProc();
                case "XtraTabControl":
                case "UCTab":
                    return new TabsProc(domConverter);
                case "LabelCode":
                case "UCCodeBox":
                    return new ComboProc();
                case "UCButton":
                    return new ButtonProc();
                default:
                    throw new Exception($"Processor not found for ToolNm: {toolNm}");
            }
        }
    }

}
