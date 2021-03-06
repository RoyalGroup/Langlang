﻿using System;
using System.Data;
using System.Collections.Generic;
using starweibo.Model;
namespace starweibo.BLL
{
    /// <summary>
    /// focusV
    /// </summary>
    public partial class focusV
    {
        private readonly starweibo.DAL.focusV dal = new starweibo.DAL.focusV();
        public focusV()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName, string userAddress, string userBirthday, string userMail, string userSex, string userEdu, string userDes, string QQnumber, string userTell, string userMarry, string fansName, string fansMail, string fansHeadimage, string fansSex, string fansBirthday, string fansAddress, string fansEdu, string fansTell, string fansQQ, string fansDes, string fansMarry)
        {
            return dal.Exists(userId, groupName, friendId, groupId, userName, userHeadimage, friendNoteName, userAddress, userBirthday, userMail, userSex, userEdu, userDes, QQnumber, userTell, userMarry, fansName, fansMail, fansHeadimage, fansSex, fansBirthday, fansAddress, fansEdu, fansTell, fansQQ, fansDes, fansMarry);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(starweibo.Model.focusV model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(starweibo.Model.focusV model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName, string userAddress, string userBirthday, string userMail, string userSex, string userEdu, string userDes, string QQnumber, string userTell, string userMarry, string fansName, string fansMail, string fansHeadimage, string fansSex, string fansBirthday, string fansAddress, string fansEdu, string fansTell, string fansQQ, string fansDes, string fansMarry)
        {

            return dal.Delete(userId, groupName, friendId, groupId, userName, userHeadimage, friendNoteName, userAddress, userBirthday, userMail, userSex, userEdu, userDes, QQnumber, userTell, userMarry, fansName, fansMail, fansHeadimage, fansSex, fansBirthday, fansAddress, fansEdu, fansTell, fansQQ, fansDes, fansMarry);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public starweibo.Model.focusV GetModel(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName, string userAddress, string userBirthday, string userMail, string userSex, string userEdu, string userDes, string QQnumber, string userTell, string userMarry, string fansName, string fansMail, string fansHeadimage, string fansSex, string fansBirthday, string fansAddress, string fansEdu, string fansTell, string fansQQ, string fansDes, string fansMarry)
        {

            return dal.GetModel(userId, groupName, friendId, groupId, userName, userHeadimage, friendNoteName, userAddress, userBirthday, userMail, userSex, userEdu, userDes, QQnumber, userTell, userMarry, fansName, fansMail, fansHeadimage, fansSex, fansBirthday, fansAddress, fansEdu, fansTell, fansQQ, fansDes, fansMarry);
        }

        ///// <summary>
        ///// 得到一个对象实体，从缓存中
        ///// </summary>
        //public starweibo.Model.focusV GetModelByCache(int userId, string groupName, int friendId, int groupId, string userName, string userHeadimage, string friendNoteName, string userAddress, string userBirthday, string userMail, string userSex, string userEdu, string userDes, string QQnumber, string userTell, string userMarry, string fansName, string fansMail, string fansHeadimage, string fansSex, string fansBirthday, string fansAddress, string fansEdu, string fansTell, string fansQQ, string fansDes, string fansMarry)
        //{

        //    string CacheKey = "focusVModel-" + userId + groupName + friendId + groupId + userName + userHeadimage + friendNoteName + userAddress + userBirthday + userMail + userSex + userEdu + userDes + QQnumber + userTell + userMarry + fansName + fansMail + fansHeadimage + fansSex + fansBirthday + fansAddress + fansEdu + fansTell + fansQQ + fansDes + fansMarry;
        //    object objModel = starweibo.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(userId, groupName, friendId, groupId, userName, userHeadimage, friendNoteName, userAddress, userBirthday, userMail, userSex, userEdu, userDes, QQnumber, userTell, userMarry, fansName, fansMail, fansHeadimage, fansSex, fansBirthday, fansAddress, fansEdu, fansTell, fansQQ, fansDes, fansMarry);
        //            if (objModel != null)
        //            {
        //                int ModelCache = starweibo.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                starweibo.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch { }
        //    }
        //    return (starweibo.Model.focusV)objModel;
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
        public List<starweibo.Model.focusV> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<starweibo.Model.focusV> DataTableToList(DataTable dt)
        {
            List<starweibo.Model.focusV> modelList = new List<starweibo.Model.focusV>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                starweibo.Model.focusV model;
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

