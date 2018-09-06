using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMdog.Lab1.Domain;

namespace LMdog.Lab1.Service
{
    /// <summary>
    /// 批次處理服務類別
    /// </summary>
    public class JobService
    {
        /// <summary>
        /// 匯入員工資料
        /// </summary>
        /// <returns>匯入更新筆數</returns>
        public int ImportEmployees()
        {
        }

        /// <summary>
        /// 匯入員工資料
        /// </summary>
        /// <param name="filePath">來源檔案路徑</param>
        /// <param name="importAll">是否匯入全部資料</param>
        /// <returns>匯入更新筆數</returns>
        public int ImportEmployeeData(string filePath, bool importAll)
        {
        }
    }
}
