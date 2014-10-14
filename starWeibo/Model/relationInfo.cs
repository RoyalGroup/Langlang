using System;
namespace starweibo.Model
{
    /// <summary>
    /// relationInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class relationInfo
    {
        public relationInfo()
        { }
        #region Model
        private int _id;
        private int _userid;
        private int _friendid;
        private int? _groupid;
        private DateTime _focustime = DateTime.Now;
        private string _friendnotename;
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
        public DateTime focusTime
        {
            set { _focustime = value; }
            get { return _focustime; }
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

