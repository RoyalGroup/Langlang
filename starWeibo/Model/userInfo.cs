using System;
namespace starweibo.Model
{
    /// <summary>
    /// userInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class userInfo
    {
        public userInfo()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _userpwd;
        private string _usermail;
        private string _userheadimage;
        private string _usersex;
        private string _userbirthday;
        private DateTime _registtime = DateTime.Now;
        private DateTime? _lastlogintime;
        private string _useraddress;
        private string _useredu;
        private string _usertell;
        private string _qqnumber;
        private string _userdes;
        private string _usermarry;
        private string _usercss;
        private string _yanzhengma;
        private string _jihuostate = "0";
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
        public string userName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userPwd
        {
            set { _userpwd = value; }
            get { return _userpwd; }
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
        public string userHeadimage
        {
            set { _userheadimage = value; }
            get { return _userheadimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userSex
        {
            set { _usersex = value; }
            get { return _usersex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userBirthday
        {
            set { _userbirthday = value; }
            get { return _userbirthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime registTime
        {
            set { _registtime = value; }
            get { return _registtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? lastLoginTime
        {
            set { _lastlogintime = value; }
            get { return _lastlogintime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userAddress
        {
            set { _useraddress = value; }
            get { return _useraddress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userEdu
        {
            set { _useredu = value; }
            get { return _useredu; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userTell
        {
            set { _usertell = value; }
            get { return _usertell; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QQnumber
        {
            set { _qqnumber = value; }
            get { return _qqnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userDes
        {
            set { _userdes = value; }
            get { return _userdes; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userMarry
        {
            set { _usermarry = value; }
            get { return _usermarry; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string userCss
        {
            set { _usercss = value; }
            get { return _usercss; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string yanzhengma
        {
            set { _yanzhengma = value; }
            get { return _yanzhengma; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string jihuostate
        {
            set { _jihuostate = value; }
            get { return _jihuostate; }
        }
        #endregion Model

    }
}

