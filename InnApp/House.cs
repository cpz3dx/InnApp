using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Collections;

namespace InnApp
{
    class House
    {
        public string KFID{set;get;}
        /// <summary>
        /// 房间号
        /// </summary>
        public string FJH { set; get; }
        public string SZC { set; get; }
        /// <summary>
        /// 备注 标间,单人间,双人床,大床,宽带,温泉
        /// </summary>
        public string BZ { set; get; }

        /// <summary>
        /// 客房价格
        /// </summary>
        public int KFJG { set; get; }

        public House()
        {
            KFID = "";
            FJH = "";
            SZC = "";
            KFJG = 0;

        }


        public bool Add()
        {
            ConnDbForAcccess db = new ConnDbForAcccess();

            try
            {
                string sql = "insert into KF(FJH,KFJG,SZC,BZ)values('" + FJH + "'," + KFJG + ",'" + SZC + "','" +BZ+"')";

                return db.ExeSQL(sql);
            }
            catch (Exception e)
            {
                Loger.ShowMessage(e.ToString());
                return false;
            }
        }

        public List<House> getHouseList()
        {

            ConnDbForAcccess db = new ConnDbForAcccess();

            List<House>  hs = new List<House>();
            try
            {
                string sql = "select KFID,FJH ,SZC, BZ,KFJG  from KF order by FJH";
                DataSet ds = db.ReturnDataSet(sql);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            House h = new House();
                            h.KFID = dr["KFID"].ToString();
                            h.FJH = dr["FJH"].ToString();
                            h.SZC = dr["SZC"].ToString();
                            h.BZ = dr["BZ"].ToString();

                            h.KFJG = int.Parse(dr["KFJG"].ToString());

                            hs.Add(h);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Loger.ShowMessage(e.ToString());
            }
            
            return hs;
        }

        /// <summary>
        /// 很据id查询客房
        /// </summary>
        /// <param name="kfid"></param>
        public House(string kfid)
        {
            ConnDbForAcccess db = new ConnDbForAcccess();

            try
            {
                string sql = "select KFID,FJH ,SZC, BZ ,KFJG from KF where KFID=" + kfid;
                DataSet ds = db.ReturnDataSet(sql);

                if (ds.Tables.Count>0)
                { 
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];

                        KFID = dr["KFID"].ToString();
                        FJH = dr["FJH"].ToString();
                        SZC = dr["SZC"].ToString();
                        BZ = dr["BZ"].ToString();

                        KFJG = int.Parse(dr["KFJG"].ToString());

                    }
                }
            }
            catch (Exception e)
            {
                Loger.ShowMessage(e.ToString());
            }
        }
    }
}
