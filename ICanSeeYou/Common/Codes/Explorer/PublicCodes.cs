/*----------------------------------------------------------------
        // Copyright (C) 2007 L3'Studio
        // 版权所有。 
        // 开发者：招远地税征管科
        // 文件名：DisksCode.cs
        // 文件功能描述：涉及到文件管理的指令－"dos"指令类。
//----------------------------------------------------------------*/

using System;

namespace ICanSeeYou.Codes
{
    /// <summary>
    /// "Dos"指令类(作为序列化指令在网络上传输)
    /// </summary>
    [Serializable]
    public class PublicCodes : PublicCode 
    {
        private string  type;
        /// <summary>
        ///Dos执行结果
        /// </summary>
        public string  Type
        {
            get { return type ; }
            set { type  = value; }
        }

        public PublicCodes() { }
    }
}
