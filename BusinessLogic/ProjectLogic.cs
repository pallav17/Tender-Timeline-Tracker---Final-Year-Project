using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccess;

namespace BusinessLogic
{
    public class ProjectLogic : ILogic<Project>
    {
        public int Insert(Project objProject)
        {
            string query = "insert project values (@Name, @DomainID, @CreationTime, @TenderDeadline, @ScheduledStartTime, @ScheduledEndTime, @StartTime, @EndTime, @Budget, @Details, @Documents, @Status, @VendorID, @OfficerID); SELECT @@IDENTITY;";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@Name", objProject.Name));
            lstParams.Add(new SqlParameter("@DomainID", objProject.DomainID));
            lstParams.Add(new SqlParameter("@CreationTime", objProject.CreationTime));
            lstParams.Add(new SqlParameter("@TenderDeadline", objProject.TenderDeadline));
            lstParams.Add(new SqlParameter("@ScheduledStartTime", objProject.ScheduledStartTime));
            lstParams.Add(new SqlParameter("@ScheduledEndTime", objProject.ScheduledEndTime));
            lstParams.Add(new SqlParameter("@StartTime", objProject.StartTime));
            lstParams.Add(new SqlParameter("@EndTime", objProject.EndTime));
            lstParams.Add(new SqlParameter("@Budget", objProject.Budget));
            lstParams.Add(new SqlParameter("@Details", objProject.Details));
            lstParams.Add(new SqlParameter("@Documents", objProject.Documents));
            lstParams.Add(new SqlParameter("@Status", objProject.Status));
            lstParams.Add(new SqlParameter("@VendorID", objProject.VendorID));
            lstParams.Add(new SqlParameter("@OfficerID", objProject.OfficerID));

            DataTable dt = DBUtility.SelectData(query, lstParams);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int Update(Project objProject)
        {
            string query = "update project set Name = @Name, DomainID = @DomainID, CreationTime = @CreationTime, TenderDeadline = @TenderDeadline, ScheduledStartTime = @ScheduledStartTime, ScheduledEndTime = @ScheduledEndTime, StartTime = @StartTime, EndTime = @EndTime, Budget = @Budget, Details = @Details, Documents = @Documents, Status = @Status, VendorID = @VendorID, OfficerID =@OfficerID WHERE ProjectID = @ProjectID";

            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@Name", objProject.Name));
            lstParams.Add(new SqlParameter("@DomainID", objProject.DomainID));
            lstParams.Add(new SqlParameter("@CreationTime", objProject.CreationTime));
            lstParams.Add(new SqlParameter("@TenderDeadline", objProject.TenderDeadline));
            lstParams.Add(new SqlParameter("@ScheduledStartTime", objProject.ScheduledStartTime));
            lstParams.Add(new SqlParameter("@ScheduledEndTime", objProject.ScheduledEndTime));
            lstParams.Add(new SqlParameter("@StartTime", objProject.StartTime));
            lstParams.Add(new SqlParameter("@EndTime", objProject.EndTime));
            lstParams.Add(new SqlParameter("@Budget", objProject.Budget));
            lstParams.Add(new SqlParameter("@Details", objProject.Details));
            lstParams.Add(new SqlParameter("@Documents", objProject.Documents));
            lstParams.Add(new SqlParameter("@Status", objProject.Status));
            lstParams.Add(new SqlParameter("@VendorID", objProject.VendorID));
            lstParams.Add(new SqlParameter("@OfficerID", objProject.OfficerID));
            
            return DBUtility.ModifyData(query, lstParams);
        }

        public int Delete(int ProjectID)
        {
            string query = "delete project WHERE ProjectID = @ProjectID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ProjectID", ProjectID));

            return DBUtility.ModifyData(query, lstParams);
        }

        public Project SelectByID(int ProjectID)
        {
            string query = "select * from project WHERE ProjectID = @ProjectID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ProjectID", ProjectID));

            DataTable dt = DBUtility.SelectData(query, lstParams);

            Project objProject = new Project();
            if (dt.Rows.Count > 0)
            {

                objProject.Name = dt.Rows[0]["Name"].ToString();
                objProject.DomainID = Convert.ToInt32(dt.Rows[0]["DomainID"].ToString());
                objProject.CreationTime = Convert.ToDateTime(dt.Rows[0]["CreationTime"]);
                objProject.TenderDeadline = Convert.ToDateTime(dt.Rows[0]["TenderDeadline"]);
                objProject.ScheduledStartTime = Convert.ToDateTime(dt.Rows[0]["ScheduledStartTime"]);
                objProject.StartTime = Convert.ToDateTime(dt.Rows[0]["StartTime"]);
                objProject.EndTime = Convert.ToDateTime(dt.Rows[0]["EndTime"]);
                objProject.Budget = dt.Rows[0]["Budget"].ToString();
                objProject.Details = dt.Rows[0]["Details"].ToString();
                objProject.Documents = dt.Rows[0]["Documents"].ToString();
                objProject.Status = dt.Rows[0]["Status"].ToString();
                objProject.VendorID = Convert.ToInt32(dt.Rows[0]["VendorID"].ToString());
                objProject.OfficerID = Convert.ToInt32(dt.Rows[0]["OfficerID"].ToString());
            }

            return objProject;
        }

        public DataTable SelectAll()
        {
            string query = "select * from project";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            return DBUtility.SelectData(query, lstParams);
        }

        public bool ValidateUser(string userName, string password)
        {
            return true;
        }

        public DataTable Search(string Name)
        {
            string query = "select * from project where Name like @Name + '%'";

            List<SqlParameter> lstP = new List<SqlParameter>();
            lstP.Add(new SqlParameter("@Name", Name));

            return DBUtility.SelectData(query, lstP);
        }
    }
}
