/*----------------------------------------------------------------
        // Copyright (C) 2007 L3'Studio
        // 版权所有。 
        // 开发者：招远地税征管科
        // 文件名：Publiccode.cs
        // 文件功能描述："通用"指令类，通过Head区分。
//----------------------------------------------------------------*/

using System;

namespace ICanSeeYou.Codes
{
    /// <summary>
    /// "Dos"指令类(作为序列化指令在网络上传输)
    /// </summary>
    [Serializable]
    public class DosCode : BaseCode
    {
        private string  msg;
        /// <summary>
        ///Dos执行结果
        /// </summary>
        public string  Msg
        {
            get { return msg ; }
            set { msg = value; }
        }

        public DosCode() { base.Head = CodeHead.SEND_DOS; }
    }
}
