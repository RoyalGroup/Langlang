﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:replyV
    /// </summary>
    public partial class replyV
    {
        public replyV()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int messageId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from replyV");
            strSql.Append(" where messageId=@messageId ");
            SqlParameter[] parameters = {
					new SqlParameter("@messageId", SqlDbType.Int,4)			};
            parameters[0].Value = messageId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.replyV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into replyV(");
            strSql.Append("blogId,msgContent,msgTypeId,pubTime,userId,msgState,blogContent,blogAuthorId,userName,userHeadimage,messageId)");
            strSql.Append(" values (");
            strSql.Append("@blogId,@msgContent,@msgTypeId,@pubTime,@userId,@msgState,@blogContent,@blogAuthorId,@userName,@userHeadimage,@messageId)");
            SqlParameter[] parameters = {
					new SqlParameter("@blogId", SqlDbType.Int,4),
					new SqlParameter("@msgContent", SqlDbType.NVarChar,250),
					new SqlParameter("@msgTypeId", SqlDbType.Int,4),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@msgState", SqlDbType.NVarChar,10),
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@messageId", SqlDbType.Int,4)};
            parameters[0].Value = model.blogId;
            parameters[1].Value = model.msgContent;
            parameters[2].Value = model.msgTypeId;
            parameters[3].Value = model.pubTime;
            parameters[4].Value = model.userId;
            parameters[5].Value = model.msgState;
            parameters[6].Value = model.blogContent;
            parameters[7].Value = model.blogAuthorId;
            parameters[8].Value = model.userName;
            parameters[9].Value = model.userHeadimage;
            parameters[10].Value = model.messageId;

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
        public bool Update(starweibo.Model.replyV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update replyV set ");
            strSql.Append("blogId=@blogId,");
            strSql.Append("msgContent=@msgContent,");
            strSql.Append("msgTypeId=@msgTypeId,");
            strSql.Append("pubTime=@pubTime,");
            strSql.Append("userId=@userId,");
            strSql.Append("msgState=@msgState,");
            strSql.Append("blogContent=@blogContent,");
            strSql.Append("blogAuthorId=@blogAuthorId,");
            strSql.Append("userName=@userName,");
            strSql.Append("userHeadimage=@userHeadimage,");
            strSql.Append("messageId=@messageId");
            strSql.Append(" where messageId=@messageId ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogId", SqlDbType.Int,4),
					new SqlParameter("@msgContent", SqlDbType.NVarChar,250),
					new SqlParameter("@msgTypeId", SqlDbType.Int,4),
					new SqlParameter("@pubTime", SqlDbType.DateTime),
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@msgState", SqlDbType.NVarChar,10),
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@messageId", SqlDbType.Int,4)};
            parameters[0].Value = model.blogId;
            parameters[1].Value = model.msgContent;
            parameters[2].Value = model.msgTypeId;
            parameters[3].Value = model.pubTime;
            parameters[4].Value = model.userId;
            parameters[5].Value = model.msgState;
            parameters[6].Value = model.blogContent;
            parameters[7].Value = model.blogAuthorId;
            parameters[8].Value = model.userName;
            parameters[9].Value = model.userHeadimage;
            parameters[10].Value = model.messageId;

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
        public bool Delete(int messageId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from replyV ");
            strSql.Append(" where messageId=@messageId ");
            SqlParameter[] parameters = {
					new SqlParameter("@messageId", SqlDbType.Int,4)			};
            parameters[0].Value = messageId;

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
        public bool DeleteList(string messageIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from replyV ");
            strSql.Append(" where messageId in (" + messageIdlist + ")  ");
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
        public starweibo.Model.replyV GetModel(int messageId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 blogId,msgContent,msgTypeId,pubTime,userId,msgState,blogContent,blogAuthorId,userName,userHeadimage,messageId from replyV ");
            strSql.Append(" where messageId=@messageId ");
            SqlParameter[] parameters = {
					new SqlParameter("@messageId", SqlDbType.Int,4)			};
            parameters[0].Value = messageId;

            starweibo.Model.replyV model = new starweibo.Model.replyV();
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
        public starweibo.Model.replyV DataRowToModel(DataRow row)
        {
            starweibo.Model.replyV model = new starweibo.Model.replyV();
            if (row != null)
            {
                if (row["blogId"] != null && row["blogId"].ToString() != "")
                {
                    model.blogId = int.Parse(row["blogId"].ToString());
                }
                if (row["msgContent"] != null)
                {
                    model.msgContent = row["msgContent"].ToString();
                }
                if (row["msgTypeId"] != null && row["msgTypeId"].ToString() != "")
                {
                    model.msgTypeId = int.Parse(row["msgTypeId"].ToString());
                }
                if (row["pubTime"] != null && row["pubTime"].ToString() != "")
                {
                    model.pubTime = DateTime.Parse(row["pubTime"].ToString());
                }
                if (row["userId"] != null && row["userId"].ToString() != "")
                {
                    model.userId = int.Parse(row["userId"].ToString());
                }
                if (row["msgState"] != null)
                {
                    model.msgState = row["msgState"].ToString();
                }
                if (row["blogContent"] != null)
                {
                    model.blogContent = row["blogContent"].ToString();
                }
                if (row["blogAuthorId"] != null && row["blogAuthorId"].ToString() != "")
                {
                    model.blogAuthorId = int.Parse(row["blogAuthorId"].ToString());
                }
                if (row["userName"] != null)
                {
                    model.userName = row["userName"].ToString();
                }
                if (row["userHeadimage"] != null)
                {
                    model.userHeadimage = row["userHeadimage"].ToString();
                }
                if (row["messageId"] != null && row["messageId"].ToString() != "")
                {
                    model.messageId = int.Parse(row["messageId"].ToString());
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
            strSql.Append("select blogId,msgContent,msgTypeId,pubTime,userId,msgState,blogContent,blogAuthorId,userName,userHeadimage,messageId ");
            strSql.Append(" FROM replyV ");
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
            strSql.Append(" blogId,msgContent,msgTypeId,pubTime,userId,msgState,blogContent,blogAuthorId,userName,userHeadimage,messageId ");
            strSql.Append(" FROM replyV ");
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
            strSql.Append("select count(1) FROM replyV ");
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
                strSql.Append("order by T.messageId desc");
            }
            strSql.Append(")AS Row, T.*  from replyV T ");
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
            parameters[0].Value = "replyV";
            parameters[1].Value = "messageId";
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

