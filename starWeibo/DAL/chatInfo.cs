using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:chatInfo
    /// </summary>
    public partial class chatInfo
    {
        public chatInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("shortMsgId", "chatInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int shortMsgId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from chatInfo");
            strSql.Append(" where shortMsgId=@shortMsgId");
            SqlParameter[] parameters = {
					new SqlParameter("@shortMsgId", SqlDbType.Int,4)
			};
            parameters[0].Value = shortMsgId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(starweibo.Model.chatInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into chatInfo(");
            strSql.Append("senderId,receiverId,msgState,msgContent,pubTime)");
            strSql.Append(" values (");
            strSql.Append("@senderId,@receiverId,@msgState,@msgContent,@pubTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@senderId", SqlDbType.Int,4),
					new SqlParameter("@receiverId", SqlDbType.Int,4),
					new SqlParameter("@msgState", SqlDbType.NVarChar,50),
					new SqlParameter("@msgContent", SqlDbType.NVarChar,200),
					new SqlParameter("@pubTime", SqlDbType.DateTime)};
            parameters[0].Value = model.senderId;
            parameters[1].Value = model.receiverId;
            parameters[2].Value = model.msgState;
            parameters[3].Value = model.msgContent;
            parameters[4].Value = model.pubTime;

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
        public bool Update(starweibo.Model.chatInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update chatInfo set ");
            strSql.Append("senderId=@senderId,");
            strSql.Append("receiverId=@receiverId,");
            strSql.Append("msgState=@msgState,");
            strSql.Append("msgContent=@msgContent,");
            strSql.Append("pubTime=@pubTime");
            strSql.Append(" where shortMsgId=@shortMsgId");
            SqlParameter[] parameters = {
					new SqlParameter("@senderId", SqlDbType.Int,4),
					new SqlParameter("@receiverId", SqlDbType.Int,4),
					new SqlParameter("@msgState", SqlDbType.NVarChar,50),
					new SqlParameter("@msgContent", SqlDbType.NVarChar,200),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@shortMsgId", SqlDbType.Int,4)};
            parameters[0].Value = model.senderId;
            parameters[1].Value = model.receiverId;
            parameters[2].Value = model.msgState;
            parameters[3].Value = model.msgContent;
            parameters[4].Value = model.pubTime;
            parameters[5].Value = model.shortMsgId;

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
        public bool Delete(int shortMsgId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from chatInfo ");
            strSql.Append(" where shortMsgId=@shortMsgId");
            SqlParameter[] parameters = {
					new SqlParameter("@shortMsgId", SqlDbType.Int,4)
			};
            parameters[0].Value = shortMsgId;

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
        public bool DeleteList(string shortMsgIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from chatInfo ");
            strSql.Append(" where shortMsgId in (" + shortMsgIdlist + ")  ");
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
        public starweibo.Model.chatInfo GetModel(int shortMsgId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 shortMsgId,senderId,receiverId,msgState,msgContent,pubTime from chatInfo ");
            strSql.Append(" where shortMsgId=@shortMsgId");
            SqlParameter[] parameters = {
					new SqlParameter("@shortMsgId", SqlDbType.Int,4)
			};
            parameters[0].Value = shortMsgId;

            starweibo.Model.chatInfo model = new starweibo.Model.chatInfo();
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
        public starweibo.Model.chatInfo DataRowToModel(DataRow row)
        {
            starweibo.Model.chatInfo model = new starweibo.Model.chatInfo();
            if (row != null)
            {
                if (row["shortMsgId"] != null && row["shortMsgId"].ToString() != "")
                {
                    model.shortMsgId = int.Parse(row["shortMsgId"].ToString());
                }
                if (row["senderId"] != null && row["senderId"].ToString() != "")
                {
                    model.senderId = int.Parse(row["senderId"].ToString());
                }
                if (row["receiverId"] != null && row["receiverId"].ToString() != "")
                {
                    model.receiverId = int.Parse(row["receiverId"].ToString());
                }
                if (row["msgState"] != null)
                {
                    model.msgState = row["msgState"].ToString();
                }
                if (row["msgContent"] != null)
                {
                    model.msgContent = row["msgContent"].ToString();
                }
                if (row["pubTime"] != null && row["pubTime"].ToString() != "")
                {
                    model.pubTime = DateTime.Parse(row["pubTime"].ToString());
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
            strSql.Append("select shortMsgId,senderId,receiverId,msgState,msgContent,pubTime ");
            strSql.Append(" FROM chatInfo ");
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
            strSql.Append(" shortMsgId,senderId,receiverId,msgState,msgContent,pubTime ");
            strSql.Append(" FROM chatInfo ");
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
            strSql.Append("select count(1) FROM chatInfo ");
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
                strSql.Append("order by T.shortMsgId desc");
            }
            strSql.Append(")AS Row, T.*  from chatInfo T ");
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
            parameters[0].Value = "chatInfo";
            parameters[1].Value = "shortMsgId";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// my更新一条数据
        /// </summary>
        public bool myUpdate(string state, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update chatV set msgState='" + state + "' where shortMsgId=" + strWhere);

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
        #endregion  ExtensionMethod
    }
}

