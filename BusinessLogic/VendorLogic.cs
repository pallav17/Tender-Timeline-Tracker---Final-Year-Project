using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic
{
   public class VendorLogic : ILogic<Vendor>
    {
        public int Insert(Vendor objVendor)
        {
            string query = "insert vendor values (@Name, @MobileNo, @EmailId, @Username, @Password, @Photo, @DomainID, @CompanyName, @CreationTime); SELECT @@IDENTITY;";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            
            lstParams.Add(new SqlParameter("@Name", objVendor.Name));
            lstParams.Add(new SqlParameter("@MobileNo", objVendor.MobileNo));
            lstParams.Add(new SqlParameter("@EmailId", objVendor.EmailId));
            lstParams.Add(new SqlParameter("@Username", objVendor.Username));
            lstParams.Add(new SqlParameter("@Password", objVendor.Password));
            lstParams.Add(new SqlParameter("@Photo", objVendor.Photo));
            lstParams.Add(new SqlParameter("@DomainID", objVendor.DomainID));
            lstParams.Add(new SqlParameter("@CompanyName", objVendor.CompanyName));
            lstParams.Add(new SqlParameter("@CreationTime", objVendor.CreationTime));

            DataTable dt = DBUtility.SelectData(query, lstParams);
            return Convert.ToInt32(dt.Rows[0][0]);
       
        }

        public int Update(Vendor objVendor)
        {
            string query = "update Vendor set VendorID = @VendorID, Name = @Name, MobileNo = @MobileNo, EmailId = @EmailId, Username = @Username, Password = @Password, Photo = @Photo, DomainID = @DomainID, CompanyName = @CompanyName, CompanyName = @CompanyName, CreationTime = @CreationTime WHERE VendorID = @VendorID";

            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@Name", objVendor.Name));
            lstParams.Add(new SqlParameter("@MobileNo", objVendor.MobileNo));
            lstParams.Add(new SqlParameter("@EmailId", objVendor.EmailId));
            lstParams.Add(new SqlParameter("@Username", objVendor.Username));
            lstParams.Add(new SqlParameter("@Password", objVendor.Password));
            lstParams.Add(new SqlParameter("@Photo", objVendor.Photo));
            lstParams.Add(new SqlParameter("@DomainID", objVendor.DomainID));
            lstParams.Add(new SqlParameter("@CompanyName", objVendor.CompanyName));
            lstParams.Add(new SqlParameter("@CreationTime", objVendor.CreationTime));

            return DBUtility.ModifyData(query, lstParams);
        }

        public int Delete(int VendorID)
        {
            string query = "delete vendor WHERE VendorID = @VendorID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@VendorID", VendorID));

            return DBUtility.ModifyData(query, lstParams);
        }

        public Vendor SelectByID(int VendorID)
        {
            string query = "select * from vendor WHERE VendorID = @VendorID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@VendorID", VendorID));

            DataTable dt = DBUtility.SelectData(query, lstParams);

            Vendor objVendor = new Vendor();
            if (dt.Rows.Count > 0)
            {
                objVendor.Name = dt.Rows[0]["Name"].ToString();
                objVendor.MobileNo = dt.Rows[0]["MobileNo"].ToString();
                objVendor.EmailId = dt.Rows[0]["EmialId"].ToString();
                objVendor.Username = dt.Rows[0]["Username"].ToString();
                objVendor.Password = dt.Rows[0]["Password"].ToString();
                objVendor.Photo = dt.Rows[0]["Photo"].ToString();
                objVendor.DomainID = Convert.ToInt32(dt.Rows[0]["DomainID"]);
                objVendor.CompanyName = dt.Rows[0]["CompanyName"].ToString();
                objVendor.CreationTime = Convert.ToDateTime(dt.Rows[0]["CreationTime"]);
                }

            return objVendor;
        }

        public DataTable SelectAll()
        {
            string query = "select * from vendor";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            return DBUtility.SelectData(query, lstParams);
        }

        public bool ValidateUser(string username, string password)
        {
            return true;
        }

        public DataTable Search(string Name)
        {
            string query = "select * from vendor where Name like @Name + '%'";

            List<SqlParameter> lstP = new List<SqlParameter>();
            lstP.Add(new SqlParameter("@Name", Name));

            return DBUtility.SelectData(query, lstP);
        }
    }
}
