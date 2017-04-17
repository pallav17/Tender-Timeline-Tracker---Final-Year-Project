using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLogic
{
    public class MemberLogic : ILogic<Member>
    {
        public int Insert(Member objMember)
        {
            string query = "insert member values (@name, @Email, @Phone, @Username, @Password); SELECT @@IDENTITY;";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@name", objMember.Name));
            lstParams.Add(new SqlParameter("@Email", objMember.Email));
            lstParams.Add(new SqlParameter("@Phone", objMember.Phone));
            lstParams.Add(new SqlParameter("@Username", objMember.Username));
            lstParams.Add(new SqlParameter("@Password", objMember.Password));

            DataTable dt = DBUtility.SelectData(query, lstParams);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public int Update(Member objMember)
        {
            string query = "update member set name = @name, email = @email, Phone = @phone, Username = @Username, Password = @password WHERE MemberID = @MemberID";

            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@name", objMember.Name));
            lstParams.Add(new SqlParameter("@Email", objMember.Email));
            lstParams.Add(new SqlParameter("@Phone", objMember.Phone));
            lstParams.Add(new SqlParameter("@Username", objMember.Username));
            lstParams.Add(new SqlParameter("@Password", objMember.Password));
            lstParams.Add(new SqlParameter("@MemberID", objMember.MemberID));

            return DBUtility.ModifyData(query, lstParams);
        }

        public int Delete(int MemberID)
        {
            string query = "delete member WHERE MemberID = @MemberID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@MemberID", MemberID));

            return DBUtility.ModifyData(query, lstParams);
        }

        public Member SelectByID(int MemberID)
        {
            string query = "select * from member WHERE MemberID = @MemberID";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@MemberID", MemberID));

            DataTable dt = DBUtility.SelectData(query, lstParams);

            Member objMember = new Member();
            if (dt.Rows.Count > 0)
            {
                objMember.Name = dt.Rows[0]["Name"].ToString();
                objMember.Email = dt.Rows[0]["Email"].ToString();
                objMember.Phone = dt.Rows[0]["Phone"].ToString();
                objMember.Username = dt.Rows[0]["Username"].ToString();
                objMember.Password = dt.Rows[0]["Password"].ToString();
                objMember.MemberID = Convert.ToInt32(dt.Rows[0]["MemberID"]);
            }

            return objMember;
        }

        public DataTable SelectAll()
        {
            string query = "select * from member";
            List<SqlParameter> lstParams = new List<SqlParameter>();
            return DBUtility.SelectData(query, lstParams);
        }

        public bool ValidateUser(string username, string password)
        {
            return true;
        }

        public DataTable Search(string name)
        {
            string query = "select * from member where Name like @name + '%'";

            List<SqlParameter> lstP = new List<SqlParameter>();
            lstP.Add(new SqlParameter("@name", name));

            return DBUtility.SelectData(query, lstP);
        }
    }
}
