using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradModel
{
    public class GuestRecord
    {
        public int GuestID { get; set; }//顾客id
        public string PhoneNum { get; set; }//电话号码
        public string GuestName { get; set; }//顾客姓名
        public int DiskID { get; set; }//桌号
        public DateTime OpenDate { get; set; }//开台时间
        public DateTime EndDate { get; set; }//结账时间
        public decimal TotalMoney { get; set; }//金额
    }
}
