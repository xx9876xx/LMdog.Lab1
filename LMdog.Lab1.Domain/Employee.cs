using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMdog.Lab1.Domain
{
    /// <summary>
    /// 員工物件類別
    /// </summary>
    public class Employee
    {
        public Employee() { }

        /// <summary>
        /// 紀錄識別碼
        /// </summary>
        public Guid RecId { get; set; }

        /// <summary>
        /// 資料版本
        /// </summary>
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// 個人序號
        /// </summary>
        public string PersonId { get; set; }

        /// <summary>
        /// 身分證號
        /// </summary>
        public string Idno { get; set; }

        /// <summary>
        /// 中文姓名
        /// </summary>
        public string EmpName { get; set; }

        /// <summary>
        /// 員工編號
        /// </summary>
        public string EmpId { get; set; }

        /// <summary>
        /// 出生日
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 單位代號
        /// </summary>
        public string DeptId { get; set; }

        /// <summary>
        /// 單位名稱
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// 職稱代號
        /// </summary>
        public string TitleId { get; set; }

        /// <summary>
        /// 職稱名稱
        /// </summary>
        public string TitleName { get; set; }

        /// <summary>
        /// 到職日
        /// </summary>
        public DateTime? FirstDay { get; set; }

        /// <summary>
        /// 人員別代號
        /// </summary>
        public string StaffKind { get; set; }

        /// <summary>
        /// 人員別名稱
        /// </summary>
        public string StaffKindDesc { get; set; }

        /// <summary>
        /// 在職狀況
        /// </summary>
        public string JobStatus { get; set; }

        /// <summary>
        /// 退離日期
        /// </summary>
        public DateTime? LastDay { get; set; }

        /// <summary>
        /// 建檔時間
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 修改時間
        /// </summary>
        public DateTime? ModifyTime { get; set; }

        /// <summary>
        /// 資料更新時間
        /// </summary>
        public DateTime? UpdateTime { get; set; }
    }
}
