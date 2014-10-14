using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:powerInfo
    /// </summary>
    public partial class powerInfo
    {
        public powerInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("id", "powerInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from powerInfo");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(starweibo.Model.powerInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into powerInfo(");
            strSql.Append("userId,zan,pinglun,at,guanzhu,jubao,zhuanfa,shoucang,fasong)");
            strSql.Append(" values (");
            strSql.Append("@userId,@zan,@pinglun,@at,@guanzhu,@jubao,@zhuanfa,@shoucang,@fasong)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@zan", SqlDbType.Char,1),
					new SqlParameter("@pinglun", SqlDbType.Char,1),
					new SqlParameter("@at", SqlDbType.Char,1),
					new SqlParameter("@guanzhu", SqlDbType.Char,1),
					new SqlParameter("@jubao", SqlDbType.Char,1),
					new SqlParameter("@zhuanfa", SqlDbType.Char,1),
					new SqlParameter("@shoucang", SqlDbType.Char,1),
					new SqlParameter("@fasong", SqlDbType.Char,1)};
            parameters[0].Value = model.userId;
            parameters[1].Value = model.zan;
            parameters[2].Value = model.pinglun;
            parameters[3].Value = model.at;
            parameters[4].Value = model.guanzhu;
            parameters[5].Value = model.jubao;
            parameters[6].Value = model.zhuanfa;
            parameters[7].Value = model.shoucang;
            parameters[8].Value = model.fasong;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(starweibo.Model.powerInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update powerInfo set ");
            strSql.Append("userId=@userId,");
            strSql.Append("zan=@zan,");
            strSql.Append("pinglun=@pinglun,");
            strSql.Append("at=@at,");
            strSql.Append("guanzhu=@guanzhu,");
            strSql.Append("jubao=@jubao,");
            strSql.Append("zhuanfa=@zhuanfa,");
            strSql.Append("shoucang=@shoucang,");
            strSql.Append("fasong=@fasong");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@zan", SqlDbType.Char,1),
					new SqlParameter("@pinglun", SqlDbType.Char,1),
					new SqlParameter("@at", SqlDbType.Char,1),
					new SqlParameter("@guanzhu", SqlDbType.Char,1),
					new SqlParameter("@jubao", SqlDbType.Char,1),
					new SqlParameter("@zhuanfa", SqlDbType.Char,1),
					new SqlParameter("@shoucang", SqlDbType.Char,1),
					new SqlParameter("@fasong", SqlDbType.Char,1),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.userId;
            parameters[1].Value = model.zan;
            parameters[2].Value = model.pinglun;
            parameters[3].Value = model.at;
            parameters[4].Value = model.guanzhu;
            parameters[5].Value = model.jubao;
            parameters[6].Value = model.zhuanfa;
            parameters[7].Value = model.shoucang;
            parameters[8].Value = model.fasong;
            parameters[9].Value = model.id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from powerInfo ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from powerInfo ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public starweibo.Model.powerInfo GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,userId,zan,pinglun,at,guanzhu,jubao,zhuanfa,shoucang,fasong from powerInfo ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            starweibo.Model.powerInfo model = new starweibo.Model.powerInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public starweibo.Model.powerInfo DataRowToModel(DataRow row)
        {
            starweibo.Model.powerInfo model = new starweibo.Model.powerInfo();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["userId"] != null && row["userId"].ToString() != "")
                {
                    model.userId = int.Parse(row["userId"].ToString());
                }
                if (row["zan"] != null)
                {
                    model.zan = row["zan"].ToString();
                }
                if (row["pinglun"] != null)
                {
                    model.pinglun = row["pinglun"].ToString();
                }
                if (row["at"] != null)
                {
                    model.at = row["at"].ToString();
                }
                if (row["guanzhu"] != null)
                {
                    model.guanzhu = row["guanzhu"].ToString();
                }
                if (row["jubao"] != null)
                {
                    model.jubao = row["jubao"].ToString();
                }
                if (row["zhuanfa"] != null)
                {
                    model.zhuanfa = row["zhuanfa"].ToString();
                }
                if (row["shoucang"] != null)
                {
                    model.shoucang = row["shoucang"].ToString();
                }
                if (row["fasong"] != null)
                {
                    model.fasong = row["fasong"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,userId,zan,pinglun,at,guanzhu,jubao,zhuanfa,shoucang,fasong ");
            strSql.Append(" FROM powerInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,userId,zan,pinglun,at,guanzhu,jubao,zhuanfa,shoucang,fasong ");
            strSql.Append(" FROM powerInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM powerInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from powerInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "powerInfo";
            parameters[1].Value = "id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

