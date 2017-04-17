using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic 
{
    public class ReviewLogic : ILogic<Review>
    {
        public int Insert(Review objReview)
        {
            string query = "insert Review values (@ReviewID, @OfficerID, @VendorID, @ReviewTime, @ReviewDetails, @Rating); SELECT @@IDENTITY;";
            List<SqlParameter> lstParams = new List<SqlParameter>();

            lstParams.Add(new SqlParameter("@OfficerID", objReview.OfficerID));
            lstParams.Add(new SqlParameter("@VendorID", objReview.VendorID));
            lstParams.Add(new SqlParameter("@ReviewTime", objReview.ReviewTime));
            lstParams.Add(new SqlParameter("@ReviewDetails", objReview.ReviewDetails));
            lstParams.Add(new SqlParameter("@Rating", objReview.Rating));

            DataTable dt = DBUtility.SelectData(query, lstParams);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int Update(Review objReview)
        {
            string query = "update Review set ReviewID = @ReviewID, OfficerID = @OfficerID, VendorID = @VendorID, ReviewTime = @ReviewTime, ReviewDetails = @ReviewDetails, Rating = @Rating WHERE ReviewID = @ReviewID";

            List<SqlParameter> lstParams = new List<SqlParameter>();
          
            lstParams.Add(new SqlParameter("@OfficerID", objReview.OfficerID));
            lstParams.Add(new SqlParameter("@VendorID", objReview.VendorID));
            lstParams.Add(new SqlParameter("@ReviewTime", objReview.ReviewTime));
            lstParams.Add(new SqlParameter("@ReviewDetails", objReview.ReviewDetails));
            lstParams.Add(new SqlParameter("@Rating", objReview.Rating));

            return DBUtility.ModifyData(query, lstParams);
        }

        public int Delete(int ReviewID)
        {
            string query = "delete Review WHERE ReviewID = @ReviewID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ReviewID", ReviewID));

            return DBUtility.ModifyData(query, lstParams);
        }

        public Review SelectByID(int ReviewID)
        {
            string query = "select * from Review WHERE ReviewID = @ReviewID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@ReviewID", ReviewID));

            DataTable dt = DBUtility.SelectData(query, lstParams);

            Review objReview = new Review();
            if (dt.Rows.Count > 0)
            {
              
                objReview.OfficerID = Convert.ToInt32(dt.Rows[0]["OfficerID"]);
                objReview.VendorID = Convert.ToInt32(dt.Rows[0]["VendorID"]);
                objReview.ReviewTime = Convert.ToDateTime(dt.Rows[0]["ReviewTime"]);
                objReview.ReviewDetails = dt.Rows[0]["ReviewDetials"].ToString();
                objReview.Rating = Convert.ToInt32(dt.Rows[0]["Rating"]);
            }

            return objReview;
        }

        public DataTable SelectAll()
        {
            string query = "select * from Review";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            return DBUtility.SelectData(query, lstParams);
        }

        public bool ValidateUser(string username, string password)
        {
            return true;
        }

        public DataTable Search(string Name)
        {
            string query = "select * from Review where Name like @Name + '%'";

            List<SqlParameter> lstP = new List<SqlParameter>();
            lstP.Add(new SqlParameter("@Name", Name));

            return DBUtility.SelectData(query, lstP);
        }
    }
}
