using BillibradDAL;
using BillibradModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillibradDLL
{
    public class DiskManager
    {
        DiskService diskService = new DiskService();
        public List<Disks> GetDiskListByDisk()
        {
            return diskService.GetDIskListDisk();
        }
    }
}
