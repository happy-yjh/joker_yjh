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
        public int Add(Disks disks)
        {
            //if (diskService.GetFoodByDiskID(disks.DiskID) != null)
            //{
            //    return -1;
            //}
            return diskService.Add(disks);
        }
        public int Delete(int diskId)
        {
            return diskService.Delete(diskId);
        }
    }
}
