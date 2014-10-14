using System;
namespace starweibo.Model
{
    /// <summary>
    /// photos:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class photos
    {
        public photos()
        { }
        #region Model
        private int _id;
        private string _imagename;
        private string _imgpath;
        private DateTime _uploaddate = DateTime.Now;
        private int _photogroupid;
        private int _userid;
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
        public string imageName
        {
            set { _imagename = value; }
            get { return _imagename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string imgPath
        {
            set { _imgpath = value; }
            get { return _imgpath; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime uploadDate
        {
            set { _uploaddate = value; }
            get { return _uploaddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int photoGroupId
        {
            set { _photogroupid = value; }
            get { return _photogroupid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int userId
        {
            set { _userid = value; }
            get { return _userid; }
        }
        #endregion Model

    }
}

