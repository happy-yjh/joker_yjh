using BillibradModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BillibradDAL
{
    public class DiskService
    {
        public List<Disks> GetDIskListDisk()
        {
            string sql = "select * from Disks ";
            SqlDataReader reader = SqlHelper.GetDataReader(sql, null);
            List<Disks> diskList = new List<Disks>();
            while (reader.Read())
            {
                Disks disk = new Disks();
                disk.DiskID = Convert.ToInt32(reader["DiskID"]);
                disk.Description = Convert.ToString(reader["Description"]);
                disk.DiskTypeID = Convert.ToInt32(reader["DiskTypeID"]);
                disk.DiskStateID = Convert.ToInt32(reader["DiskStateID"]);
                diskList.Add(disk);
            }
            reader.Close();
            return diskList;
        }
    }
}
