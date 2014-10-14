using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:chatV
    /// </summary>
    public partial class chatV
    {
        public chatV()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int senderId, string msgContent, DateTime pubTime, string msgState, int receiverId, string userName, string userHeadimage, string recuserName, string recuserHeadimage)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from chatV");
            strSql.Append(" where senderId=@senderId and msgContent=@msgContent and pubTime=@pubTime and msgState=@msgState and receiverId=@receiverId and userName=@userName and userHeadimage=@userHeadimage and recuserName=@recuserName and recuserHeadimage=@recuserHeadimage ");
            SqlParameter[] parameters = {
					new SqlParameter("@senderId", SqlDbType.Int,4),
					new SqlParameter("@msgContent", SqlDbType.NVarChar,200),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@msgState", SqlDbType.NVarChar,50),
					new SqlParameter("@receiverId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@recuserName", SqlDbType.NVarChar,20),
					new SqlParameter("@recuserHeadimage", SqlDbType.NVarChar,150)			};
            parameters[0].Value = senderId;
            parameters[1].Value = msgContent;
            parameters[2].Value = pubTime;
            parameters[3].Value = msgState;
            parameters[4].Value = receiverId;
            parameters[5].Value = userName;
            parameters[6].Value = userHeadimage;
            parameters[7].Value = recuserName;
            parameters[8].Value = recuserHeadimage;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.chatV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into chatV(");
            strSql.Append("senderId,msgContent,pubTime,msgState,receiverId,userName,userHeadimage,recuserName,recuserHeadimage)");
            strSql.Append(" values (");
            strSql.Append("@senderId,@msgContent,@pubTime,@msgState,@receiverId,@userName,@userHeadimage,@recuserName,@recuserHeadimage)");
            SqlParameter[] parameters = {
					new SqlParameter("@senderId", SqlDbType.Int,4),
					new SqlParameter("@msgContent", SqlDbType.NVarChar,200),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@msgState", SqlDbType.NVarChar,50),
					new SqlParameter("@receiverId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@recuserName", SqlDbType.NVarChar,20),
					new SqlParameter("@recuserHeadimage", SqlDbType.NVarChar,150)};
            parameters[0].Value = model.senderId;
            parameters[1].Value = model.msgContent;
            parameters[2].Value = model.pubTime;
            parameters[3].Value = model.msgState;
            parameters[4].Value = model.receiverId;
            parameters[5].Value = model.userName;
            parameters[6].Value = model.userHeadimage;
            parameters[7].Value = model.recuserName;
            parameters[8].Value = model.recuserHeadimage;

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
        public bool Update(starweibo.Model.chatV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update chatV set ");
            strSql.Append("senderId=@senderId,");
            strSql.Append("msgContent=@msgContent,");
            strSql.Append("pubTime=@pubTime,");
            strSql.Append("msgState=@msgState,");
            strSql.Append("receiverId=@receiverId,");
            strSql.Append("userName=@userName,");
            strSql.Append("userHeadimage=@userHeadimage,");
            strSql.Append("recuserName=@recuserName,");
            strSql.Append("recuserHeadimage=@recuserHeadimage");
            strSql.Append(" where senderId=@senderId and msgContent=@msgContent and pubTime=@pubTime and msgState=@msgState and receiverId=@receiverId and userName=@userName and userHeadimage=@userHeadimage and recuserName=@recuserName and recuserHeadimage=@recuserHeadimage ");
            SqlParameter[] parameters = {
					new SqlParameter("@senderId", SqlDbType.Int,4),
					new SqlParameter("@msgContent", SqlDbType.NVarChar,200),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@msgState", SqlDbType.NVarChar,50),
					new SqlParameter("@receiverId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@recuserName", SqlDbType.NVarChar,20),
					new SqlParameter("@recuserHeadimage", SqlDbType.NVarChar,150)};
            parameters[0].Value = model.senderId;
            parameters[1].Value = model.msgContent;
            parameters[2].Value = model.pubTime;
            parameters[3].Value = model.msgState;
            parameters[4].Value = model.receiverId;
            parameters[5].Value = model.userName;
            parameters[6].Value = model.userHeadimage;
            parameters[7].Value = model.recuserName;
            parameters[8].Value = model.recuserHeadimage;

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
        public bool Delete(int senderId, string msgContent, DateTime pubTime, string msgState, int receiverId, string userName, string userHeadimage, string recuserName, string recuserHeadimage)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from chatV ");
            strSql.Append(" where senderId=@senderId and msgContent=@msgContent and pubTime=@pubTime and msgState=@msgState and receiverId=@receiverId and userName=@userName and userHeadimage=@userHeadimage and recuserName=@recuserName and recuserHeadimage=@recuserHeadimage ");
            SqlParameter[] parameters = {
					new SqlParameter("@senderId", SqlDbType.Int,4),
					new SqlParameter("@msgContent", SqlDbType.NVarChar,200),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@msgState", SqlDbType.NVarChar,50),
					new SqlParameter("@receiverId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@recuserName", SqlDbType.NVarChar,20),
					new SqlParameter("@recuserHeadimage", SqlDbType.NVarChar,150)			};
            parameters[0].Value = senderId;
            parameters[1].Value = msgContent;
            parameters[2].Value = pubTime;
            parameters[3].Value = msgState;
            parameters[4].Value = receiverId;
            parameters[5].Value = userName;
            parameters[6].Value = userHeadimage;
            parameters[7].Value = recuserName;
            parameters[8].Value = recuserHeadimage;

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
        public starweibo.Model.chatV GetModel(int senderId, string msgContent, DateTime pubTime, string msgState, int receiverId, string userName, string userHeadimage, string recuserName, string recuserHeadimage)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 senderId,msgContent,pubTime,msgState,receiverId,userName,userHeadimage,recuserName,recuserHeadimage from chatV ");
            strSql.Append(" where senderId=@senderId and msgContent=@msgContent and pubTime=@pubTime and msgState=@msgState and receiverId=@receiverId and userName=@userName and userHeadimage=@userHeadimage and recuserName=@recuserName and recuserHeadimage=@recuserHeadimage ");
            SqlParameter[] parameters = {
					new SqlParameter("@senderId", SqlDbType.Int,4),
					new SqlParameter("@msgContent", SqlDbType.NVarChar,200),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@msgState", SqlDbType.NVarChar,50),
					new SqlParameter("@receiverId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@recuserName", SqlDbType.NVarChar,20),
					new SqlParameter("@recuserHeadimage", SqlDbType.NVarChar,150)			};
            parameters[0].Value = senderId;
            parameters[1].Value = msgContent;
            parameters[2].Value = pubTime;
            parameters[3].Value = msgState;
            parameters[4].Value = receiverId;
            parameters[5].Value = userName;
            parameters[6].Value = userHeadimage;
            parameters[7].Value = recuserName;
            parameters[8].Value = recuserHeadimage;

            starweibo.Model.chatV model = new starweibo.Model.chatV();
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
        public starweibo.Model.chatV DataRowToModel(DataRow row)
        {
            starweibo.Model.chatV model = new starweibo.Model.chatV();
            if (row != null)
            {
                if (row["senderId"] != null && row["senderId"].ToString() != "")
                {
                    model.senderId = int.Parse(row["senderId"].ToString());
                }
                if (row["msgContent"] != null)
                {
                    model.msgContent = row["msgContent"].ToString();
                }
                if (row["pubTime"] != null && row["pubTime"].ToString() != "")
                {
                    model.pubTime = DateTime.Parse(row["pubTime"].ToString());
                }
                if (row["msgState"] != null)
                {
                    model.msgState = row["msgState"].ToString();
                }
                if (row["receiverId"] != null && row["receiverId"].ToString() != "")
                {
                    model.receiverId = int.Parse(row["receiverId"].ToString());
                }
                if (row["userName"] != null)
                {
                    model.userName = row["userName"].ToString();
                }
                if (row["userHeadimage"] != null)
                {
                    model.userHeadimage = row["userHeadimage"].ToString();
                }
                if (row["recuserName"] != null)
                {
                    model.recuserName = row["recuserName"].ToString();
                }
                if (row["recuserHeadimage"] != null)
                {
                    model.recuserHeadimage = row["recuserHeadimage"].ToString();
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
            strSql.Append("select senderId,msgContent,pubTime,msgState,receiverId,userName,userHeadimage,recuserName,recuserHeadimage ");
            strSql.Append(" FROM chatV ");
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
            strSql.Append(" senderId,msgContent,pubTime,msgState,receiverId,userName,userHeadimage,recuserName,recuserHeadimage ");
            strSql.Append(" FROM chatV ");
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
            strSql.Append("select count(1) FROM chatV ");
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
                strSql.Append("order by T.recuserHeadimage desc");
            }
            strSql.Append(")AS Row, T.*  from chatV T ");
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
            parameters[0].Value = "chatV";
            parameters[1].Value = "recuserHeadimage";
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

