using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMdog.Lab1.Domain;

namespace LMdog.Lab1.Service
{
    /// <summary>
    /// 員工資料服務類別
    /// </summary>
    public class EmployeeService
    {
        /// <summary>
        /// 取得員工資料筆數
        /// </summary>
        /// <returns>員工資料筆數</returns>
        public int Count()
        {
            try
            {
                //TODO 記得使用相依的EF的專案時，本專案也要加入EF的組件才可以使用
                using (LMdog.Lab1.Data_Access.LabEntities entities = new LMdog.Lab1.Data_Access.LabEntities())
                {
                    return entities.Employees.Count();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            
        }

        /// <summary>
        /// 取得員工資料
        /// </summary>
        /// <param name="id">員工編號</param>
        /// <returns>員工資料</returns>
        public Employee Get(string id)
        {
            try
            {
                using (LMdog.Lab1.Data_Access.LabEntities entities = new LMdog.Lab1.Data_Access.LabEntities())
                {
                    var result = entities.Employees
                        .Where(e => e.EmpId == id)
                        .OrderByDescending(e => e.ModifyTime)
                        .FirstOrDefault();

                    if (result == null)
                        return null;
                    else
                        return new Employee(result);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }
        }

        /// <summary>
        /// 更新或新增員工資料
        /// </summary>
        /// <param name="emp">員工物件</param>
        /// <returns>新增結果</returns>
        public bool UpdateOrNew(Employee emp)
        {
        }
    }
}
