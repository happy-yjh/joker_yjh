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
        //public Disks GetFoodByDiskID(int diskID)
        //{
        //    string sql = "select * from Disks where DiskID=@DiskID";
        //    SqlParameter[] param = new SqlParameter[]
        //    {
        //        new SqlParameter("@FoodName",diskID)
        //    };
        //    return GetDisksBySql(sql, param); ;
        //}
        private Disks GetDisksBySql(string sql, SqlParameter[] parameters)
        {
            using (SqlDataReader reader = SqlHelper.GetDataReader(sql, parameters))
            {
                Disks disks = null;
                if (reader.Read())
                {
                    disks = new Disks();
                    disks.DiskID = Convert.ToInt32(reader["DiskID"]);
                    disks.DiskStateID = Convert.ToInt32(reader["DiskStateID"]);
                    disks.DiskTypeID = Convert.ToInt32(reader["DiskTypeID"]);

                }
                return disks;
            }
        }
        public int Add(Disks disks)
        {
            string sql = "insert into Disks(Description,DiskStateID,DiskTypeID) values (@Description,@DiskStateID,@DiskTypeID)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Description",disks.Description),
                new SqlParameter("@DiskStateID",disks.DiskStateID),
                new SqlParameter("@DiskTypeID",disks.DiskTypeID)
            };
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }
        public int Delete(int diskID)
        {
            string sql = "delete from Disks where DiskID=" + diskID;
            return SqlHelper.ExecuteNonQuery(sql, null);
        }
    }
}
