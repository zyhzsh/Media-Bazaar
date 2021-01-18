using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App.logic
{
    class StatisticStorage
    {
        ProductManagement productmanagement;
        List<Sale> sellingData;

        public StatisticStorage(DepartmentStorage department)
        {
            sellingData = new List<Sale>();
            productmanagement = new ProductManagement(department);
        }

        public Sale[] GetSellingData(DateTime StartingDate,DateTime EndingDate)
        {
            if (EndingDate < DateTime.Now && StartingDate < EndingDate)
            {
                sellingData.Clear();
                sellingData.AddRange(productmanagement.GetBestSellingProducts(StartingDate, EndingDate));
                return sellingData.ToArray();
            }
            else
            {
                return null;
            }
        }
        public Sale[] GetSellingDataByDepartment(DateTime StartingDate, DateTime EndingDate,string Department)
        {
            if (EndingDate < DateTime.Now && StartingDate < EndingDate)
            {
                sellingData.Clear();
                sellingData.AddRange(productmanagement.GetBestSellingProductsByDepartment(StartingDate, EndingDate,Department));
                return sellingData.ToArray();
            }
            else
            {
                return null;
            }
        }



    }
}
