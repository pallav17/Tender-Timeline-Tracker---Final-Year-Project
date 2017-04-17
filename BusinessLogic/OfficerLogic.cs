using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using System.Data;


namespace BusinessLogic
{
    public class OfficerLogic : ILogic<Officer>
    {
        public int Insert(Officer objOfficer)
        {
            string query = "insert officer values (@Name, @MobileNo, @EmailId, @ProjectID, @Username, @Password, @AllocationTime); SELECT @@IDENTITY;";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@Name", objOfficer.Name));
            lstParams.Add(new SqlParameter("@MobileNo", objOfficer.MobileNo));
            lstParams.Add(new SqlParameter("@EmailId", objOfficer.EmailId));
            lstParams.Add(new SqlParameter("@ProjectID", objOfficer.ProjectID));
            lstParams.Add(new SqlParameter("@Username", objOfficer.Username));
            lstParams.Add(new SqlParameter("@Password", objOfficer.Password));
            lstParams.Add(new SqlParameter("@AllocationTime", objOfficer.AllocationTime));

            DataTable dt = DBUtility.SelectData(query, lstParams);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int Update(Officer objOfficer)
        {
            string query = "update officer set Name = @Name, MobileNo = @MobileNo, EmailId = @EmailId, ProjectID = @ProjectID, Username = @Username, Password = @Password, AllocationTime = @AllocationTime WHERE officerID = @officerID";

            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@Name", objOfficer.Name));
            lstParams.Add(new SqlParameter("@MobileNo", objOfficer.MobileNo));
            lstParams.Add(new SqlParameter("@EmailId", objOfficer.EmailId));
            lstParams.Add(new SqlParameter("@ProjectID", objOfficer.ProjectID));
            lstParams.Add(new SqlParameter("@Username", objOfficer.Username));
            lstParams.Add(new SqlParameter("@Password", objOfficer.Password));
            lstParams.Add(new SqlParameter("@AllocationTime", objOfficer.AllocationTime));

            return DBUtility.ModifyData(query, lstParams);
        }

        public int Delete(int officerID)
        {
            string query = "delete officer WHERE OfficerID = @OfficerID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@OfficerID", officerID));

            return DBUtility.ModifyData(query, lstParams);
        }

        public Officer SelectByID(int OfficerID)
        {
            string query = "select * from officer WHERE OfficerID = @OfficerID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@OfficerID", OfficerID));

            DataTable dt = DBUtility.SelectData(query, lstParams);

            Officer objOfficer = new Officer();
            if (dt.Rows.Count > 0)
            {
                objOfficer.Name = dt.Rows[0]["Name"].ToString();
                objOfficer.MobileNo = dt.Rows[0]["MobileNo"].ToString();
                objOfficer.EmailId = dt.Rows[0]["EmailId"].ToString();
                objOfficer.ProjectID = Convert.ToInt32(dt.Rows[0]["ProjectID"]);
                objOfficer.Username = dt.Rows[0]["UserName"].ToString();
                objOfficer.Password = dt.Rows[0]["Password"].ToString();
                objOfficer.AllocationTime = Convert.ToDateTime(dt.Rows[0]["AllocationTime"]);
                
            }

            return objOfficer;
        }

        public DataTable SelectAll()
        {
            string query = "select * from officer";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            return DBUtility.SelectData(query, lstParams);
        }

        public bool ValidateUser(string username, string password)
        {
            return true;
        }

        public DataTable Search(string name)
        {
            string query = "select * from officer where Name like @name + '%'";

            List<SqlParameter> lstP = new List<SqlParameter>();
            lstP.Add(new SqlParameter("@name", name));

            return DBUtility.SelectData(query, lstP);
        }
    }
}
