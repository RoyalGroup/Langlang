using System;
namespace starweibo.Model
{
    /// <summary>
    /// chatInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class chatInfo
    {
        public chatInfo()
        { }
        #region Model
        private int _shortmsgid;
        private int _senderid;
        private int _receiverid;
        private string _msgstate;
        private string _msgcontent;
        private DateTime _pubtime = DateTime.Now;
        /// <summary>
        /// 
        /// </summary>
        public int shortMsgId
        {
            set { _shortmsgid = value; }
            get { return _shortmsgid; }
        }
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
        public int receiverId
        {
            set { _receiverid = value; }
            get { return _receiverid; }
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
        #endregion Model

    }
}

