using System;
namespace starweibo.Model
{
    /// <summary>
    /// photoGroupInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class photoGroupInfo
    {
        public photoGroupInfo()
        { }
        #region Model
        private int _id;
        private int _userid;
        private string _photogroupname;
        private string _photogroupcover;
        private DateTime _createtime = DateTime.Now;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int userId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string photoGroupName
        {
            set { _photogroupname = value; }
            get { return _photogroupname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string photoGroupCover
        {
            set { _photogroupcover = value; }
            get { return _photogroupcover; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime createTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        #endregion Model

    }
}

