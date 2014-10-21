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
        private int? _atid;
        private string _blogstate = "0";
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
        public int? atId
        {
            set { _atid = value; }
            get { return _atid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string blogState
        {
            set { _blogstate = value; }
            get { return _blogstate; }
        }
        #endregion Model

    }
}

