using EpicV004.Libs.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
    public interface IControlDomProcessor
    {
        string Process(FrmEle element, CtrlDom ctrlDom, List<FrmEle> childElements);
    }

    public class SplitContainerProcessor : IControlDomProcessor
    {
        public string Process(FrmEle element, CtrlDom ctrlDom, List<FrmEle> childElements)
        {
            // distance와 orientation을 Memo나 다른 속성에서 가져와서 태그에 반영
            string distance = element.Memo.Contains("distance") ? ExtractValue(element.Memo, "distance") : "100";
            string orientation = element.Memo.Contains("orientation") ? ExtractValue(element.Memo, "orientation") : "Horizontal";

            // 시작 태그에 동적 속성 반영
            string startTag = ctrlDom.StTag.Replace("<#distance#>", distance)
                                           .Replace("<#orientation#>", orientation);

            // 자식 컨트롤(Panel1, Panel2)을 재귀적으로 처리
            string content = string.Empty;
            foreach (var child in childElements)
            {
                // 재귀적으로 자식 컨트롤의 DOM을 생성
                content += GenerateDomRecursive(child);
            }

            return $"{startTag}{content}{ctrlDom.EdTag}";
        }

        private string ExtractValue(string memo, string key)
        {
            // Memo에서 해당 key의 값을 추출하는 로직 구현
            return memo.Split(',').FirstOrDefault(x => x.Contains(key))?.Split('=')[1] ?? string.Empty;
        }
    }

    public class UCTextBoxProcessor : IControlDomProcessor
    {
        public string Process(FrmEle element, CtrlDom ctrlDom, List<FrmEle> childElements)
        {
            // 컨트롤의 프레임워크 ID와 폼 ID를 Memo에서 가져와서 바인딩
            string frwId = element.Memo.Contains("FrwId") ? ExtractValue(element.Memo, "FrwId") : "";
            string frmId = element.Memo.Contains("FrmId") ? ExtractValue(element.Memo, "FrmId") : "";

            // 시작 태그에 동적 속성 반영
            string startTag = ctrlDom.StTag.Replace("<#FrwId#>", frwId)
                                           .Replace("<#FrmId#>", frmId)
                                           .Replace("<#CtrlNm#>", element.CtrlNm);

            // 중간 태그가 있을 경우 처리
            string middleTag = string.IsNullOrEmpty(ctrlDom.MdTag) ? string.Empty : ctrlDom.MdTag;

            return $"{startTag}{middleTag}{ctrlDom.EdTag}";
        }

        private string ExtractValue(string memo, string key)
        {
            // Memo에서 해당 key의 값을 추출하는 로직 구현
            return memo.Split(',').FirstOrDefault(x => x.Contains(key))?.Split('=')[1] ?? string.Empty;
        }
    }

    public class ControlDomProcessorFactory
    {
        public static IControlDomProcessor GetProcessor(string toolNm)
        {
            switch (toolNm)
            {
                case "SplitContainer":
                    return new SplitContainerProcessor();
                case "UCTextBox":
                    return new UCTextBoxProcessor();
                // 다른 컨트롤러에 맞는 프로세서 추가
                default:
                    throw new Exception($"Processor not found for ToolNm: {toolNm}");
            }
        }
    }

    public class Win2BlzBootV001
    {
        private readonly FrmEleRepo _frmEleRepo;
        private readonly CtrlDomRepo _ctrlDomRepo;

        public Win2BlzBootV001(FrmEleRepo frmEleRepo, CtrlDomRepo ctrlDomRepo)
        {
            _frmEleRepo = frmEleRepo;
            _ctrlDomRepo = ctrlDomRepo;
        }

        // FrmEle 정보를 DOM으로 변환하는 메인 함수
        public string ConvertToDom(string frmId)
        {
            // 해당 Form의 최상위 컨트롤을 가져옵니다
            var rootElement = _frmEleRepo.GetRootElement(frmId);

            if (rootElement == null)
                throw new Exception("Root element not found");

            // 재귀적으로 DOM 생성
            return GenerateDomRecursive(rootElement);
        }

        // 재귀적으로 FrmEle 정보를 DOM으로 변환
        private string GenerateDomRecursive(FrmEle element)
        {
            // CtrlDomRepo에서 ToolNm에 해당하는 DOM 정보를 가져옵니다.
            var ctrlDom = _ctrlDomRepo.GetByToolNm(element.ToolNm);

            if (ctrlDom == null)
                throw new Exception($"CtrlDom for {element.ToolNm} not found");

            // DOM 태그 시작 부분 생성
            string domTag = ctrlDom.StTag;

            // 중간 부분 (MdTag)이 있으면 추가
            if (!string.IsNullOrEmpty(ctrlDom.MdTag))
            {
                domTag += ctrlDom.MdTag;
            }

            // 자식 컨트롤을 가져와 재귀적으로 DOM 생성
            var childElements = _frmEleRepo.GetChildElements(element.Id);
            foreach (var child in childElements)
            {
                domTag += GenerateDomRecursive(child);
            }

            // 끝 부분 (EdTag)을 추가하여 태그를 닫습니다
            domTag += ctrlDom.EdTag;

            return domTag;
        }
    }
}
