using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:userInfo
    /// </summary>
    public partial class userInfo
    {
        public userInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("id", "userInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from userInfo");
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
        public int Add(starweibo.Model.userInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into userInfo(");
            strSql.Append("userName,userPwd,userMail,userHeadimage,userSex,userBirthday,registTime,lastLoginTime,userAddress,userEdu,userTell,QQnumber,userDes,userMarry,userCss,yanzhengma,jihuostate)");
            strSql.Append(" values (");
            strSql.Append("@userName,@userPwd,@userMail,@userHeadimage,@userSex,@userBirthday,@registTime,@lastLoginTime,@userAddress,@userEdu,@userTell,@QQnumber,@userDes,@userMarry,@userCss,@yanzhengma,@jihuostate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userPwd", SqlDbType.VarChar,20),
					new SqlParameter("@userMail", SqlDbType.VarChar,50),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@userSex", SqlDbType.NChar,1),
					new SqlParameter("@userBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@registTime", SqlDbType.Date,3),
					new SqlParameter("@lastLoginTime", SqlDbType.DateTime),
					new SqlParameter("@userAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@userEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@userTell", SqlDbType.NChar,11),
					new SqlParameter("@QQnumber", SqlDbType.VarChar,20),
					new SqlParameter("@userDes", SqlDbType.NVarChar,150),
					new SqlParameter("@userMarry", SqlDbType.NVarChar,10),
					new SqlParameter("@userCss", SqlDbType.VarChar,300),
					new SqlParameter("@yanzhengma", SqlDbType.Char,6),
					new SqlParameter("@jihuostate", SqlDbType.Char,1)};
            parameters[0].Value = model.userName;
            parameters[1].Value = model.userPwd;
            parameters[2].Value = model.userMail;
            parameters[3].Value = model.userHeadimage;
            parameters[4].Value = model.userSex;
            parameters[5].Value = model.userBirthday;
            parameters[6].Value = model.registTime;
            parameters[7].Value = model.lastLoginTime;
            parameters[8].Value = model.userAddress;
            parameters[9].Value = model.userEdu;
            parameters[10].Value = model.userTell;
            parameters[11].Value = model.QQnumber;
            parameters[12].Value = model.userDes;
            parameters[13].Value = model.userMarry;
            parameters[14].Value = model.userCss;
            parameters[15].Value = model.yanzhengma;
            parameters[16].Value = model.jihuostate;

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
        public bool Update(starweibo.Model.userInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update userInfo set ");
            strSql.Append("userName=@userName,");
            strSql.Append("userPwd=@userPwd,");
            strSql.Append("userMail=@userMail,");
            strSql.Append("userHeadimage=@userHeadimage,");
            strSql.Append("userSex=@userSex,");
            strSql.Append("userBirthday=@userBirthday,");
            strSql.Append("registTime=@registTime,");
            strSql.Append("lastLoginTime=@lastLoginTime,");
            strSql.Append("userAddress=@userAddress,");
            strSql.Append("userEdu=@userEdu,");
            strSql.Append("userTell=@userTell,");
            strSql.Append("QQnumber=@QQnumber,");
            strSql.Append("userDes=@userDes,");
            strSql.Append("userMarry=@userMarry,");
            strSql.Append("userCss=@userCss,");
            strSql.Append("yanzhengma=@yanzhengma,");
            strSql.Append("jihuostate=@jihuostate");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userPwd", SqlDbType.VarChar,20),
					new SqlParameter("@userMail", SqlDbType.VarChar,50),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@userSex", SqlDbType.NChar,1),
					new SqlParameter("@userBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@registTime", SqlDbType.Date,3),
					new SqlParameter("@lastLoginTime", SqlDbType.DateTime),
					new SqlParameter("@userAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@userEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@userTell", SqlDbType.NChar,11),
					new SqlParameter("@QQnumber", SqlDbType.VarChar,20),
					new SqlParameter("@userDes", SqlDbType.NVarChar,150),
					new SqlParameter("@userMarry", SqlDbType.NVarChar,10),
					new SqlParameter("@userCss", SqlDbType.VarChar,300),
					new SqlParameter("@yanzhengma", SqlDbType.Char,6),
					new SqlParameter("@jihuostate", SqlDbType.Char,1),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.userName;
            parameters[1].Value = model.userPwd;
            parameters[2].Value = model.userMail;
            parameters[3].Value = model.userHeadimage;
            parameters[4].Value = model.userSex;
            parameters[5].Value = model.userBirthday;
            parameters[6].Value = model.registTime;
            parameters[7].Value = model.lastLoginTime;
            parameters[8].Value = model.userAddress;
            parameters[9].Value = model.userEdu;
            parameters[10].Value = model.userTell;
            parameters[11].Value = model.QQnumber;
            parameters[12].Value = model.userDes;
            parameters[13].Value = model.userMarry;
            parameters[14].Value = model.userCss;
            parameters[15].Value = model.yanzhengma;
            parameters[16].Value = model.jihuostate;
            parameters[17].Value = model.id;

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
            strSql.Append("delete from userInfo ");
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
            strSql.Append("delete from userInfo ");
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
        public starweibo.Model.userInfo GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,userName,userPwd,userMail,userHeadimage,userSex,userBirthday,registTime,lastLoginTime,userAddress,userEdu,userTell,QQnumber,userDes,userMarry,userCss,yanzhengma,jihuostate from userInfo ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            starweibo.Model.userInfo model = new starweibo.Model.userInfo();
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
        public starweibo.Model.userInfo DataRowToModel(DataRow row)
        {
            starweibo.Model.userInfo model = new starweibo.Model.userInfo();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["userName"] != null)
                {
                    model.userName = row["userName"].ToString();
                }
                if (row["userPwd"] != null)
                {
                    model.userPwd = row["userPwd"].ToString();
                }
                if (row["userMail"] != null)
                {
                    model.userMail = row["userMail"].ToString();
                }
                if (row["userHeadimage"] != null)
                {
                    model.userHeadimage = row["userHeadimage"].ToString();
                }
                if (row["userSex"] != null)
                {
                    model.userSex = row["userSex"].ToString();
                }
                if (row["userBirthday"] != null)
                {
                    model.userBirthday = row["userBirthday"].ToString();
                }
                if (row["registTime"] != null && row["registTime"].ToString() != "")
                {
                    model.registTime = DateTime.Parse(row["registTime"].ToString());
                }
                if (row["lastLoginTime"] != null && row["lastLoginTime"].ToString() != "")
                {
                    model.lastLoginTime = DateTime.Parse(row["lastLoginTime"].ToString());
                }
                if (row["userAddress"] != null)
                {
                    model.userAddress = row["userAddress"].ToString();
                }
                if (row["userEdu"] != null)
                {
                    model.userEdu = row["userEdu"].ToString();
                }
                if (row["userTell"] != null)
                {
                    model.userTell = row["userTell"].ToString();
                }
                if (row["QQnumber"] != null)
                {
                    model.QQnumber = row["QQnumber"].ToString();
                }
                if (row["userDes"] != null)
                {
                    model.userDes = row["userDes"].ToString();
                }
                if (row["userMarry"] != null)
                {
                    model.userMarry = row["userMarry"].ToString();
                }
                if (row["userCss"] != null)
                {
                    model.userCss = row["userCss"].ToString();
                }
                if (row["yanzhengma"] != null)
                {
                    model.yanzhengma = row["yanzhengma"].ToString();
                }
                if (row["jihuostate"] != null)
                {
                    model.jihuostate = row["jihuostate"].ToString();
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
            strSql.Append("select id,userName,userPwd,userMail,userHeadimage,userSex,userBirthday,registTime,lastLoginTime,userAddress,userEdu,userTell,QQnumber,userDes,userMarry,userCss,yanzhengma,jihuostate ");
            strSql.Append(" FROM userInfo ");
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
            strSql.Append(" id,userName,userPwd,userMail,userHeadimage,userSex,userBirthday,registTime,lastLoginTime,userAddress,userEdu,userTell,QQnumber,userDes,userMarry,userCss,yanzhengma,jihuostate ");
            strSql.Append(" FROM userInfo ");
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
            strSql.Append("select count(1) FROM userInfo ");
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
            strSql.Append(")AS Row, T.*  from userInfo T ");
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
            parameters[0].Value = "userInfo";
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

