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
        public bool Exists(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName, string userAddress, string userBirthday, string userMail, string userSex, string userEdu, string userDes, string QQnumber, string userTell, string userMarry, string fansName, string fansMail, string fansHeadimage, string fansSex, string fansBirthday, string fansAddress, string fansEdu, string fansTell, string fansQQ, string fansDes, string fansMarry)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from focusV");
            strSql.Append(" where userId=@userId and groupName=@groupName and friendId=@friendId and groupId=@groupId and userName=@userName and userHeadimage=@userHeadimage and friendNoteName=@friendNoteName and userAddress=@userAddress and userBirthday=@userBirthday and userMail=@userMail and userSex=@userSex and userEdu=@userEdu and userDes=@userDes and QQnumber=@QQnumber and userTell=@userTell and userMarry=@userMarry and fansName=@fansName and fansMail=@fansMail and fansHeadimage=@fansHeadimage and fansSex=@fansSex and fansBirthday=@fansBirthday and fansAddress=@fansAddress and fansEdu=@fansEdu and fansTell=@fansTell and fansQQ=@fansQQ and fansDes=@fansDes and fansMarry=@fansMarry ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20),
					new SqlParameter("@userAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@userBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@userMail", SqlDbType.VarChar,50),
					new SqlParameter("@userSex", SqlDbType.NChar,1),
					new SqlParameter("@userEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@userDes", SqlDbType.NVarChar,150),
					new SqlParameter("@QQnumber", SqlDbType.VarChar,20),
					new SqlParameter("@userTell", SqlDbType.NChar,11),
					new SqlParameter("@userMarry", SqlDbType.NVarChar,10),
					new SqlParameter("@fansName", SqlDbType.NVarChar,20),
					new SqlParameter("@fansMail", SqlDbType.VarChar,50),
					new SqlParameter("@fansHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@fansSex", SqlDbType.NChar,1),
					new SqlParameter("@fansBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@fansAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@fansEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@fansTell", SqlDbType.NChar,11),
					new SqlParameter("@fansQQ", SqlDbType.VarChar,20),
					new SqlParameter("@fansDes", SqlDbType.NVarChar,150),
					new SqlParameter("@fansMarry", SqlDbType.NVarChar,10)			};
            parameters[0].Value = userId;
            parameters[1].Value = groupName;
            parameters[2].Value = friendId;
            parameters[3].Value = groupId;
            parameters[4].Value = userName;
            parameters[5].Value = userHeadimage;
            parameters[6].Value = friendNoteName;
            parameters[7].Value = userAddress;
            parameters[8].Value = userBirthday;
            parameters[9].Value = userMail;
            parameters[10].Value = userSex;
            parameters[11].Value = userEdu;
            parameters[12].Value = userDes;
            parameters[13].Value = QQnumber;
            parameters[14].Value = userTell;
            parameters[15].Value = userMarry;
            parameters[16].Value = fansName;
            parameters[17].Value = fansMail;
            parameters[18].Value = fansHeadimage;
            parameters[19].Value = fansSex;
            parameters[20].Value = fansBirthday;
            parameters[21].Value = fansAddress;
            parameters[22].Value = fansEdu;
            parameters[23].Value = fansTell;
            parameters[24].Value = fansQQ;
            parameters[25].Value = fansDes;
            parameters[26].Value = fansMarry;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.focusV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into focusV(");
            strSql.Append("userId,groupName,friendId,groupId,userName,userHeadimage,friendNoteName,userAddress,userBirthday,userMail,userSex,userEdu,userDes,QQnumber,userTell,userMarry,fansName,fansMail,fansHeadimage,fansSex,fansBirthday,fansAddress,fansEdu,fansTell,fansQQ,fansDes,fansMarry)");
            strSql.Append(" values (");
            strSql.Append("@userId,@groupName,@friendId,@groupId,@userName,@userHeadimage,@friendNoteName,@userAddress,@userBirthday,@userMail,@userSex,@userEdu,@userDes,@QQnumber,@userTell,@userMarry,@fansName,@fansMail,@fansHeadimage,@fansSex,@fansBirthday,@fansAddress,@fansEdu,@fansTell,@fansQQ,@fansDes,@fansMarry)");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20),
					new SqlParameter("@userAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@userBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@userMail", SqlDbType.VarChar,50),
					new SqlParameter("@userSex", SqlDbType.NChar,1),
					new SqlParameter("@userEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@userDes", SqlDbType.NVarChar,150),
					new SqlParameter("@QQnumber", SqlDbType.VarChar,20),
					new SqlParameter("@userTell", SqlDbType.NChar,11),
					new SqlParameter("@userMarry", SqlDbType.NVarChar,10),
					new SqlParameter("@fansName", SqlDbType.NVarChar,20),
					new SqlParameter("@fansMail", SqlDbType.VarChar,50),
					new SqlParameter("@fansHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@fansSex", SqlDbType.NChar,1),
					new SqlParameter("@fansBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@fansAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@fansEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@fansTell", SqlDbType.NChar,11),
					new SqlParameter("@fansQQ", SqlDbType.VarChar,20),
					new SqlParameter("@fansDes", SqlDbType.NVarChar,150),
					new SqlParameter("@fansMarry", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.userId;
            parameters[1].Value = model.groupName;
            parameters[2].Value = model.friendId;
            parameters[3].Value = model.groupId;
            parameters[4].Value = model.userName;
            parameters[5].Value = model.userHeadimage;
            parameters[6].Value = model.friendNoteName;
            parameters[7].Value = model.userAddress;
            parameters[8].Value = model.userBirthday;
            parameters[9].Value = model.userMail;
            parameters[10].Value = model.userSex;
            parameters[11].Value = model.userEdu;
            parameters[12].Value = model.userDes;
            parameters[13].Value = model.QQnumber;
            parameters[14].Value = model.userTell;
            parameters[15].Value = model.userMarry;
            parameters[16].Value = model.fansName;
            parameters[17].Value = model.fansMail;
            parameters[18].Value = model.fansHeadimage;
            parameters[19].Value = model.fansSex;
            parameters[20].Value = model.fansBirthday;
            parameters[21].Value = model.fansAddress;
            parameters[22].Value = model.fansEdu;
            parameters[23].Value = model.fansTell;
            parameters[24].Value = model.fansQQ;
            parameters[25].Value = model.fansDes;
            parameters[26].Value = model.fansMarry;

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
            strSql.Append("friendNoteName=@friendNoteName,");
            strSql.Append("userAddress=@userAddress,");
            strSql.Append("userBirthday=@userBirthday,");
            strSql.Append("userMail=@userMail,");
            strSql.Append("userSex=@userSex,");
            strSql.Append("userEdu=@userEdu,");
            strSql.Append("userDes=@userDes,");
            strSql.Append("QQnumber=@QQnumber,");
            strSql.Append("userTell=@userTell,");
            strSql.Append("userMarry=@userMarry,");
            strSql.Append("fansName=@fansName,");
            strSql.Append("fansMail=@fansMail,");
            strSql.Append("fansHeadimage=@fansHeadimage,");
            strSql.Append("fansSex=@fansSex,");
            strSql.Append("fansBirthday=@fansBirthday,");
            strSql.Append("fansAddress=@fansAddress,");
            strSql.Append("fansEdu=@fansEdu,");
            strSql.Append("fansTell=@fansTell,");
            strSql.Append("fansQQ=@fansQQ,");
            strSql.Append("fansDes=@fansDes,");
            strSql.Append("fansMarry=@fansMarry");
            strSql.Append(" where userId=@userId and groupName=@groupName and friendId=@friendId and groupId=@groupId and userName=@userName and userHeadimage=@userHeadimage and friendNoteName=@friendNoteName and userAddress=@userAddress and userBirthday=@userBirthday and userMail=@userMail and userSex=@userSex and userEdu=@userEdu and userDes=@userDes and QQnumber=@QQnumber and userTell=@userTell and userMarry=@userMarry and fansName=@fansName and fansMail=@fansMail and fansHeadimage=@fansHeadimage and fansSex=@fansSex and fansBirthday=@fansBirthday and fansAddress=@fansAddress and fansEdu=@fansEdu and fansTell=@fansTell and fansQQ=@fansQQ and fansDes=@fansDes and fansMarry=@fansMarry ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20),
					new SqlParameter("@userAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@userBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@userMail", SqlDbType.VarChar,50),
					new SqlParameter("@userSex", SqlDbType.NChar,1),
					new SqlParameter("@userEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@userDes", SqlDbType.NVarChar,150),
					new SqlParameter("@QQnumber", SqlDbType.VarChar,20),
					new SqlParameter("@userTell", SqlDbType.NChar,11),
					new SqlParameter("@userMarry", SqlDbType.NVarChar,10),
					new SqlParameter("@fansName", SqlDbType.NVarChar,20),
					new SqlParameter("@fansMail", SqlDbType.VarChar,50),
					new SqlParameter("@fansHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@fansSex", SqlDbType.NChar,1),
					new SqlParameter("@fansBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@fansAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@fansEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@fansTell", SqlDbType.NChar,11),
					new SqlParameter("@fansQQ", SqlDbType.VarChar,20),
					new SqlParameter("@fansDes", SqlDbType.NVarChar,150),
					new SqlParameter("@fansMarry", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.userId;
            parameters[1].Value = model.groupName;
            parameters[2].Value = model.friendId;
            parameters[3].Value = model.groupId;
            parameters[4].Value = model.userName;
            parameters[5].Value = model.userHeadimage;
            parameters[6].Value = model.friendNoteName;
            parameters[7].Value = model.userAddress;
            parameters[8].Value = model.userBirthday;
            parameters[9].Value = model.userMail;
            parameters[10].Value = model.userSex;
            parameters[11].Value = model.userEdu;
            parameters[12].Value = model.userDes;
            parameters[13].Value = model.QQnumber;
            parameters[14].Value = model.userTell;
            parameters[15].Value = model.userMarry;
            parameters[16].Value = model.fansName;
            parameters[17].Value = model.fansMail;
            parameters[18].Value = model.fansHeadimage;
            parameters[19].Value = model.fansSex;
            parameters[20].Value = model.fansBirthday;
            parameters[21].Value = model.fansAddress;
            parameters[22].Value = model.fansEdu;
            parameters[23].Value = model.fansTell;
            parameters[24].Value = model.fansQQ;
            parameters[25].Value = model.fansDes;
            parameters[26].Value = model.fansMarry;

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
        public bool Delete(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName, string userAddress, string userBirthday, string userMail, string userSex, string userEdu, string userDes, string QQnumber, string userTell, string userMarry, string fansName, string fansMail, string fansHeadimage, string fansSex, string fansBirthday, string fansAddress, string fansEdu, string fansTell, string fansQQ, string fansDes, string fansMarry)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from focusV ");
            strSql.Append(" where userId=@userId and groupName=@groupName and friendId=@friendId and groupId=@groupId and userName=@userName and userHeadimage=@userHeadimage and friendNoteName=@friendNoteName and userAddress=@userAddress and userBirthday=@userBirthday and userMail=@userMail and userSex=@userSex and userEdu=@userEdu and userDes=@userDes and QQnumber=@QQnumber and userTell=@userTell and userMarry=@userMarry and fansName=@fansName and fansMail=@fansMail and fansHeadimage=@fansHeadimage and fansSex=@fansSex and fansBirthday=@fansBirthday and fansAddress=@fansAddress and fansEdu=@fansEdu and fansTell=@fansTell and fansQQ=@fansQQ and fansDes=@fansDes and fansMarry=@fansMarry ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20),
					new SqlParameter("@userAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@userBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@userMail", SqlDbType.VarChar,50),
					new SqlParameter("@userSex", SqlDbType.NChar,1),
					new SqlParameter("@userEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@userDes", SqlDbType.NVarChar,150),
					new SqlParameter("@QQnumber", SqlDbType.VarChar,20),
					new SqlParameter("@userTell", SqlDbType.NChar,11),
					new SqlParameter("@userMarry", SqlDbType.NVarChar,10),
					new SqlParameter("@fansName", SqlDbType.NVarChar,20),
					new SqlParameter("@fansMail", SqlDbType.VarChar,50),
					new SqlParameter("@fansHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@fansSex", SqlDbType.NChar,1),
					new SqlParameter("@fansBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@fansAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@fansEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@fansTell", SqlDbType.NChar,11),
					new SqlParameter("@fansQQ", SqlDbType.VarChar,20),
					new SqlParameter("@fansDes", SqlDbType.NVarChar,150),
					new SqlParameter("@fansMarry", SqlDbType.NVarChar,10)			};
            parameters[0].Value = userId;
            parameters[1].Value = groupName;
            parameters[2].Value = friendId;
            parameters[3].Value = groupId;
            parameters[4].Value = userName;
            parameters[5].Value = userHeadimage;
            parameters[6].Value = friendNoteName;
            parameters[7].Value = userAddress;
            parameters[8].Value = userBirthday;
            parameters[9].Value = userMail;
            parameters[10].Value = userSex;
            parameters[11].Value = userEdu;
            parameters[12].Value = userDes;
            parameters[13].Value = QQnumber;
            parameters[14].Value = userTell;
            parameters[15].Value = userMarry;
            parameters[16].Value = fansName;
            parameters[17].Value = fansMail;
            parameters[18].Value = fansHeadimage;
            parameters[19].Value = fansSex;
            parameters[20].Value = fansBirthday;
            parameters[21].Value = fansAddress;
            parameters[22].Value = fansEdu;
            parameters[23].Value = fansTell;
            parameters[24].Value = fansQQ;
            parameters[25].Value = fansDes;
            parameters[26].Value = fansMarry;

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
        public starweibo.Model.focusV GetModel(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName, string userAddress, string userBirthday, string userMail, string userSex, string userEdu, string userDes, string QQnumber, string userTell, string userMarry, string fansName, string fansMail, string fansHeadimage, string fansSex, string fansBirthday, string fansAddress, string fansEdu, string fansTell, string fansQQ, string fansDes, string fansMarry)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 userId,groupName,friendId,groupId,userName,userHeadimage,friendNoteName,userAddress,userBirthday,userMail,userSex,userEdu,userDes,QQnumber,userTell,userMarry,fansName,fansMail,fansHeadimage,fansSex,fansBirthday,fansAddress,fansEdu,fansTell,fansQQ,fansDes,fansMarry from focusV ");
            strSql.Append(" where userId=@userId and groupName=@groupName and friendId=@friendId and groupId=@groupId and userName=@userName and userHeadimage=@userHeadimage and friendNoteName=@friendNoteName and userAddress=@userAddress and userBirthday=@userBirthday and userMail=@userMail and userSex=@userSex and userEdu=@userEdu and userDes=@userDes and QQnumber=@QQnumber and userTell=@userTell and userMarry=@userMarry and fansName=@fansName and fansMail=@fansMail and fansHeadimage=@fansHeadimage and fansSex=@fansSex and fansBirthday=@fansBirthday and fansAddress=@fansAddress and fansEdu=@fansEdu and fansTell=@fansTell and fansQQ=@fansQQ and fansDes=@fansDes and fansMarry=@fansMarry ");
            SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4),
					new SqlParameter("@groupName", SqlDbType.NVarChar,20),
					new SqlParameter("@friendId", SqlDbType.Int,4),
					new SqlParameter("@groupId", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.NVarChar,20),
					new SqlParameter("@userHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@friendNoteName", SqlDbType.NVarChar,20),
					new SqlParameter("@userAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@userBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@userMail", SqlDbType.VarChar,50),
					new SqlParameter("@userSex", SqlDbType.NChar,1),
					new SqlParameter("@userEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@userDes", SqlDbType.NVarChar,150),
					new SqlParameter("@QQnumber", SqlDbType.VarChar,20),
					new SqlParameter("@userTell", SqlDbType.NChar,11),
					new SqlParameter("@userMarry", SqlDbType.NVarChar,10),
					new SqlParameter("@fansName", SqlDbType.NVarChar,20),
					new SqlParameter("@fansMail", SqlDbType.VarChar,50),
					new SqlParameter("@fansHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@fansSex", SqlDbType.NChar,1),
					new SqlParameter("@fansBirthday", SqlDbType.VarChar,20),
					new SqlParameter("@fansAddress", SqlDbType.NVarChar,150),
					new SqlParameter("@fansEdu", SqlDbType.NVarChar,250),
					new SqlParameter("@fansTell", SqlDbType.NChar,11),
					new SqlParameter("@fansQQ", SqlDbType.VarChar,20),
					new SqlParameter("@fansDes", SqlDbType.NVarChar,150),
					new SqlParameter("@fansMarry", SqlDbType.NVarChar,10)			};
            parameters[0].Value = userId;
            parameters[1].Value = groupName;
            parameters[2].Value = friendId;
            parameters[3].Value = groupId;
            parameters[4].Value = userName;
            parameters[5].Value = userHeadimage;
            parameters[6].Value = friendNoteName;
            parameters[7].Value = userAddress;
            parameters[8].Value = userBirthday;
            parameters[9].Value = userMail;
            parameters[10].Value = userSex;
            parameters[11].Value = userEdu;
            parameters[12].Value = userDes;
            parameters[13].Value = QQnumber;
            parameters[14].Value = userTell;
            parameters[15].Value = userMarry;
            parameters[16].Value = fansName;
            parameters[17].Value = fansMail;
            parameters[18].Value = fansHeadimage;
            parameters[19].Value = fansSex;
            parameters[20].Value = fansBirthday;
            parameters[21].Value = fansAddress;
            parameters[22].Value = fansEdu;
            parameters[23].Value = fansTell;
            parameters[24].Value = fansQQ;
            parameters[25].Value = fansDes;
            parameters[26].Value = fansMarry;

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
                if (row["userAddress"] != null)
                {
                    model.userAddress = row["userAddress"].ToString();
                }
                if (row["userBirthday"] != null)
                {
                    model.userBirthday = row["userBirthday"].ToString();
                }
                if (row["userMail"] != null)
                {
                    model.userMail = row["userMail"].ToString();
                }
                if (row["userSex"] != null)
                {
                    model.userSex = row["userSex"].ToString();
                }
                if (row["userEdu"] != null)
                {
                    model.userEdu = row["userEdu"].ToString();
                }
                if (row["userDes"] != null)
                {
                    model.userDes = row["userDes"].ToString();
                }
                if (row["QQnumber"] != null)
                {
                    model.QQnumber = row["QQnumber"].ToString();
                }
                if (row["userTell"] != null)
                {
                    model.userTell = row["userTell"].ToString();
                }
                if (row["userMarry"] != null)
                {
                    model.userMarry = row["userMarry"].ToString();
                }
                if (row["fansName"] != null)
                {
                    model.fansName = row["fansName"].ToString();
                }
                if (row["fansMail"] != null)
                {
                    model.fansMail = row["fansMail"].ToString();
                }
                if (row["fansHeadimage"] != null)
                {
                    model.fansHeadimage = row["fansHeadimage"].ToString();
                }
                if (row["fansSex"] != null)
                {
                    model.fansSex = row["fansSex"].ToString();
                }
                if (row["fansBirthday"] != null)
                {
                    model.fansBirthday = row["fansBirthday"].ToString();
                }
                if (row["fansAddress"] != null)
                {
                    model.fansAddress = row["fansAddress"].ToString();
                }
                if (row["fansEdu"] != null)
                {
                    model.fansEdu = row["fansEdu"].ToString();
                }
                if (row["fansTell"] != null)
                {
                    model.fansTell = row["fansTell"].ToString();
                }
                if (row["fansQQ"] != null)
                {
                    model.fansQQ = row["fansQQ"].ToString();
                }
                if (row["fansDes"] != null)
                {
                    model.fansDes = row["fansDes"].ToString();
                }
                if (row["fansMarry"] != null)
                {
                    model.fansMarry = row["fansMarry"].ToString();
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
            strSql.Append("select userId,groupName,friendId,groupId,userName,userHeadimage,friendNoteName,userAddress,userBirthday,userMail,userSex,userEdu,userDes,QQnumber,userTell,userMarry,fansName,fansMail,fansHeadimage,fansSex,fansBirthday,fansAddress,fansEdu,fansTell,fansQQ,fansDes,fansMarry ");
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
            strSql.Append(" userId,groupName,friendId,groupId,userName,userHeadimage,friendNoteName,userAddress,userBirthday,userMail,userSex,userEdu,userDes,QQnumber,userTell,userMarry,fansName,fansMail,fansHeadimage,fansSex,fansBirthday,fansAddress,fansEdu,fansTell,fansQQ,fansDes,fansMarry ");
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
                strSql.Append("order by T.fansMarry desc");
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
            parameters[1].Value = "fansMarry";
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

