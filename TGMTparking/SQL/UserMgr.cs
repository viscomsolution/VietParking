using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGMTcs;

namespace TGMTparking.DBmgr
{
    class User
    {
        [DisplayName("ID")]
        public string id { get; set; }
        [DisplayName("Username")]
        public string Username { get; set; }
        [DisplayName("Họ tên")]
        public string FullName { get; set; }
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }
        [Browsable(false), DisplayName("Ngày tạo")]
        public DateTime TimeCreate { get; set; }
        [Browsable(false), DisplayName("Ngày sửa")]
        public DateTime TimeUpdate { get; set; }
        [Browsable(false)]
        public string Password { get; set; }       
        [Browsable(false)]
        public string Level { get; set; }
        [Browsable(false)]
        public string OTP { get; set; }
        [Browsable(false)]
        public DateTime OTPValidTo { get; set; }
        [Browsable(false)]
        public string Status { get; set; }
        [Browsable(false)]
        public bool IsDeleted { get; set; }

        public User()
        {
            TimeCreate = DateTime.Now;
            IsDeleted = false;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Insert()
        {
            string sql = string.Format("INSERT INTO User(Username, FullName, Phone, TimeCreate, TimeUpdate, Password" +
                ", Level, Status) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                Username,
                FullName,
                Phone,
                TimeCreate.ToString("yyyy-MM-dd HH:mm:ss"),
                TimeUpdate.ToString("yyyy-MM-dd HH:mm:ss"),
                Password,
                Level,
                Status);
            TGMTsqlite.GetInstance().ExecuteNonQuery(sql);
            return true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Update()
        {
            TimeUpdate = DateTime.Now;

            string sql = string.Format("UPDATE User set " +
                "Username='{0}', " +
                "FullName='{1}', " +
                "Phone='{2}', " +
                "TimeUpdate='{3}', " +
                "Password='{4}', " +
                "Level='{5}', " +
                "Status='{6}' " +
                "where id='{7}'",
                Username,
                FullName,
                Phone,
                TimeUpdate.ToString("yyyy-MM-dd HH:mm:ss"),
                Password,
                Level,
                Status,
                id);
            TGMTsqlite.GetInstance().ExecuteNonQuery(sql);
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    class UserMgr
    {
        public static List<User> Users;
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string FormatUser(string user)
        {
            user = user.Replace(" ", "");
            return user;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool LoadUserList()
        {
            Users = null;

            string sql = string.Format("select * from User where IsDeleted=0");
            DataSet ds = TGMTsqlite.GetInstance().LoadData(sql);
            if (ds == null)
                return false;

            DataTable tbl = ds.Tables[0];
            if (tbl.Rows.Count == 0)
                return false;

            Users = new List<User>();
            int index = 1;
            foreach (DataRow row in tbl.Rows)
            {
                User user = new User
                {
                    id = row["id"].ToString(),
                    Username = row["Username"].ToString(),
                    FullName = row["FullName"].ToString(),
                    Phone = row["Phone"].ToString(),
                    TimeCreate = DateTime.Parse(row["TimeCreate"].ToString()),
                    TimeUpdate = DateTime.Parse(row["TimeUpdate"].ToString()),
                    Password = row["Password"].ToString(),
                    Level = row["Level"].ToString(),
                    Status = row["Status"].ToString()
                };

                Users.Add(user);
                index++;
            }

            return Users.Count > 0;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static User GetUser(string username)
        {
            if (Users == null || Users.Count == 0)
                return null;
            foreach (User user in Users)
            {
                if(user.Username == username)
                {
                    return user;
                }                
            }
            return null;
        }
    }
}
