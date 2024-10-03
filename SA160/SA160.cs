using System;
using System.Data;
using System.Collections.Generic;

namespace EpicV004.Frms
{
    public partial class SA160 : FrmBase
    {
        //private GridControl G30; // ???????? g30 ???? GridControl

        public SA160()
        {
            InitializeComponent();
            //G30 = new GridControl(); // ????? instance ??? GridControl
        }

    //    #region Unbound
    //    public void InitTitle()
    //    {
    //        DataSet dSet = this.OpenDataSet("sa160_title");
    //        List<string[]> tempList = new List<string[]>();

    //        foreach (DataRow dRow in dSet.Tables[0].Rows)
    //        {
    //            tempList.Add(new string[]
    //            {
    //                dRow["dept"].ToString(),
    //                dRow["dept_name"].ToString()
    //            });
    //        }

    //        string[,] arr = new string[2, tempList.Count];
    //        for (int i = 0; i < tempList.Count; i++)
    //        {
    //            arr[0, i] = tempList[i][0];
    //            arr[1, i] = tempList[i][1];
    //        }

    //        G30.InsertArrayColumns(arr);
    //    }
    //    #endregion

    //    private void _OpenAll()
    //    {
    //        G30.InitUnboundData();
    //        InitTitle();
    //        this.Open();
    //    }

    //    // ????????????????????????????????????? FrmBase
    //    protected virtual DataSet OpenDataSet(string dataSetName)
    //    {
    //        // ?????????????? DataSet
    //        return new DataSet(); // ????????????????????
    //    }

    //    // ????????????????????????????????????? FrmBase
    //    protected virtual void Open()
    //    {
    //        // ???????????????????
    //    }
    //}

    //public class GridControl
    //{
    //    public void InitUnboundData()
    //    {
    //        // ???????????????????????? Unbound
    //    }

    //    public void InsertArrayColumns(string[,] arr)
    //    {
    //        // ????????...
    //    }
    }
}