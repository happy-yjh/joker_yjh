using BillibradModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BillibradDAL
{
    public class DiskService
    {
        public List<Disk> GetDIskListDisk()
        {
            string sql = "select * from Disk ";
            SqlDataReader reader = SqlHelper.GetDataReader(sql, null);
            List<Disk> diskList = new List<Disk>();
            while (reader.Read())
            {
                Disk disk = new Disk();
                disk.DiskID = Convert.ToInt32(reader["DiskID"]);
                disk.Description = Convert.ToString(reader["Description"]);
                disk.DiskTypeID = Convert.ToInt32(reader["DiskTypeID"]);
                disk.DiskStateID = Convert.ToInt32(reader["DiskStateID"]);
                diskList.Add(disk);
            }
            reader.Close();
            return diskList;
        }
        //public List<Disk> GetDIskListByTypeID(int typeId)
        //{
        //    string sql = "select * from Disk where DiskTypeID=" + typeId;
        //    SqlDataReader reader = SqlHelper.GetDataReader(sql, null);
        //    List<Disk> diskList = new List<Disk>();
        //    while (reader.Read())
        //    {
        //        Disk disk = new Disk();
        //        disk.DiskID = Convert.ToInt32(reader["DiskID"]);
        //        disk.Description = Convert.ToString(reader["Description"]);
        //        disk.DiskTypeID = Convert.ToInt32(reader["DiskTypeID"]);
        //        disk.DiskStateID = Convert.ToInt32(reader["DiskStateID"]);
        //        diskList.Add(disk);
        //    }
        //    reader.Close();
        //    return diskList;
        //}
    }
}
