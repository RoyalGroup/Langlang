using System;
using System.Data;
using System.Collections.Generic;
using starweibo.Model;

namespace starweibo.BLL
{
    /// <summary>
    /// typeDic
    /// </summary>
    public partial class typeDic
    {
        private readonly starweibo.DAL.typeDic dal = new starweibo.DAL.typeDic();
        public typeDic()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int typeId)
        {
            return dal.Exists(typeId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(starweibo.Model.typeDic model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(starweibo.Model.typeDic model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int typeId)
        {

            return dal.Delete(typeId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string typeIdlist)
        {
            return dal.DeleteList(typeIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public starweibo.Model.typeDic GetModel(int typeId)
        {

            return dal.GetModel(typeId);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public starweibo.Model.typeDic GetModelByCache(int typeId)
        //{

        //    string CacheKey = "typeDicModel-" + typeId;
        //    object objModel = starweibo.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(typeId);
        //            if (objModel != null)
        //            {
        //                int ModelCache = starweibo.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                starweibo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (starweibo.Model.typeDic)objModel;
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
        public List<starweibo.Model.typeDic> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<starweibo.Model.typeDic> DataTableToList(DataTable dt)
        {
            List<starweibo.Model.typeDic> modelList = new List<starweibo.Model.typeDic>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                starweibo.Model.typeDic model;
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

