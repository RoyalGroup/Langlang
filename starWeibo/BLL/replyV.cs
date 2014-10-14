using System;
using System.Data;
using System.Collections.Generic;
using starweibo.Model;
namespace starweibo.BLL
{
    /// <summary>
    /// replyV
    /// </summary>
    public partial class replyV
    {
        private readonly starweibo.DAL.replyV dal = new starweibo.DAL.replyV();
        public replyV()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int messageId)
        {
            return dal.Exists(messageId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.replyV model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(starweibo.Model.replyV model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int messageId)
        {

            return dal.Delete(messageId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string messageIdlist)
        {
            return dal.DeleteList(messageIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public starweibo.Model.replyV GetModel(int messageId)
        {

            return dal.GetModel(messageId);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public starweibo.Model.replyV GetModelByCache(int messageId)
        //{

        //    string CacheKey = "replyVModel-" + messageId;
        //    object objModel = starweibo.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(messageId);
        //            if (objModel != null)
        //            {
        //                int ModelCache = starweibo.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                starweibo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (starweibo.Model.replyV)objModel;
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
        public List<starweibo.Model.replyV> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<starweibo.Model.replyV> DataTableToList(DataTable dt)
        {
            List<starweibo.Model.replyV> modelList = new List<starweibo.Model.replyV>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                starweibo.Model.replyV model;
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

