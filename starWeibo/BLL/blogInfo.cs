using System;
using System.Data;
using System.Collections.Generic;
using starweibo.Model;
namespace starweibo.BLL
{
    /// <summary>
    /// blogInfo
    /// </summary>
    public partial class blogInfo
    {
        private readonly starweibo.DAL.blogInfo dal = new starweibo.DAL.blogInfo();
        public blogInfo()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int blogId)
        {
            return dal.Exists(blogId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(starweibo.Model.blogInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(starweibo.Model.blogInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新赞的数据
        /// </summary>
        public bool UpdateZan(starweibo.Model.blogInfo model)
        {
            return dal.UpdateZan(model);
        }

        /// <summary>
        /// 更新评论的数据
        /// </summary>
        public bool Updatepl(starweibo.Model.blogInfo model)
        {
            return dal.Updatepl(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int blogId)
        {

            return dal.Delete(blogId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string blogIdlist)
        {
            return dal.DeleteList(blogIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public starweibo.Model.blogInfo GetModel(int blogId)
        {

            return dal.GetModel(blogId);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public starweibo.Model.blogInfo GetModelByCache(int blogId)
        //{

        //    string CacheKey = "blogInfoModel-" + blogId;
        //    object objModel = starweibo.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(blogId);
        //            if (objModel != null)
        //            {
        //                int ModelCache = starweibo.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                starweibo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (starweibo.Model.blogInfo)objModel;
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
        public List<starweibo.Model.blogInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<starweibo.Model.blogInfo> DataTableToList(DataTable dt)
        {
            List<starweibo.Model.blogInfo> modelList = new List<starweibo.Model.blogInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                starweibo.Model.blogInfo model;
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

