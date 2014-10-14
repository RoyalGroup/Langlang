using System;
namespace starweibo.Model
{
    /// <summary>
    /// typeDic:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class typeDic
    {
        public typeDic()
        { }
        #region Model
        private int _typeid;
        private string _typename;
        private string _typeimg;
        /// <summary>
        /// 
        /// </summary>
        public int typeId
        {
            set { _typeid = value; }
            get { return _typeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string typeName
        {
            set { _typename = value; }
            get { return _typename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string typeImg
        {
            set { _typeimg = value; }
            get { return _typeimg; }
        }
        #endregion Model

    }
}

