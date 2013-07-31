using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace InnApp
{
    class KFRZ
    {
        private string s_LSH;
        public string LSH 
        {
            get { return s_LSH; }
            set
            {
                s_LSH = value;
                getInfoByLSH(value);
            }
        }

        private void getInfoByLSH(string lsh)
        {
            ConnDbForAcccess db = new ConnDbForAcccess();

            try
            {
                string sql = "select * from KFRZ where LSH='" + lsh + "'";
                DataSet ds = db.ReturnDataSet(sql);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];

                        KFID = dr["KFID"].ToString();
                        s_LSH = dr["LSH"].ToString();
                        FJH = dr["FJH"].ToString();
                        RZSJ = dr["RZSJ"].ToString();
                        LKSJ = dr["LKSJ"].ToString();
                        XM = dr["XM"].ToString();
                        ZJHM = dr["ZJHM"].ToString();

                        KFJG = int.Parse(dr["KFJG"].ToString());
                        YSK = int.Parse(dr["YSK"].ToString());
                        YJ = int.Parse(dr["YJ"].ToString());
                        RZTS = int.Parse(dr["RZTS"].ToString());
                        ZFK = int.Parse(dr["ZFK"].ToString());

                    }
                }
            }
            catch (Exception e)
            {
                Loger.ShowMessage(e.ToString());
            }
        }
        public string KFID { get; set; }
        public string FJH { get; set; }
        public string XM { get; set; }
        public string ZJHM { get; set; }
        public string RZSJ { get; set; }
        public string LKSJ { get; set; }

        /// <summary>
        /// 客房价格
        /// </summary>
        public int KFJG { get; set; }

        /// <summary>
        /// 总房款
        /// </summary>
        public int ZFK { get; set; }

        /// <summary>
        /// 预收款
        /// </summary>
        public int YSK { get; set; }

        /// <summary>
        /// 押金
        /// </summary>
        public int YJ { get; set; }
        
        /// <summary>
        /// 入住天数
        /// </summary>
        public int RZTS { get; set; }


        public KFRZ()
        { }

        public KFRZ(string lsh)
        {
            getInfoByLSH(lsh);
        }


        public string getRZLSH(string kfid)
        {
            ConnDbForAcccess db = new ConnDbForAcccess();

            try
            {
                string sql = "select LSH from KFRZ where SFTF='0' and  KFID='" + kfid + "'";
                DataSet ds = db.ReturnDataSet(sql);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];

                        return  dr["LSH"].ToString();

                    }
                }

                return "";

            }
            catch (Exception e)
            {
                Loger.ShowMessage(e.ToString());
            }
            return "";
        }

        /// <summary>
        /// 开房
        /// </summary>
        /// <returns></returns>
        public bool  KF()
        {
            ConnDbForAcccess db = new ConnDbForAcccess();

            try
            {
                string sql = "insert into KFRZ(LSH,KFID,FJH,XM,ZJHM,RZSJ,KFJG,RZTS,YSK,YJ)";
                sql += "values('" + getLSH() + "','" + KFID + "','" + FJH + "','" + XM + "','" + ZJHM + "','";
                sql += System.DateTime.Now.ToString("yyyyMMddHHmmss");
                sql += "'," + KFJG + "," + RZTS + "," + YSK + "," + YJ + ")";

                return db.ExeSQL(sql);
            }
            catch (Exception e)
            {
                Loger.ShowMessage(e.ToString());
                return false;
            }
        }


        public bool TF()
        {
            ConnDbForAcccess db = new ConnDbForAcccess();

            try
            {
                string sql = "update  KFRZ set SFTF='1', LKSJ = '";
                sql +=  System.DateTime.Now.ToString("yyyyMMddHHmmss");
                sql += "',RZTS =" + RZTS;
                sql += ",ZFK =" + ZFK;
                sql += " where lsh = '" + LSH + "'";

                return db.ExeSQL(sql);
            }
            catch (Exception e)
            {
                Loger.ShowMessage(e.ToString());
                return false;
            }
        }



        private string getLSH()
        {
            ConnDbForAcccess db = new ConnDbForAcccess();
            string lsh = System.DateTime.Now.ToString("yyyyMMdd");
            try
            {
                string sql = "select max(LSH) +1   from KFRZ where LSH like '";
                sql += lsh + "%'";
                DataSet ds = db.ReturnDataSet(sql);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][0].ToString().Length > 0)
                        {
                            lsh = dt.Rows[0][0].ToString();
                        }
                    }
                }
                
            }
            catch (Exception e)
            {
                Loger.ShowMessage(e.ToString());
            }

            if (lsh.Length < 10)
            {
                lsh += "001";
            }
            return lsh;
        }



    }
}
