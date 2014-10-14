using System;
namespace starweibo.Model
{
    /// <summary>
    /// messageInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class messageInfo
    {
        public messageInfo()
        { }
        #region Model
        private int _messageid;
        private int _blogid;
        private int _userid;
        private string _msgcontent;
        private int _msgtypeid;
        private DateTime _pubtime = DateTime.Now;
        private string _msgstate;
        private int _parentid;
        /// <summary>
        /// 
        /// </summary>
        public int messageId
        {
            set { _messageid = value; }
            get { return _messageid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int blogId
        {
            set { _blogid = value; }
            get { return _blogid; }
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
        public string msgContent
        {
            set { _msgcontent = value; }
            get { return _msgcontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int msgTypeId
        {
            set { _msgtypeid = value; }
            get { return _msgtypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime pubTime
        {
            set { _pubtime = value; }
            get { return _pubtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string msgState
        {
            set { _msgstate = value; }
            get { return _msgstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int parentId
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        #endregion Model

    }
}

