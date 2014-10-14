using System;
namespace starweibo.Model
{
    /// <summary>
    /// adminInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class adminInfo
    {
        public adminInfo()
        { }
        #region Model
        private int _id;
        private string _adminname;
        private string _adminpwd;
        private string _adminmail;
        private bool _adminstate;
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
        public string adminName
        {
            set { _adminname = value; }
            get { return _adminname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string adminPwd
        {
            set { _adminpwd = value; }
            get { return _adminpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string adminMail
        {
            set { _adminmail = value; }
            get { return _adminmail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool adminState
        {
            set { _adminstate = value; }
            get { return _adminstate; }
        }
        #endregion Model

    }
}

