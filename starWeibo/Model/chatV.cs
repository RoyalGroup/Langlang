using System;
namespace starweibo.Model
{
    /// <summary>
    /// chatV:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class chatV
    {
        public chatV()
        { }
        #region Model
        private int _senderid;
        private string _msgcontent;
        private DateTime _pubtime;
        private string _msgstate;
        private int _receiverid;
        private string _username;
        private string _userheadimage;
        private string _recusername;
        private string _recuserheadimage;
        private int _shortmsgid;
        /// <summary>
        /// 
        /// </summary>
        public int senderId
        {
            set { _senderid = value; }
            get { return _senderid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string msgContent
        {
            set { _msgcontent = value; }
            get { return _msgcontent; }
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
        public string msgState
        {
            set { _msgstate = value; }
            get { return _msgstate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int receiverId
        {
            set { _receiverid = value; }
            get { return _receiverid; }
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
        public string recuserName
        {
            set { _recusername = value; }
            get { return _recusername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string recuserHeadimage
        {
            set { _recuserheadimage = value; }
            get { return _recuserheadimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int shortMsgId
        {
            set { _shortmsgid = value; }
            get { return _shortmsgid; }
        }
        #endregion Model

    }
}

