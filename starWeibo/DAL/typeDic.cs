using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using starweibo.DBUtility;//Please add references
namespace starweibo.DAL
{
    /// <summary>
    /// 数据访问类:typeDic
    /// </summary>
    public partial class typeDic
    {
        public typeDic()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("typeId", "typeDic");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int typeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from typeDic");
            strSql.Append(" where typeId=@typeId");
            SqlParameter[] parameters = {
					new SqlParameter("@typeId", SqlDbType.Int,4)
			};
            parameters[0].Value = typeId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(starweibo.Model.typeDic model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into typeDic(");
            strSql.Append("typeName,typeImg)");
            strSql.Append(" values (");
            strSql.Append("@typeName,@typeImg)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@typeName", SqlDbType.NVarChar,5),
					new SqlParameter("@typeImg", SqlDbType.VarChar,300)};
            parameters[0].Value = model.typeName;
            parameters[1].Value = model.typeImg;

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
        public bool Update(starweibo.Model.typeDic model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update typeDic set ");
            strSql.Append("typeName=@typeName,");
            strSql.Append("typeImg=@typeImg");
            strSql.Append(" where typeId=@typeId");
            SqlParameter[] parameters = {
					new SqlParameter("@typeName", SqlDbType.NVarChar,5),
					new SqlParameter("@typeImg", SqlDbType.VarChar,300),
					new SqlParameter("@typeId", SqlDbType.Int,4)};
            parameters[0].Value = model.typeName;
            parameters[1].Value = model.typeImg;
            parameters[2].Value = model.typeId;

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
        public bool Delete(int typeId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from typeDic ");
            strSql.Append(" where typeId=@typeId");
            SqlParameter[] parameters = {
					new SqlParameter("@typeId", SqlDbType.Int,4)
			};
            parameters[0].Value = typeId;

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
        public bool DeleteList(string typeIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from typeDic ");
            strSql.Append(" where typeId in (" + typeIdlist + ")  ");
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
        public starweibo.Model.typeDic GetModel(int typeId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 typeId,typeName,typeImg from typeDic ");
            strSql.Append(" where typeId=@typeId");
            SqlParameter[] parameters = {
					new SqlParameter("@typeId", SqlDbType.Int,4)
			};
            parameters[0].Value = typeId;

            starweibo.Model.typeDic model = new starweibo.Model.typeDic();
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
        public starweibo.Model.typeDic DataRowToModel(DataRow row)
        {
            starweibo.Model.typeDic model = new starweibo.Model.typeDic();
            if (row != null)
            {
                if (row["typeId"] != null && row["typeId"].ToString() != "")
                {
                    model.typeId = int.Parse(row["typeId"].ToString());
                }
                if (row["typeName"] != null)
                {
                    model.typeName = row["typeName"].ToString();
                }
                if (row["typeImg"] != null)
                {
                    model.typeImg = row["typeImg"].ToString();
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
            strSql.Append("select typeId,typeName,typeImg ");
            strSql.Append(" FROM typeDic ");
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
            strSql.Append(" typeId,typeName,typeImg ");
            strSql.Append(" FROM typeDic ");
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
            strSql.Append("select count(1) FROM typeDic ");
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
                strSql.Append("order by T.typeId desc");
            }
            strSql.Append(")AS Row, T.*  from typeDic T ");
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
            parameters[0].Value = "typeDic";
            parameters[1].Value = "typeId";
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

