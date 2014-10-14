using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:focusV
    /// </summary>
    public partial class focusV
    {
        public focusV()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from focusV");
            strSql.Append(" where userId=@userId and groupName=@groupName and friendId=@friendId and groupId=@groupId and userName=@userName and userHeadimage=@userHeadimage and friendNoteName=@friendNoteName ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20)			};
            parameters[0].Value = userId;
            parameters[1].Value = groupName;
            parameters[2].Value = friendId;
            parameters[3].Value = groupId;
            parameters[4].Value = userName;
            parameters[5].Value = userHeadimage;
            parameters[6].Value = friendNoteName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.focusV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into focusV(");
            strSql.Append("userId,groupName,friendId,groupId,userName,userHeadimage,friendNoteName)");
            strSql.Append(" values (");
            strSql.Append("@userId,@groupName,@friendId,@groupId,@userName,@userHeadimage,@friendNoteName)");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.userId;
            parameters[1].Value = model.groupName;
            parameters[2].Value = model.friendId;
            parameters[3].Value = model.groupId;
            parameters[4].Value = model.userName;
            parameters[5].Value = model.userHeadimage;
            parameters[6].Value = model.friendNoteName;

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
        public bool Update(starweibo.Model.focusV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update focusV set ");
            strSql.Append("userId=@userId,");
            strSql.Append("groupName=@groupName,");
            strSql.Append("friendId=@friendId,");
            strSql.Append("groupId=@groupId,");
            strSql.Append("userName=@userName,");
            strSql.Append("userHeadimage=@userHeadimage,");
            strSql.Append("friendNoteName=@friendNoteName");
            strSql.Append(" where userId=@userId and groupName=@groupName and friendId=@friendId and groupId=@groupId and userName=@userName and userHeadimage=@userHeadimage and friendNoteName=@friendNoteName ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20)};
            parameters[0].Value = model.userId;
            parameters[1].Value = model.groupName;
            parameters[2].Value = model.friendId;
            parameters[3].Value = model.groupId;
            parameters[4].Value = model.userName;
            parameters[5].Value = model.userHeadimage;
            parameters[6].Value = model.friendNoteName;

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
        public bool Delete(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from focusV ");
            strSql.Append(" where userId=@userId and groupName=@groupName and friendId=@friendId and groupId=@groupId and userName=@userName and userHeadimage=@userHeadimage and friendNoteName=@friendNoteName ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20)			};
            parameters[0].Value = userId;
            parameters[1].Value = groupName;
            parameters[2].Value = friendId;
            parameters[3].Value = groupId;
            parameters[4].Value = userName;
            parameters[5].Value = userHeadimage;
            parameters[6].Value = friendNoteName;

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
        public starweibo.Model.focusV GetModel(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 userId,groupName,friendId,groupId,userName,userHeadimage,friendNoteName from focusV ");
            strSql.Append(" where userId=@userId and groupName=@groupName and friendId=@friendId and groupId=@groupId and userName=@userName and userHeadimage=@userHeadimage and friendNoteName=@friendNoteName ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20)			};
            parameters[0].Value = userId;
            parameters[1].Value = groupName;
            parameters[2].Value = friendId;
            parameters[3].Value = groupId;
            parameters[4].Value = userName;
            parameters[5].Value = userHeadimage;
            parameters[6].Value = friendNoteName;

            starweibo.Model.focusV model = new starweibo.Model.focusV();
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
        public starweibo.Model.focusV DataRowToModel(DataRow row)
        {
            starweibo.Model.focusV model = new starweibo.Model.focusV();
            if (row != null)
            {
                if (row["userId"] != null && row["userId"].ToString() != "")
                {
                    model.userId = int.Parse(row["userId"].ToString());
                }
                if (row["groupName"] != null)
                {
                    model.groupName = row["groupName"].ToString();
                }
                if (row["friendId"] != null && row["friendId"].ToString() != "")
                {
                    model.friendId = int.Parse(row["friendId"].ToString());
                }
                if (row["groupId"] != null && row["groupId"].ToString() != "")
                {
                    model.groupId = int.Parse(row["groupId"].ToString());
                }
                if (row["userName"] != null)
                {
                    model.userName = row["userName"].ToString();
                }
                if (row["userHeadimage"] != null)
                {
                    model.userHeadimage = row["userHeadimage"].ToString();
                }
                if (row["friendNoteName"] != null)
                {
                    model.friendNoteName = row["friendNoteName"].ToString();
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
            strSql.Append("select userId,groupName,friendId,groupId,userName,userHeadimage,friendNoteName ");
            strSql.Append(" FROM focusV ");
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
            strSql.Append(" userId,groupName,friendId,groupId,userName,userHeadimage,friendNoteName ");
            strSql.Append(" FROM focusV ");
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
            strSql.Append("select count(1) FROM focusV ");
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
                strSql.Append("order by T.friendNoteName desc");
            }
            strSql.Append(")AS Row, T.*  from focusV T ");
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
            parameters[0].Value = "focusV";
            parameters[1].Value = "friendNoteName";
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

