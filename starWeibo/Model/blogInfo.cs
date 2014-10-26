using System;
namespace starweibo.Model
{
    /// <summary>
    /// blogInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class blogInfo
    {
        public blogInfo()
        { }
        #region Model
        private int _blogid;
        private string _blogcontent;
        private int _blogauthorid;
        private DateTime _blogpubtime = DateTime.Now;
        private int? _parentid;
        private string _blogstate = "0";
        private int _zannum = 0;
        private int _plnum = 0;
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
        public string blogState
        {
            set { _blogstate = value; }
            get { return _blogstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int zanNum
        {
            set { _zannum = value; }
            get { return _zannum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int plNum
        {
            set { _plnum = value; }
            get { return _plnum; }
        }
        #endregion Model

    }
}

