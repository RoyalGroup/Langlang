using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:zanV
    /// </summary>
    public partial class zanV
    {
        public zanV()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string blogContent, int blogAuthorId, int blogId, int msgTypeId, DateTime pubTime, string userName, string userHeadimage, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from zanV");
            strSql.Append(" where blogContent=@blogContent and blogAuthorId=@blogAuthorId and blogId=@blogId and msgTypeId=@msgTypeId and pubTime=@pubTime and userName=@userName and userHeadimage=@userHeadimage and id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogId", SqlDbType.Int,4),
					new SqlParameter("@msgTypeId", SqlDbType.Int,4),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@id", SqlDbType.Int,4)			};
            parameters[0].Value = blogContent;
            parameters[1].Value = blogAuthorId;
            parameters[2].Value = blogId;
            parameters[3].Value = msgTypeId;
            parameters[4].Value = pubTime;
            parameters[5].Value = userName;
            parameters[6].Value = userHeadimage;
            parameters[7].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.zanV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into zanV(");
            strSql.Append("blogContent,blogAuthorId,blogId,msgTypeId,pubTime,userName,userHeadimage,id)");
            strSql.Append(" values (");
            strSql.Append("@blogContent,@blogAuthorId,@blogId,@msgTypeId,@pubTime,@userName,@userHeadimage,@id)");
            SqlParameter[] parameters = {
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogId", SqlDbType.Int,4),
					new SqlParameter("@msgTypeId", SqlDbType.Int,4),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.blogContent;
            parameters[1].Value = model.blogAuthorId;
            parameters[2].Value = model.blogId;
            parameters[3].Value = model.msgTypeId;
            parameters[4].Value = model.pubTime;
            parameters[5].Value = model.userName;
            parameters[6].Value = model.userHeadimage;
            parameters[7].Value = model.id;

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
        public bool Update(starweibo.Model.zanV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update zanV set ");
            strSql.Append("blogContent=@blogContent,");
            strSql.Append("blogAuthorId=@blogAuthorId,");
            strSql.Append("blogId=@blogId,");
            strSql.Append("msgTypeId=@msgTypeId,");
            strSql.Append("pubTime=@pubTime,");
            strSql.Append("userName=@userName,");
            strSql.Append("userHeadimage=@userHeadimage,");
            strSql.Append("id=@id");
            strSql.Append(" where blogContent=@blogContent and blogAuthorId=@blogAuthorId and blogId=@blogId and msgTypeId=@msgTypeId and pubTime=@pubTime and userName=@userName and userHeadimage=@userHeadimage and id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogId", SqlDbType.Int,4),
					new SqlParameter("@msgTypeId", SqlDbType.Int,4),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.blogContent;
            parameters[1].Value = model.blogAuthorId;
            parameters[2].Value = model.blogId;
            parameters[3].Value = model.msgTypeId;
            parameters[4].Value = model.pubTime;
            parameters[5].Value = model.userName;
            parameters[6].Value = model.userHeadimage;
            parameters[7].Value = model.id;

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
        public bool Delete(string blogContent, int blogAuthorId, int blogId, int msgTypeId, DateTime pubTime, string userName, string userHeadimage, int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from zanV ");
            strSql.Append(" where blogContent=@blogContent and blogAuthorId=@blogAuthorId and blogId=@blogId and msgTypeId=@msgTypeId and pubTime=@pubTime and userName=@userName and userHeadimage=@userHeadimage and id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogId", SqlDbType.Int,4),
					new SqlParameter("@msgTypeId", SqlDbType.Int,4),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@id", SqlDbType.Int,4)			};
            parameters[0].Value = blogContent;
            parameters[1].Value = blogAuthorId;
            parameters[2].Value = blogId;
            parameters[3].Value = msgTypeId;
            parameters[4].Value = pubTime;
            parameters[5].Value = userName;
            parameters[6].Value = userHeadimage;
            parameters[7].Value = id;

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
        /// 得到一个对象实体
        /// </summary>
        public starweibo.Model.zanV GetModel(string blogContent, int blogAuthorId, int blogId, int msgTypeId, DateTime pubTime, string userName, string userHeadimage, int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 blogContent,blogAuthorId,blogId,msgTypeId,pubTime,userName,userHeadimage,id from zanV ");
            strSql.Append(" where blogContent=@blogContent and blogAuthorId=@blogAuthorId and blogId=@blogId and msgTypeId=@msgTypeId and pubTime=@pubTime and userName=@userName and userHeadimage=@userHeadimage and id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogId", SqlDbType.Int,4),
					new SqlParameter("@msgTypeId", SqlDbType.Int,4),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@id", SqlDbType.Int,4)			};
            parameters[0].Value = blogContent;
            parameters[1].Value = blogAuthorId;
            parameters[2].Value = blogId;
            parameters[3].Value = msgTypeId;
            parameters[4].Value = pubTime;
            parameters[5].Value = userName;
            parameters[6].Value = userHeadimage;
            parameters[7].Value = id;

            starweibo.Model.zanV model = new starweibo.Model.zanV();
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
        public starweibo.Model.zanV DataRowToModel(DataRow row)
        {
            starweibo.Model.zanV model = new starweibo.Model.zanV();
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
                if (row["blogId"] != null && row["blogId"].ToString() != "")
                {
                    model.blogId = int.Parse(row["blogId"].ToString());
                }
                if (row["msgTypeId"] != null && row["msgTypeId"].ToString() != "")
                {
                    model.msgTypeId = int.Parse(row["msgTypeId"].ToString());
                }
                if (row["pubTime"] != null && row["pubTime"].ToString() != "")
                {
                    model.pubTime = DateTime.Parse(row["pubTime"].ToString());
                }
                if (row["userName"] != null)
                {
                    model.userName = row["userName"].ToString();
                }
                if (row["userHeadimage"] != null)
                {
                    model.userHeadimage = row["userHeadimage"].ToString();
                }
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
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
            strSql.Append("select blogContent,blogAuthorId,blogId,msgTypeId,pubTime,userName,userHeadimage,id ");
            strSql.Append(" FROM zanV ");
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
            strSql.Append(" blogContent,blogAuthorId,blogId,msgTypeId,pubTime,userName,userHeadimage,id ");
            strSql.Append(" FROM zanV ");
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
            strSql.Append("select count(1) FROM zanV ");
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
            strSql.Append(")AS Row, T.*  from zanV T ");
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
            parameters[0].Value = "zanV";
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

