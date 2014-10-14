using System;
using System.Data;
using System.Collections.Generic;
using starweibo.Model;
namespace starweibo.BLL
{
    /// <summary>
    /// zanV
    /// </summary>
    public partial class zanV
    {
        private readonly starweibo.DAL.zanV dal = new starweibo.DAL.zanV();
        public zanV()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string blogContent, int blogAuthorId, int blogId, int msgTypeId, DateTime pubTime, string userName, string userHeadimage, int id)
        {
            return dal.Exists(blogContent, blogAuthorId, blogId, msgTypeId, pubTime, userName, userHeadimage, id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.zanV model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(starweibo.Model.zanV model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string blogContent, int blogAuthorId, int blogId, int msgTypeId, DateTime pubTime, string userName, string userHeadimage, int id)
        {

            return dal.Delete(blogContent, blogAuthorId, blogId, msgTypeId, pubTime, userName, userHeadimage, id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public starweibo.Model.zanV GetModel(string blogContent, int blogAuthorId, int blogId, int msgTypeId, DateTime pubTime, string userName, string userHeadimage, int id)
        {

            return dal.GetModel(blogContent, blogAuthorId, blogId, msgTypeId, pubTime, userName, userHeadimage, id);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public starweibo.Model.zanV GetModelByCache(string blogContent, int blogAuthorId, int blogId, int msgTypeId, DateTime pubTime, string userName, string userHeadimage, int id)
        //{

        //    string CacheKey = "zanVModel-" + blogContent + blogAuthorId + blogId + msgTypeId + pubTime + userName + userHeadimage + id;
        //    object objModel = starweibo.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(blogContent, blogAuthorId, blogId, msgTypeId, pubTime, userName, userHeadimage, id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = starweibo.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                starweibo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (starweibo.Model.zanV)objModel;
        //}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<starweibo.Model.zanV> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<starweibo.Model.zanV> DataTableToList(DataTable dt)
        {
            List<starweibo.Model.zanV> modelList = new List<starweibo.Model.zanV>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                starweibo.Model.zanV model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

