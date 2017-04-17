using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic
{
    public class TenderLogic : ILogic<Tender>
    {
        public int Insert(Tender objTender)
        {
            string query = "insert tender values (@ProjectID, @VendorID, @Details, @CreationTime, @Documents, @ProposedCost, @Status, @Manpower, @EstimatedTime); SELECT @@IDENTITY;";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ProjectID", objTender.ProjectID));
            lstParams.Add(new SqlParameter("@VendorID", objTender.VendorID));
            lstParams.Add(new SqlParameter("@Details", objTender.Details));
            lstParams.Add(new SqlParameter("@CreationTime", objTender.CreationTime));
            lstParams.Add(new SqlParameter("@Documents", objTender.Documents));
            lstParams.Add(new SqlParameter("@ProposedCost", objTender.ProposedCost));
            lstParams.Add(new SqlParameter("@Status", objTender.Status));
            lstParams.Add(new SqlParameter("@Manpower", objTender.Manpower));
            lstParams.Add(new SqlParameter("@EstimatedTime", objTender.EstimatedTime));

            DataTable dt = DBUtility.SelectData(query, lstParams);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int Update(Tender objTender)
        {
            string query = "update tender set ProjectID = @ProjectID, VendorID = @VendorID, Details = @Details, CreationTime = @CreationTime, Documents = @Documents, ProposedCost = @ProposedCost, Status = @Status, Manpower = @Manpower, EstimatedTime = @EstimatedTime WHERE TenderID = @TenderID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ProjectID", objTender.ProjectID));
            lstParams.Add(new SqlParameter("@VendorID", objTender.VendorID));
            lstParams.Add(new SqlParameter("@Details", objTender.Details));
            lstParams.Add(new SqlParameter("@CreationTime", objTender.CreationTime));
            lstParams.Add(new SqlParameter("@Documents", objTender.Documents));
            lstParams.Add(new SqlParameter("@ProposedCost", objTender.ProposedCost));
            lstParams.Add(new SqlParameter("@Status", objTender.Status));
            lstParams.Add(new SqlParameter("@Manpower", objTender.Manpower));
            lstParams.Add(new SqlParameter("@EstimatedTime", objTender.EstimatedTime));

            return DBUtility.ModifyData(query, lstParams);
        }

        public int Delete(int TenderID)
        {
            string query = "delete Tender WHERE TenderID = @TenderID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@TenderID", TenderID));

            return DBUtility.ModifyData(query, lstParams);
        }

        public Tender SelectByID(int TenderID)
        {
            string query = "select * from tender WHERE TenderID = @TenderID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@TenderID", TenderID));

            DataTable dt = DBUtility.SelectData(query, lstParams);

            Tender objTender = new Tender();
            if (dt.Rows.Count > 0)
            {
                objTender.ProjectID = Convert.ToInt32(dt.Rows[0]["ProjectID"]);
                objTender.VendorID = Convert.ToInt32(dt.Rows[0]["VendorID"]);
                objTender.Details = dt.Rows[0]["Details"].ToString();
                objTender.CreationTime = Convert.ToDateTime(dt.Rows[0]["CreationTime"]);
                objTender.Documents = dt.Rows[0]["Documents"].ToString();
                objTender.ProposedCost = Convert.ToInt32(dt.Rows[0]["ProposedCost"]);
                objTender.Status = dt.Rows[0]["Status"].ToString();
                objTender.Manpower = Convert.ToInt32(dt.Rows[0]["Manpower"]);
                objTender.EstimatedTime = Convert.ToDateTime(dt.Rows[0]["EstimatedTime"]);
            }


            return objTender;
        }

        public DataTable SelectAll()
        {
            string query = "select * from tender";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            return DBUtility.SelectData(query, lstParams);
        }

        public bool ValidateUser(string username, string password)
        {
            return true;
        }

        public DataTable Search(string Name)
        {
            string query = "select * from tender where Name like @Name + '%'";

            List<SqlParameter> lstP = new List<SqlParameter>();
            lstP.Add(new SqlParameter("@Name", Name));

            return DBUtility.SelectData(query, lstP);
        }
    }
}
