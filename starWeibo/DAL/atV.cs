using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:atV
    /// </summary>
    public partial class atV
    {
        public atV()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int blogId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from atV");
            strSql.Append(" where blogId=@blogId ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogId", SqlDbType.Int,4)			};
            parameters[0].Value = blogId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.atV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into atV(");
            strSql.Append("blogContent,blogAuthorId,blogPubTime,atId,userName,userHeadimage,atuserName,atuserHeadimage,blogId)");
            strSql.Append(" values (");
            strSql.Append("@blogContent,@blogAuthorId,@blogPubTime,@atId,@userName,@userHeadimage,@atuserName,@atuserHeadimage,@blogId)");
            SqlParameter[] parameters = {
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogPubTime", SqlDbType.DateTime),
					new SqlParameter("@atId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@atuserName", SqlDbType.NVarChar,20),
					new SqlParameter("@atuserHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@blogId", SqlDbType.Int,4)};
            parameters[0].Value = model.blogContent;
            parameters[1].Value = model.blogAuthorId;
            parameters[2].Value = model.blogPubTime;
            parameters[3].Value = model.atId;
            parameters[4].Value = model.userName;
            parameters[5].Value = model.userHeadimage;
            parameters[6].Value = model.atuserName;
            parameters[7].Value = model.atuserHeadimage;
            parameters[8].Value = model.blogId;

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
        public bool Update(starweibo.Model.atV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update atV set ");
            strSql.Append("blogContent=@blogContent,");
            strSql.Append("blogAuthorId=@blogAuthorId,");
            strSql.Append("blogPubTime=@blogPubTime,");
            strSql.Append("atId=@atId,");
            strSql.Append("userName=@userName,");
            strSql.Append("userHeadimage=@userHeadimage,");
            strSql.Append("atuserName=@atuserName,");
            strSql.Append("atuserHeadimage=@atuserHeadimage,");
            strSql.Append("blogId=@blogId");
            strSql.Append(" where blogId=@blogId ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogPubTime", SqlDbType.DateTime),
					new SqlParameter("@atId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@atuserName", SqlDbType.NVarChar,20),
					new SqlParameter("@atuserHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@blogId", SqlDbType.Int,4)};
            parameters[0].Value = model.blogContent;
            parameters[1].Value = model.blogAuthorId;
            parameters[2].Value = model.blogPubTime;
            parameters[3].Value = model.atId;
            parameters[4].Value = model.userName;
            parameters[5].Value = model.userHeadimage;
            parameters[6].Value = model.atuserName;
            parameters[7].Value = model.atuserHeadimage;
            parameters[8].Value = model.blogId;

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
        public bool Delete(int blogId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from atV ");
            strSql.Append(" where blogId=@blogId ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogId", SqlDbType.Int,4)			};
            parameters[0].Value = blogId;

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
        public bool DeleteList(string blogIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from atV ");
            strSql.Append(" where blogId in (" + blogIdlist + ")  ");
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
        public starweibo.Model.atV GetModel(int blogId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 blogContent,blogAuthorId,blogPubTime,atId,userName,userHeadimage,atuserName,atuserHeadimage,blogId from atV ");
            strSql.Append(" where blogId=@blogId ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogId", SqlDbType.Int,4)			};
            parameters[0].Value = blogId;

            starweibo.Model.atV model = new starweibo.Model.atV();
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
        public starweibo.Model.atV DataRowToModel(DataRow row)
        {
            starweibo.Model.atV model = new starweibo.Model.atV();
            if (row != null)
            {
                if (row["blogContent"] != null)
                {
                    model.blogContent = row["blogContent"].ToString();
                }
                if (row["blogAuthorId"] != null && row["blogAuthorId"].ToString() != "")
                {
                    model.blogAuthorId = int.Parse(row["blogAuthorId"].ToString());
                }
                if (row["blogPubTime"] != null && row["blogPubTime"].ToString() != "")
                {
                    model.blogPubTime = DateTime.Parse(row["blogPubTime"].ToString());
                }
                if (row["atId"] != null && row["atId"].ToString() != "")
                {
                    model.atId = int.Parse(row["atId"].ToString());
                }
                if (row["userName"] != null)
                {
                    model.userName = row["userName"].ToString();
                }
                if (row["userHeadimage"] != null)
                {
                    model.userHeadimage = row["userHeadimage"].ToString();
                }
                if (row["atuserName"] != null)
                {
                    model.atuserName = row["atuserName"].ToString();
                }
                if (row["atuserHeadimage"] != null)
                {
                    model.atuserHeadimage = row["atuserHeadimage"].ToString();
                }
                if (row["blogId"] != null && row["blogId"].ToString() != "")
                {
                    model.blogId = int.Parse(row["blogId"].ToString());
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
            strSql.Append("select blogContent,blogAuthorId,blogPubTime,atId,userName,userHeadimage,atuserName,atuserHeadimage,blogId ");
            strSql.Append(" FROM atV ");
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
            strSql.Append(" blogContent,blogAuthorId,blogPubTime,atId,userName,userHeadimage,atuserName,atuserHeadimage,blogId ");
            strSql.Append(" FROM atV ");
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
            strSql.Append("select count(1) FROM atV ");
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
                strSql.Append("order by T.blogId desc");
            }
            strSql.Append(")AS Row, T.*  from atV T ");
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
            parameters[0].Value = "atV";
            parameters[1].Value = "blogId";
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

