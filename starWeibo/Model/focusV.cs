using System;
namespace starweibo.Model
{
    /// <summary>
    /// focusV:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class focusV
    {
        public focusV()
        { }
        #region Model
        private int _userid;
        private string _groupname;
        private int _friendid;
        private int? _groupid;
        private string _username;
        private string _userheadimage;
        private string _friendnotename;
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
        public int friendId
        {
            set { _friendid = value; }
            get { return _friendid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? groupId
        {
            set { _groupid = value; }
            get { return _groupid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userHeadimage
        {
            set { _userheadimage = value; }
            get { return _userheadimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string friendNoteName
        {
            set { _friendnotename = value; }
            get { return _friendnotename; }
        }
        #endregion Model

    }
}

