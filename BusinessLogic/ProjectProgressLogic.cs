using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class ProjectProgressLogic : ILogic<ProjectProgress>
    {
        public int Insert(ProjectProgress objProjectProgress)
        {
            string query = "insert ProjectProgress values (@ProjectID, @VendorID, @OfficerID, @ProgressTime, @PercentageCompletion, @Photo. @Latitude, @Longitude); SELECT @@IDENTITY;";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ProjectID", objProjectProgress.ProjectID));
            lstParams.Add(new SqlParameter("@VendorID", objProjectProgress.VendorID));
            lstParams.Add(new SqlParameter("@OfficerID", objProjectProgress.OfficerID));
            lstParams.Add(new SqlParameter("@ProgressTime", objProjectProgress.ProgressTime));
            lstParams.Add(new SqlParameter("@PercentageCompletion", objProjectProgress.PercentageCompletion));
            lstParams.Add(new SqlParameter("@Photo", objProjectProgress.Photo));
            lstParams.Add(new SqlParameter("@Latitude", objProjectProgress.Latitude));
            lstParams.Add(new SqlParameter("@Longitude", objProjectProgress.Longitude));

            DataTable dt = DBUtility.SelectData(query, lstParams);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int Update(ProjectProgress objProjectProgress)
        {
            string query = "update ProjectProgress set name = @name, email = @email, Phone = @phone, Username = @Username, Password = @password WHERE ProjectProgressID = @ProjectProgressID";

            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ProjectID", objProjectProgress.ProjectID));
            lstParams.Add(new SqlParameter("@VendorID", objProjectProgress.VendorID));
            lstParams.Add(new SqlParameter("@OfficerID", objProjectProgress.OfficerID));
            lstParams.Add(new SqlParameter("@ProgressTime", objProjectProgress.ProgressTime));
            lstParams.Add(new SqlParameter("@PercentageCompletion", objProjectProgress.PercentageCompletion));
            lstParams.Add(new SqlParameter("@Photo", objProjectProgress.Photo));
            lstParams.Add(new SqlParameter("@Latitude", objProjectProgress.Latitude));
            lstParams.Add(new SqlParameter("@Longitude", objProjectProgress.Longitude));
            
            return DBUtility.ModifyData(query, lstParams);
        }

        public int Delete(int ProjectProgressID)
        {
            string query = "delete projectprogress WHERE ProjectProgressID = @ProjectProgressID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ProjectProgressID", ProjectProgressID));

            return DBUtility.ModifyData(query, lstParams);
        }

        public ProjectProgress SelectByID(int ProjectProgressID)
        {
            string query = "select * from projectprogress WHERE ProjectProgressID = @ProjectProgressID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ProjectProgressID", ProjectProgressID));

            DataTable dt = DBUtility.SelectData(query, lstParams);

            ProjectProgress objProjectProgress = new ProjectProgress();
            if (dt.Rows.Count > 0)
            {
                objProjectProgress.ProjectID = Convert.ToInt32(dt.Rows[0]["ProjectID"]);
                objProjectProgress.VendorID = Convert.ToInt32(dt.Rows[0]["VendorID"]);
                objProjectProgress.OfficerID = Convert.ToInt32(dt.Rows[0]["ProjectProgressID"]);
                objProjectProgress.ProgressTime = Convert.ToDateTime(dt.Rows[0]["ProgressTime"]);
                objProjectProgress.PercentageCompletion = dt.Rows[0]["PercentageCompletion"].ToString();
                objProjectProgress.Photo = dt.Rows[0]["Photo"].ToString();
                objProjectProgress.Latitude = Convert.ToInt32(dt.Rows[0]["Latitude"]);
                objProjectProgress.Longitude = Convert.ToInt32(dt.Rows[0]["Longitude"]);
            }

            return objProjectProgress;
        }

        public DataTable SelectAll()
        {
            string query = "select * from projectprogress";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            return DBUtility.SelectData(query, lstParams);
        }

        public bool ValidateUser(string username, string password)
        {
            return true;
        }

        public DataTable Search(string Name)
        {
            string query = "select * from projectprogress where Name like @Name + '%'";

            List<SqlParameter> lstP = new List<SqlParameter>();
            lstP.Add(new SqlParameter("@Name", Name));

            return DBUtility.SelectData(query, lstP);
        }
    }
}
