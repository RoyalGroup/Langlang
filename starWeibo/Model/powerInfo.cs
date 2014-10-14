using System;
namespace starweibo.Model
{
    /// <summary>
    /// powerInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class powerInfo
    {
        public powerInfo()
        { }
        #region Model
        private int _id;
        private int _userid;
        private string _zan = "1";
        private string _pinglun = "1";
        private string _at = "1";
        private string _guanzhu = "1";
        private string _jubao = "1";
        private string _zhuanfa = "1";
        private string _shoucang = "1";
        private string _fasong = "1";
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
        public string zan
        {
            set { _zan = value; }
            get { return _zan; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pinglun
        {
            set { _pinglun = value; }
            get { return _pinglun; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string at
        {
            set { _at = value; }
            get { return _at; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string guanzhu
        {
            set { _guanzhu = value; }
            get { return _guanzhu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string jubao
        {
            set { _jubao = value; }
            get { return _jubao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zhuanfa
        {
            set { _zhuanfa = value; }
            get { return _zhuanfa; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string shoucang
        {
            set { _shoucang = value; }
            get { return _shoucang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string fasong
        {
            set { _fasong = value; }
            get { return _fasong; }
        }
        #endregion Model

    }
}

