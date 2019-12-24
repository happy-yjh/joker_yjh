using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradModel
{
    public class Disk
    {
        public int DiskID { get; set; }//球桌Id
        public string Description { get; set; }//描述
        public int DiskStateID { get; set; }//球桌状态Id
        public int DiskTypeID { get; set; }//球桌类型ID
    }
}
