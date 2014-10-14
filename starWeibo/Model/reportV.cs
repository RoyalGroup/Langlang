using System;
namespace starweibo.Model
{
    /// <summary>
    /// reportV:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class reportV
    {
        public reportV()
        { }
        #region Model
        private string _blogcontent;
        private DateTime _blogpubtime;
        private string _msgcontent;
        private DateTime _pubtime;
        private string _msgstate;
        private int _blogauthorid;
        private string _username;
        private string _userheadimage;
        private string _blogusername;
        private string _bloguserheadimage;
        private int _blogid;
        private int _userid;
        private int _messageid;
        /// <summary>
        /// 
        /// </summary>
        public string blogContent
        {
            set { _blogcontent = value; }
            get { return _blogcontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime blogPubTime
        {
            set { _blogpubtime = value; }
            get { return _blogpubtime; }
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
        public int blogAuthorId
        {
            set { _blogauthorid = value; }
            get { return _blogauthorid; }
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
        public string bloguserName
        {
            set { _blogusername = value; }
            get { return _blogusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string bloguserheadimage
        {
            set { _bloguserheadimage = value; }
            get { return _bloguserheadimage; }
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
        public int messageId
        {
            set { _messageid = value; }
            get { return _messageid; }
        }
        #endregion Model

    }
}

