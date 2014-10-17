using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:powerV
    /// </summary>
    public partial class powerV
    {
        public powerV()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int userId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from powerV");
            strSql.Append(" where userId=@userId ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)			};
            parameters[0].Value = userId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.powerV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into powerV(");
            strSql.Append("zan,pinglun,at,guanzhu,jubao,zhuanfa,shoucang,fasong,userName,userMail,userId)");
            strSql.Append(" values (");
            strSql.Append("@zan,@pinglun,@at,@guanzhu,@jubao,@zhuanfa,@shoucang,@fasong,@userName,@userMail,@userId)");
            SqlParameter[] parameters = {
					new SqlParameter("@zan", SqlDbType.Char,1),
					new SqlParameter("@pinglun", SqlDbType.Char,1),
					new SqlParameter("@at", SqlDbType.Char,1),
					new SqlParameter("@guanzhu", SqlDbType.Char,1),
					new SqlParameter("@jubao", SqlDbType.Char,1),
					new SqlParameter("@zhuanfa", SqlDbType.Char,1),
					new SqlParameter("@shoucang", SqlDbType.Char,1),
					new SqlParameter("@fasong", SqlDbType.Char,1),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userMail", SqlDbType.VarChar,50),
					new SqlParameter("@userId", SqlDbType.Int,4)};
            parameters[0].Value = model.zan;
            parameters[1].Value = model.pinglun;
            parameters[2].Value = model.at;
            parameters[3].Value = model.guanzhu;
            parameters[4].Value = model.jubao;
            parameters[5].Value = model.zhuanfa;
            parameters[6].Value = model.shoucang;
            parameters[7].Value = model.fasong;
            parameters[8].Value = model.userName;
            parameters[9].Value = model.userMail;
            parameters[10].Value = model.userId;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(starweibo.Model.powerV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update powerV set ");
            strSql.Append("zan=@zan,");
            strSql.Append("pinglun=@pinglun,");
            strSql.Append("at=@at,");
            strSql.Append("guanzhu=@guanzhu,");
            strSql.Append("jubao=@jubao,");
            strSql.Append("zhuanfa=@zhuanfa,");
            strSql.Append("shoucang=@shoucang,");
            strSql.Append("fasong=@fasong,");
            strSql.Append("userName=@userName,");
            strSql.Append("userMail=@userMail,");
            strSql.Append("userId=@userId");
            strSql.Append(" where userId=@userId ");
            SqlParameter[] parameters = {
					new SqlParameter("@zan", SqlDbType.Char,1),
					new SqlParameter("@pinglun", SqlDbType.Char,1),
					new SqlParameter("@at", SqlDbType.Char,1),
					new SqlParameter("@guanzhu", SqlDbType.Char,1),
					new SqlParameter("@jubao", SqlDbType.Char,1),
					new SqlParameter("@zhuanfa", SqlDbType.Char,1),
					new SqlParameter("@shoucang", SqlDbType.Char,1),
					new SqlParameter("@fasong", SqlDbType.Char,1),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userMail", SqlDbType.VarChar,50),
					new SqlParameter("@userId", SqlDbType.Int,4)};
            parameters[0].Value = model.zan;
            parameters[1].Value = model.pinglun;
            parameters[2].Value = model.at;
            parameters[3].Value = model.guanzhu;
            parameters[4].Value = model.jubao;
            parameters[5].Value = model.zhuanfa;
            parameters[6].Value = model.shoucang;
            parameters[7].Value = model.fasong;
            parameters[8].Value = model.userName;
            parameters[9].Value = model.userMail;
            parameters[10].Value = model.userId;

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
        public bool Delete(int userId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from powerV ");
            strSql.Append(" where userId=@userId ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)			};
            parameters[0].Value = userId;

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
        public bool DeleteList(string userIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from powerV ");
            strSql.Append(" where userId in (" + userIdlist + ")  ");
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
        public starweibo.Model.powerV GetModel(int userId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 zan,pinglun,at,guanzhu,jubao,zhuanfa,shoucang,fasong,userName,userMail,userId from powerV ");
            strSql.Append(" where userId=@userId ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)			};
            parameters[0].Value = userId;

            starweibo.Model.powerV model = new starweibo.Model.powerV();
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
        public starweibo.Model.powerV DataRowToModel(DataRow row)
        {
            starweibo.Model.powerV model = new starweibo.Model.powerV();
            if (row != null)
            {
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
                if (row["userName"] != null)
                {
                    model.userName = row["userName"].ToString();
                }
                if (row["userMail"] != null)
                {
                    model.userMail = row["userMail"].ToString();
                }
                if (row["userId"] != null && row["userId"].ToString() != "")
                {
                    model.userId = int.Parse(row["userId"].ToString());
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
            strSql.Append("select zan,pinglun,at,guanzhu,jubao,zhuanfa,shoucang,fasong,userName,userMail,userId ");
            strSql.Append(" FROM powerV ");
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
            strSql.Append(" zan,pinglun,at,guanzhu,jubao,zhuanfa,shoucang,fasong,userName,userMail,userId ");
            strSql.Append(" FROM powerV ");
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
            strSql.Append("select count(1) FROM powerV ");
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
                strSql.Append("order by T.userId desc");
            }
            strSql.Append(")AS Row, T.*  from powerV T ");
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
            parameters[0].Value = "powerV";
            parameters[1].Value = "userId";
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

