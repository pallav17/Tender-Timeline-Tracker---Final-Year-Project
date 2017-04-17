using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class DomainLogic : ILogic<Domain>
     {
        public int Insert(Domain objDomain)
        {
            string query = "insert domain values (@Name, @Details, @Rules, @AgreementDocument); SELECT @@IDENTITY;";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@Name", objDomain.Name));
            lstParams.Add(new SqlParameter("@Details", objDomain.Details));
            lstParams.Add(new SqlParameter("@Rules", objDomain.Rules));
            lstParams.Add(new SqlParameter("@AgreementDocument", objDomain.AgreementDocument));

            DataTable dt = DBUtility.SelectData(query, lstParams);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int Update(Domain objDomain)
        {
            string query = "update domain set Name = @Name, Details = @Details, Rules = @Rules, AgreementDocument = @AgreementDocument WHERE DomainID = @DomainID";

            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@Name", objDomain.Name));
            lstParams.Add(new SqlParameter("@Details", objDomain.Details));
            lstParams.Add(new SqlParameter("@Rules", objDomain.Rules));
            lstParams.Add(new SqlParameter("@AgreementDocument", objDomain.AgreementDocument));

            return DBUtility.ModifyData(query, lstParams);
        }

        public int Delete(int DomainID)
        {
            string query = "delete domain WHERE DomainID = @DomainID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@DomainID", DomainID));

            return DBUtility.ModifyData(query, lstParams);
        }

        public Domain SelectByID(int DomainID)
        {
            string query = "select * from domain WHERE DomainID = @DomainID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@DomainID", DomainID));

            DataTable dt = DBUtility.SelectData(query, lstParams);

            Domain objDomain = new Domain();
            if (dt.Rows.Count > 0)
            {
                objDomain.Name = dt.Rows[0]["Name"].ToString();
                objDomain.Details = dt.Rows[0]["Details"].ToString();
                objDomain.Rules = dt.Rows[0]["Rules"].ToString();
                objDomain.AgreementDocument = dt.Rows[0]["AgreementDocument"].ToString();
               
                objDomain.DomainID = Convert.ToInt32(dt.Rows[0]["DomainID"]);
            }

            return objDomain;
        }

        public DataTable SelectAll()
        {
            string query = "select * from domain";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            return DBUtility.SelectData(query, lstParams);
        }

        public bool ValidateUser(string userName, string password)
        {
            return true;
        }

        public DataTable Search(string Name)
        {
            string query = "select * from domain where Name like @Name + '%'";

            List<SqlParameter> lstP = new List<SqlParameter>();
            lstP.Add(new SqlParameter("@Name", Name));

            return DBUtility.SelectData(query, lstP);
        }
    }
}
