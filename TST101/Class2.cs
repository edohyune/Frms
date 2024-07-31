using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicV004.Frms
{
 public class TST101_G10 : EpicV004.Libs.MdlBase
 {
  private int _CtrlId;
  public int CtrlId
  {
   get => _CtrlId;
   set => Set(ref _CtrlId, value);
  }

  private string _CtrlNm;
  public string CtrlNm
  {
   get => _CtrlNm;
   set => Set(ref _CtrlNm, value);
  }

  private string _CtrlGrpCd;
  public string CtrlGrpCd
  {
   get => _CtrlGrpCd;
   set => Set(ref _CtrlGrpCd, value);
  }

  private string _CtrlRegNm;
  public string CtrlRegNm
  {
   get => _CtrlRegNm;
   set => Set(ref _CtrlRegNm, value);
  }

  private string _Binding;
  public string Binding
  {
   get => _Binding;
   set => Set(ref _Binding, value);
  }

  private string _Event;
  public string Event
  {
   get => _Event;
   set => Set(ref _Event, value);
  }

  private bool _ContainYn;
  public bool ContainYn
  {
   get => _ContainYn;
   set => Set(ref _ContainYn, value);
  }

  private bool _CustomYn;
  public bool CustomYn
  {
   get => _CustomYn;
   set => Set(ref _CustomYn, value);
  }

  private bool _UseYn;
  public bool UseYn
  {
   get => _UseYn;
   set => Set(ref _UseYn, value);
  }

  private string _Rnd;
  public string Rnd
  {
   get => _Rnd;
   set => Set(ref _Rnd, value);
  }

  private string _Memo;
  public string Memo
  {
   get => _Memo;
   set => Set(ref _Memo, value);
  }

  private int _PId;
  public int PId
  {
   get => _PId;
   set => Set(ref _PId, value);
  }

 }
}
