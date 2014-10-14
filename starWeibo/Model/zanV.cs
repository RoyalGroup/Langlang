using System;
namespace starweibo.Model
{
    /// <summary>
    /// zanV:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class zanV
    {
        public zanV()
        { }
        #region Model
        private string _blogcontent;
        private int _blogauthorid;
        private int _blogid;
        private int _msgtypeid;
        private DateTime _pubtime;
        private string _username;
        private string _userheadimage;
        private int _id;
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
        public int blogId
        {
            set { _blogid = value; }
            get { return _blogid; }
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
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        #endregion Model

    }
}

