using System;
namespace starweibo.Model
{
    /// <summary>
    /// CollectionV:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CollectionV
    {
        public CollectionV()
        { }
        #region Model
        private string _blogcontent;
        private int _blogauthorid;
        private DateTime _blogpubtime;
        private int _blogid;
        private int _userid;
        private DateTime _pubtime;
        private string _username;
        private string _userheadimage;
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
        public int blogAuthorId
        {
            set { _blogauthorid = value; }
            get { return _blogauthorid; }
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
        public DateTime pubTime
        {
            set { _pubtime = value; }
            get { return _pubtime; }
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
        public int messageId
        {
            set { _messageid = value; }
            get { return _messageid; }
        }
        #endregion Model

    }
}

