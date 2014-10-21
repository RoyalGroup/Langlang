using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:blogInfo
    /// </summary>
    public partial class blogInfo
    {
        public blogInfo()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int blogId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from blogInfo");
            strSql.Append(" where blogId=@blogId");
            SqlParameter[] parameters = {
					new SqlParameter("@blogId", SqlDbType.Int,4)
			};
            parameters[0].Value = blogId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(starweibo.Model.blogInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into blogInfo(");
            strSql.Append("blogContent,blogAuthorId,blogPubTime,atId,blogState)");
            strSql.Append(" values (");
            strSql.Append("@blogContent,@blogAuthorId,@blogPubTime,@atId,@blogState)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogPubTime", SqlDbType.DateTime),
					new SqlParameter("@atId", SqlDbType.Int,4),
					new SqlParameter("@blogState", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.blogContent;
            parameters[1].Value = model.blogAuthorId;
            parameters[2].Value = model.blogPubTime;
            parameters[3].Value = model.atId;
            parameters[4].Value = model.blogState;

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
        public bool Update(starweibo.Model.blogInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update blogInfo set ");
            strSql.Append("blogContent=@blogContent,");
            strSql.Append("blogAuthorId=@blogAuthorId,");
            strSql.Append("blogPubTime=@blogPubTime,");
            strSql.Append("atId=@atId,");
            strSql.Append("blogState=@blogState");
            strSql.Append(" where blogId=@blogId");
            SqlParameter[] parameters = {
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogPubTime", SqlDbType.DateTime),
					new SqlParameter("@atId", SqlDbType.Int,4),
					new SqlParameter("@blogState", SqlDbType.NVarChar,10),
					new SqlParameter("@blogId", SqlDbType.Int,4)};
            parameters[0].Value = model.blogContent;
            parameters[1].Value = model.blogAuthorId;
            parameters[2].Value = model.blogPubTime;
            parameters[3].Value = model.atId;
            parameters[4].Value = model.blogState;
            parameters[5].Value = model.blogId;

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
            strSql.Append("delete from blogInfo ");
            strSql.Append(" where blogId=@blogId");
            SqlParameter[] parameters = {
					new SqlParameter("@blogId", SqlDbType.Int,4)
			};
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
            strSql.Append("delete from blogInfo ");
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
        public starweibo.Model.blogInfo GetModel(int blogId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 blogId,blogContent,blogAuthorId,blogPubTime,atId,blogState from blogInfo ");
            strSql.Append(" where blogId=@blogId");
            SqlParameter[] parameters = {
					new SqlParameter("@blogId", SqlDbType.Int,4)
			};
            parameters[0].Value = blogId;

            starweibo.Model.blogInfo model = new starweibo.Model.blogInfo();
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
        public starweibo.Model.blogInfo DataRowToModel(DataRow row)
        {
            starweibo.Model.blogInfo model = new starweibo.Model.blogInfo();
            if (row != null)
            {
                if (row["blogId"] != null && row["blogId"].ToString() != "")
                {
                    model.blogId = int.Parse(row["blogId"].ToString());
                }
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
                if (row["blogState"] != null)
                {
                    model.blogState = row["blogState"].ToString();
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
            strSql.Append("select blogId,blogContent,blogAuthorId,blogPubTime,atId,blogState ");
            strSql.Append(" FROM blogInfo ");
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
            strSql.Append(" blogId,blogContent,blogAuthorId,blogPubTime,atId,blogState ");
            strSql.Append(" FROM blogInfo ");
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
            strSql.Append("select count(1) FROM blogInfo ");
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
            strSql.Append(")AS Row, T.*,U.*  from blogInfo T,userInfo U ");
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
            parameters[0].Value = "blogInfo";
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

