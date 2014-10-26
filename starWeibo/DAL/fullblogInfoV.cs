using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:fullblogInfoV
    /// </summary>
    public partial class fullblogInfoV
    {
        public fullblogInfoV()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int blogid, string blogContent, DateTime blogpubtime, int zanNum, int plNum, int blogAuthorId, string blogAuthorName, string blogAuthorHeadimage, int zfId, string zfContent, DateTime zfPubtime, int zfzanNum, int zfplNum, int zfAuthorid, string zfAuthorName, string zfuserHeadimage)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from fullblogInfoV");
            strSql.Append(" where blogid=@blogid and blogContent=@blogContent and blogpubtime=@blogpubtime and zanNum=@zanNum and plNum=@plNum and blogAuthorId=@blogAuthorId and blogAuthorName=@blogAuthorName and blogAuthorHeadimage=@blogAuthorHeadimage and zfId=@zfId and zfContent=@zfContent and zfPubtime=@zfPubtime and zfzanNum=@zfzanNum and zfplNum=@zfplNum and zfAuthorid=@zfAuthorid and zfAuthorName=@zfAuthorName and zfuserHeadimage=@zfuserHeadimage ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogid", SqlDbType.Int,4),
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogpubtime", SqlDbType.DateTime),
					new SqlParameter("@zanNum", SqlDbType.Int,4),
					new SqlParameter("@plNum", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@blogAuthorHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@zfId", SqlDbType.Int,4),
					new SqlParameter("@zfContent", SqlDbType.NVarChar,500),
					new SqlParameter("@zfPubtime", SqlDbType.DateTime),
					new SqlParameter("@zfzanNum", SqlDbType.Int,4),
					new SqlParameter("@zfplNum", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorid", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@zfuserHeadimage", SqlDbType.NVarChar,150)			};
            parameters[0].Value = blogid;
            parameters[1].Value = blogContent;
            parameters[2].Value = blogpubtime;
            parameters[3].Value = zanNum;
            parameters[4].Value = plNum;
            parameters[5].Value = blogAuthorId;
            parameters[6].Value = blogAuthorName;
            parameters[7].Value = blogAuthorHeadimage;
            parameters[8].Value = zfId;
            parameters[9].Value = zfContent;
            parameters[10].Value = zfPubtime;
            parameters[11].Value = zfzanNum;
            parameters[12].Value = zfplNum;
            parameters[13].Value = zfAuthorid;
            parameters[14].Value = zfAuthorName;
            parameters[15].Value = zfuserHeadimage;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.fullblogInfoV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into fullblogInfoV(");
            strSql.Append("blogid,blogContent,blogpubtime,zanNum,plNum,blogAuthorId,blogAuthorName,blogAuthorHeadimage,zfId,zfContent,zfPubtime,zfzanNum,zfplNum,zfAuthorid,zfAuthorName,zfuserHeadimage)");
            strSql.Append(" values (");
            strSql.Append("@blogid,@blogContent,@blogpubtime,@zanNum,@plNum,@blogAuthorId,@blogAuthorName,@blogAuthorHeadimage,@zfId,@zfContent,@zfPubtime,@zfzanNum,@zfplNum,@zfAuthorid,@zfAuthorName,@zfuserHeadimage)");
            SqlParameter[] parameters = {
					new SqlParameter("@blogid", SqlDbType.Int,4),
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogpubtime", SqlDbType.DateTime),
					new SqlParameter("@zanNum", SqlDbType.Int,4),
					new SqlParameter("@plNum", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@blogAuthorHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@zfId", SqlDbType.Int,4),
					new SqlParameter("@zfContent", SqlDbType.NVarChar,500),
					new SqlParameter("@zfPubtime", SqlDbType.DateTime),
					new SqlParameter("@zfzanNum", SqlDbType.Int,4),
					new SqlParameter("@zfplNum", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorid", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@zfuserHeadimage", SqlDbType.NVarChar,150)};
            parameters[0].Value = model.blogid;
            parameters[1].Value = model.blogContent;
            parameters[2].Value = model.blogpubtime;
            parameters[3].Value = model.zanNum;
            parameters[4].Value = model.plNum;
            parameters[5].Value = model.blogAuthorId;
            parameters[6].Value = model.blogAuthorName;
            parameters[7].Value = model.blogAuthorHeadimage;
            parameters[8].Value = model.zfId;
            parameters[9].Value = model.zfContent;
            parameters[10].Value = model.zfPubtime;
            parameters[11].Value = model.zfzanNum;
            parameters[12].Value = model.zfplNum;
            parameters[13].Value = model.zfAuthorid;
            parameters[14].Value = model.zfAuthorName;
            parameters[15].Value = model.zfuserHeadimage;

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
        public bool Update(starweibo.Model.fullblogInfoV model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update fullblogInfoV set ");
            strSql.Append("blogid=@blogid,");
            strSql.Append("blogContent=@blogContent,");
            strSql.Append("blogpubtime=@blogpubtime,");
            strSql.Append("zanNum=@zanNum,");
            strSql.Append("plNum=@plNum,");
            strSql.Append("blogAuthorId=@blogAuthorId,");
            strSql.Append("blogAuthorName=@blogAuthorName,");
            strSql.Append("blogAuthorHeadimage=@blogAuthorHeadimage,");
            strSql.Append("zfId=@zfId,");
            strSql.Append("zfContent=@zfContent,");
            strSql.Append("zfPubtime=@zfPubtime,");
            strSql.Append("zfzanNum=@zfzanNum,");
            strSql.Append("zfplNum=@zfplNum,");
            strSql.Append("zfAuthorid=@zfAuthorid,");
            strSql.Append("zfAuthorName=@zfAuthorName,");
            strSql.Append("zfuserHeadimage=@zfuserHeadimage");
            strSql.Append(" where blogid=@blogid and blogContent=@blogContent and blogpubtime=@blogpubtime and zanNum=@zanNum and plNum=@plNum and blogAuthorId=@blogAuthorId and blogAuthorName=@blogAuthorName and blogAuthorHeadimage=@blogAuthorHeadimage and zfId=@zfId and zfContent=@zfContent and zfPubtime=@zfPubtime and zfzanNum=@zfzanNum and zfplNum=@zfplNum and zfAuthorid=@zfAuthorid and zfAuthorName=@zfAuthorName and zfuserHeadimage=@zfuserHeadimage ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogid", SqlDbType.Int,4),
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogpubtime", SqlDbType.DateTime),
					new SqlParameter("@zanNum", SqlDbType.Int,4),
					new SqlParameter("@plNum", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@blogAuthorHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@zfId", SqlDbType.Int,4),
					new SqlParameter("@zfContent", SqlDbType.NVarChar,500),
					new SqlParameter("@zfPubtime", SqlDbType.DateTime),
					new SqlParameter("@zfzanNum", SqlDbType.Int,4),
					new SqlParameter("@zfplNum", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorid", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@zfuserHeadimage", SqlDbType.NVarChar,150)};
            parameters[0].Value = model.blogid;
            parameters[1].Value = model.blogContent;
            parameters[2].Value = model.blogpubtime;
            parameters[3].Value = model.zanNum;
            parameters[4].Value = model.plNum;
            parameters[5].Value = model.blogAuthorId;
            parameters[6].Value = model.blogAuthorName;
            parameters[7].Value = model.blogAuthorHeadimage;
            parameters[8].Value = model.zfId;
            parameters[9].Value = model.zfContent;
            parameters[10].Value = model.zfPubtime;
            parameters[11].Value = model.zfzanNum;
            parameters[12].Value = model.zfplNum;
            parameters[13].Value = model.zfAuthorid;
            parameters[14].Value = model.zfAuthorName;
            parameters[15].Value = model.zfuserHeadimage;

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
        public bool Delete(int blogid, string blogContent, DateTime blogpubtime, int zanNum, int plNum, int blogAuthorId, string blogAuthorName, string blogAuthorHeadimage, int zfId, string zfContent, DateTime zfPubtime, int zfzanNum, int zfplNum, int zfAuthorid, string zfAuthorName, string zfuserHeadimage)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from fullblogInfoV ");
            strSql.Append(" where blogid=@blogid and blogContent=@blogContent and blogpubtime=@blogpubtime and zanNum=@zanNum and plNum=@plNum and blogAuthorId=@blogAuthorId and blogAuthorName=@blogAuthorName and blogAuthorHeadimage=@blogAuthorHeadimage and zfId=@zfId and zfContent=@zfContent and zfPubtime=@zfPubtime and zfzanNum=@zfzanNum and zfplNum=@zfplNum and zfAuthorid=@zfAuthorid and zfAuthorName=@zfAuthorName and zfuserHeadimage=@zfuserHeadimage ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogid", SqlDbType.Int,4),
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogpubtime", SqlDbType.DateTime),
					new SqlParameter("@zanNum", SqlDbType.Int,4),
					new SqlParameter("@plNum", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@blogAuthorHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@zfId", SqlDbType.Int,4),
					new SqlParameter("@zfContent", SqlDbType.NVarChar,500),
					new SqlParameter("@zfPubtime", SqlDbType.DateTime),
					new SqlParameter("@zfzanNum", SqlDbType.Int,4),
					new SqlParameter("@zfplNum", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorid", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@zfuserHeadimage", SqlDbType.NVarChar,150)			};
            parameters[0].Value = blogid;
            parameters[1].Value = blogContent;
            parameters[2].Value = blogpubtime;
            parameters[3].Value = zanNum;
            parameters[4].Value = plNum;
            parameters[5].Value = blogAuthorId;
            parameters[6].Value = blogAuthorName;
            parameters[7].Value = blogAuthorHeadimage;
            parameters[8].Value = zfId;
            parameters[9].Value = zfContent;
            parameters[10].Value = zfPubtime;
            parameters[11].Value = zfzanNum;
            parameters[12].Value = zfplNum;
            parameters[13].Value = zfAuthorid;
            parameters[14].Value = zfAuthorName;
            parameters[15].Value = zfuserHeadimage;

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
        public starweibo.Model.fullblogInfoV GetModel(int blogid, string blogContent, DateTime blogpubtime, int zanNum, int plNum, int blogAuthorId, string blogAuthorName, string blogAuthorHeadimage, int zfId, string zfContent, DateTime zfPubtime, int zfzanNum, int zfplNum, int zfAuthorid, string zfAuthorName, string zfuserHeadimage)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 blogid,blogContent,blogpubtime,zanNum,plNum,blogAuthorId,blogAuthorName,blogAuthorHeadimage,zfId,zfContent,zfPubtime,zfzanNum,zfplNum,zfAuthorid,zfAuthorName,zfuserHeadimage from fullblogInfoV ");
            strSql.Append(" where blogid=@blogid and blogContent=@blogContent and blogpubtime=@blogpubtime and zanNum=@zanNum and plNum=@plNum and blogAuthorId=@blogAuthorId and blogAuthorName=@blogAuthorName and blogAuthorHeadimage=@blogAuthorHeadimage and zfId=@zfId and zfContent=@zfContent and zfPubtime=@zfPubtime and zfzanNum=@zfzanNum and zfplNum=@zfplNum and zfAuthorid=@zfAuthorid and zfAuthorName=@zfAuthorName and zfuserHeadimage=@zfuserHeadimage ");
            SqlParameter[] parameters = {
					new SqlParameter("@blogid", SqlDbType.Int,4),
					new SqlParameter("@blogContent", SqlDbType.NVarChar,500),
					new SqlParameter("@blogpubtime", SqlDbType.DateTime),
					new SqlParameter("@zanNum", SqlDbType.Int,4),
					new SqlParameter("@plNum", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorId", SqlDbType.Int,4),
					new SqlParameter("@blogAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@blogAuthorHeadimage", SqlDbType.NVarChar,150),
					new SqlParameter("@zfId", SqlDbType.Int,4),
					new SqlParameter("@zfContent", SqlDbType.NVarChar,500),
					new SqlParameter("@zfPubtime", SqlDbType.DateTime),
					new SqlParameter("@zfzanNum", SqlDbType.Int,4),
					new SqlParameter("@zfplNum", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorid", SqlDbType.Int,4),
					new SqlParameter("@zfAuthorName", SqlDbType.NVarChar,20),
					new SqlParameter("@zfuserHeadimage", SqlDbType.NVarChar,150)			};
            parameters[0].Value = blogid;
            parameters[1].Value = blogContent;
            parameters[2].Value = blogpubtime;
            parameters[3].Value = zanNum;
            parameters[4].Value = plNum;
            parameters[5].Value = blogAuthorId;
            parameters[6].Value = blogAuthorName;
            parameters[7].Value = blogAuthorHeadimage;
            parameters[8].Value = zfId;
            parameters[9].Value = zfContent;
            parameters[10].Value = zfPubtime;
            parameters[11].Value = zfzanNum;
            parameters[12].Value = zfplNum;
            parameters[13].Value = zfAuthorid;
            parameters[14].Value = zfAuthorName;
            parameters[15].Value = zfuserHeadimage;

            starweibo.Model.fullblogInfoV model = new starweibo.Model.fullblogInfoV();
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
        public starweibo.Model.fullblogInfoV DataRowToModel(DataRow row)
        {
            starweibo.Model.fullblogInfoV model = new starweibo.Model.fullblogInfoV();
            if (row != null)
            {
                if (row["blogid"] != null && row["blogid"].ToString() != "")
                {
                    model.blogid = int.Parse(row["blogid"].ToString());
                }
                if (row["blogContent"] != null)
                {
                    model.blogContent = row["blogContent"].ToString();
                }
                if (row["blogpubtime"] != null && row["blogpubtime"].ToString() != "")
                {
                    model.blogpubtime = DateTime.Parse(row["blogpubtime"].ToString());
                }
                if (row["zanNum"] != null && row["zanNum"].ToString() != "")
                {
                    model.zanNum = int.Parse(row["zanNum"].ToString());
                }
                if (row["plNum"] != null && row["plNum"].ToString() != "")
                {
                    model.plNum = int.Parse(row["plNum"].ToString());
                }
                if (row["blogAuthorId"] != null && row["blogAuthorId"].ToString() != "")
                {
                    model.blogAuthorId = int.Parse(row["blogAuthorId"].ToString());
                }
                if (row["blogAuthorName"] != null)
                {
                    model.blogAuthorName = row["blogAuthorName"].ToString();
                }
                if (row["blogAuthorHeadimage"] != null)
                {
                    model.blogAuthorHeadimage = row["blogAuthorHeadimage"].ToString();
                }
                if (row["zfId"] != null && row["zfId"].ToString() != "")
                {
                    model.zfId = int.Parse(row["zfId"].ToString());
                }
                if (row["zfContent"] != null)
                {
                    model.zfContent = row["zfContent"].ToString();
                }
                if (row["zfPubtime"] != null && row["zfPubtime"].ToString() != "")
                {
                    model.zfPubtime = DateTime.Parse(row["zfPubtime"].ToString());
                }
                if (row["zfzanNum"] != null && row["zfzanNum"].ToString() != "")
                {
                    model.zfzanNum = int.Parse(row["zfzanNum"].ToString());
                }
                if (row["zfplNum"] != null && row["zfplNum"].ToString() != "")
                {
                    model.zfplNum = int.Parse(row["zfplNum"].ToString());
                }
                if (row["zfAuthorid"] != null && row["zfAuthorid"].ToString() != "")
                {
                    model.zfAuthorid = int.Parse(row["zfAuthorid"].ToString());
                }
                if (row["zfAuthorName"] != null)
                {
                    model.zfAuthorName = row["zfAuthorName"].ToString();
                }
                if (row["zfuserHeadimage"] != null)
                {
                    model.zfuserHeadimage = row["zfuserHeadimage"].ToString();
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
            strSql.Append("select blogid,blogContent,blogpubtime,zanNum,plNum,blogAuthorId,blogAuthorName,blogAuthorHeadimage,zfId,zfContent,zfPubtime,zfzanNum,zfplNum,zfAuthorid,zfAuthorName,zfuserHeadimage ");
            strSql.Append(" FROM fullblogInfoV ");
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
            strSql.Append(" blogid,blogContent,blogpubtime,zanNum,plNum,blogAuthorId,blogAuthorName,blogAuthorHeadimage,zfId,zfContent,zfPubtime,zfzanNum,zfplNum,zfAuthorid,zfAuthorName,zfuserHeadimage ");
            strSql.Append(" FROM fullblogInfoV ");
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
            strSql.Append("select count(1) FROM fullblogInfoV ");
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
                strSql.Append("order by T.zfuserHeadimage desc");
            }
            strSql.Append(")AS Row, T.*  from fullblogInfoV T ");
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
            parameters[0].Value = "fullblogInfoV";
            parameters[1].Value = "zfuserHeadimage";
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

