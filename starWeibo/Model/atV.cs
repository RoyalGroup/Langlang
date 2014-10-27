using System;
namespace starweibo.Model
{
    /// <summary>
    /// atV:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class atV
    {
        public atV()
        { }
        #region Model
        private string _blogcontent;
        private int _blogauthorid;
        private DateTime _blogpubtime;
        private int? _parentid;
        private string _username;
        private string _userheadimage;
        private string _atusername;
        private string _atuserheadimage;
        private int _blogid;
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
        public int? parentId
        {
            set { _parentid = value; }
            get { return _parentid; }
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
        public string atuserName
        {
            set { _atusername = value; }
            get { return _atusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string atuserHeadimage
        {
            set { _atuserheadimage = value; }
            get { return _atuserheadimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int blogId
        {
            set { _blogid = value; }
            get { return _blogid; }
        }
        #endregion Model

    }
}

