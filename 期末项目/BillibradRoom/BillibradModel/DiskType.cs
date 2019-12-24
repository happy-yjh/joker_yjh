using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradModel
{
    public class DiskType
    {
        public int DiskTypeId { get; set; }//球桌类型Id
        public string TypeName { get; set; }//球桌类型名称
        public decimal Money { get; set; }//球桌价钱
    }
}
