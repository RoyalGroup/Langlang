using System;
namespace starweibo.Model
{
    /// <summary>
    /// relationGroupInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class relationGroupInfo
    {
        public relationGroupInfo()
        { }
        #region Model
        private int _id;
        private int _userid;
        private string _groupname;
        private int _sortlevel;
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
        public string groupName
        {
            set { _groupname = value; }
            get { return _groupname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sortLevel
        {
            set { _sortlevel = value; }
            get { return _sortlevel; }
        }
        #endregion Model

    }
}

