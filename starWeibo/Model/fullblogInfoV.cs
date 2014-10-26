using System;
namespace starweibo.Model
{
    /// <summary>
    /// fullblogInfoV:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class fullblogInfoV
    {
        public fullblogInfoV()
        { }
        #region Model
        private int _blogid;
        private string _blogcontent;
        private DateTime _blogpubtime;
        private int? _zannum;
        private int? _plnum;
        private int _blogauthorid;
        private string _blogauthorname;
        private string _blogauthorheadimage;
        private int? _zfid;
        private string _zfcontent;
        private DateTime? _zfpubtime;
        private int? _zfzannum;
        private int? _zfplnum;
        private int? _zfauthorid;
        private string _zfauthorname;
        private string _zfuserheadimage;
        /// <summary>
        /// 
        /// </summary>
        public int blogid
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
        public DateTime blogpubtime
        {
            set { _blogpubtime = value; }
            get { return _blogpubtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? zanNum
        {
            set { _zannum = value; }
            get { return _zannum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? plNum
        {
            set { _plnum = value; }
            get { return _plnum; }
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
        public string blogAuthorName
        {
            set { _blogauthorname = value; }
            get { return _blogauthorname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string blogAuthorHeadimage
        {
            set { _blogauthorheadimage = value; }
            get { return _blogauthorheadimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? zfId
        {
            set { _zfid = value; }
            get { return _zfid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zfContent
        {
            set { _zfcontent = value; }
            get { return _zfcontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? zfPubtime
        {
            set { _zfpubtime = value; }
            get { return _zfpubtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? zfzanNum
        {
            set { _zfzannum = value; }
            get { return _zfzannum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? zfplNum
        {
            set { _zfplnum = value; }
            get { return _zfplnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? zfAuthorid
        {
            set { _zfauthorid = value; }
            get { return _zfauthorid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zfAuthorName
        {
            set { _zfauthorname = value; }
            get { return _zfauthorname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zfuserHeadimage
        {
            set { _zfuserheadimage = value; }
            get { return _zfuserheadimage; }
        }
        #endregion Model

    }
}

