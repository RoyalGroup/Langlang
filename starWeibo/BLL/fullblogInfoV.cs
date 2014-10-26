using System;
using System.Data;
using System.Collections.Generic;
using starweibo.Model;
namespace starweibo.BLL
{
    /// <summary>
    /// fullblogInfoV
    /// </summary>
    public partial class fullblogInfoV
    {
        private readonly starweibo.DAL.fullblogInfoV dal = new starweibo.DAL.fullblogInfoV();
        public fullblogInfoV()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int blogid, string blogContent, DateTime blogpubtime, int zanNum, int plNum, int blogAuthorId, string blogAuthorName, string blogAuthorHeadimage, int zfId, string zfContent, DateTime zfPubtime, int zfzanNum, int zfplNum, int zfAuthorid, string zfAuthorName, string zfuserHeadimage)
        {
            return dal.Exists(blogid, blogContent, blogpubtime, zanNum, plNum, blogAuthorId, blogAuthorName, blogAuthorHeadimage, zfId, zfContent, zfPubtime, zfzanNum, zfplNum, zfAuthorid, zfAuthorName, zfuserHeadimage);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.fullblogInfoV model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(starweibo.Model.fullblogInfoV model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int blogid, string blogContent, DateTime blogpubtime, int zanNum, int plNum, int blogAuthorId, string blogAuthorName, string blogAuthorHeadimage, int zfId, string zfContent, DateTime zfPubtime, int zfzanNum, int zfplNum, int zfAuthorid, string zfAuthorName, string zfuserHeadimage)
        {

            return dal.Delete(blogid, blogContent, blogpubtime, zanNum, plNum, blogAuthorId, blogAuthorName, blogAuthorHeadimage, zfId, zfContent, zfPubtime, zfzanNum, zfplNum, zfAuthorid, zfAuthorName, zfuserHeadimage);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public starweibo.Model.fullblogInfoV GetModel(int blogid, string blogContent, DateTime blogpubtime, int zanNum, int plNum, int blogAuthorId, string blogAuthorName, string blogAuthorHeadimage, int zfId, string zfContent, DateTime zfPubtime, int zfzanNum, int zfplNum, int zfAuthorid, string zfAuthorName, string zfuserHeadimage)
        {

            return dal.GetModel(blogid, blogContent, blogpubtime, zanNum, plNum, blogAuthorId, blogAuthorName, blogAuthorHeadimage, zfId, zfContent, zfPubtime, zfzanNum, zfplNum, zfAuthorid, zfAuthorName, zfuserHeadimage);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public starweibo.Model.fullblogInfoV GetModelByCache(int blogid, string blogContent, DateTime blogpubtime, int zanNum, int plNum, int blogAuthorId, string blogAuthorName, string blogAuthorHeadimage, int zfId, string zfContent, DateTime zfPubtime, int zfzanNum, int zfplNum, int zfAuthorid, string zfAuthorName, string zfuserHeadimage)
        //{

        //    string CacheKey = "fullblogInfoVModel-" + blogid + blogContent + blogpubtime + zanNum + plNum + blogAuthorId + blogAuthorName + blogAuthorHeadimage + zfId + zfContent + zfPubtime + zfzanNum + zfplNum + zfAuthorid + zfAuthorName + zfuserHeadimage;
        //    object objModel = starweibo.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(blogid, blogContent, blogpubtime, zanNum, plNum, blogAuthorId, blogAuthorName, blogAuthorHeadimage, zfId, zfContent, zfPubtime, zfzanNum, zfplNum, zfAuthorid, zfAuthorName, zfuserHeadimage);
        //            if (objModel != null)
        //            {
        //                int ModelCache = starweibo.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                starweibo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (starweibo.Model.fullblogInfoV)objModel;
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
        public List<starweibo.Model.fullblogInfoV> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<starweibo.Model.fullblogInfoV> DataTableToList(DataTable dt)
        {
            List<starweibo.Model.fullblogInfoV> modelList = new List<starweibo.Model.fullblogInfoV>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                starweibo.Model.fullblogInfoV model;
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

