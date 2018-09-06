using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMdog.Lab1.Service
{
    /// <summary>
    /// 相關身份認證服務類別
    /// </summary>
    public class AuthService
    {
        /// <summary>
        /// 驗證身份認證是否合法
        /// </summary>
        /// <param name="authType">認證方式</param>
        /// <param name="token">認證碼</param>
        /// <returns>驗證結果</returns>
        public bool Validate(string authType, string token)
        {
        }
    }
}
