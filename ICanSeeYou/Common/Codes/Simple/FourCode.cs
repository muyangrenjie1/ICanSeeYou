/*----------------------------------------------------------------
        // Copyright (C) 2007 L3'Studio
        // 版权所有。 
        // 开发者：L3'Studio团队
        // 文件名：ThreeCode.cs
        // 文件功能描述：继承了DoubleCode。
//----------------------------------------------------------------*/

using System;

namespace ICanSeeYou.Codes
{
    /// <summary>
    /// 四指令(例如向服务端请求文件下载上传的指令)
    /// </summary>
    [Serializable]
    public class FourCode : ThreeCode 
    {
        private string other;
        /// <summary>
        /// 指令尾部
        /// </summary>
        public string Other
        {
            get { return other ; }
            set { other  = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ",Other=" + other ;
        }
    }
}
