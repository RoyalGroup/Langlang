using System;
namespace starweibo.Model
{
    /// <summary>
    /// powerV:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class powerV
    {
        public powerV()
        { }
        #region Model
        private string _zan;
        private string _pinglun;
        private string _at;
        private string _guanzhu;
        private string _jubao;
        private string _zhuanfa;
        private string _shoucang;
        private string _fasong;
        private string _username;
        private string _usermail;
        private int _userid;
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
        public string userMail
        {
            set { _usermail = value; }
            get { return _usermail; }
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

