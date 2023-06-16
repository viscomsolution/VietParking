using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;
using TGMTparking.UI;

namespace TGMTparking.DBmgr
{
    public class Session
    {
        [DisplayName("ID")]
        public string id { get; set; }
        [DisplayName("Biển số vào")]
        public string PlateCheckin { get; set; }
        [DisplayName("Biển số ra")]
        public string PlateCheckout { get; set; }
        [DisplayName("Mã thẻ")]
        public string CardID { get; set; }
        [DisplayName("Giờ vào")]
        public DateTime CheckinTime { get; set; }
        [DisplayName("Giờ ra")]
        public DateTime CheckoutTime { get; set; }
        [Browsable(false)]
        public string ImagePaths { get; set; }
        [DisplayName("Loại xe")]
        public string VehicleType { get; set; }
        [DisplayName("Trạng thái")]
        public string Status { get; set; }
        [DisplayName("NV checkin")]
        public string StaffCheckin { get; set; }
        [DisplayName("NV checkout")]
        public string StaffCheckout { get; set; }
        [Browsable(false)]
        public bool IsDeleted { get; set; }
        

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Session()
        {
            IsDeleted = false;
            VehicleType = "Xe hơi";
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Update()
        {
            string sql = string.Format("UPDATE Session set " +
                "PlateCheckout='{0}'," +
                "CheckoutTime='{1}', " +
                "ImagePaths='{2}', " +
                "Status='{3}'," +
                "StaffCheckout='{4}'" +
                "where" +
                " id='{5}'",
                PlateCheckout,
                CheckoutTime.ToString("yyyy-MM-dd HH:mm:ss"),
                ImagePaths,
                Status,
                StaffCheckout,
                id);


            TGMTsqlite.GetInstance().ExecuteNonQuery(sql);
            return true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Insert()
        {
            string sql = string.Format("INSERT INTO Session(PlateCheckin, PlateCheckout, CardID, CheckinTime, " +
                "ImagePaths, VehicleType, Status, StaffCheckin, StaffCheckout) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                PlateCheckin,
                PlateCheckout,
                CardID,
                CheckinTime.ToString("yyyy-MM-dd HH:mm:ss"),
                ImagePaths,
                VehicleType,
                Status,
                StaffCheckin,
                StaffCheckout);


            TGMTsqlite.GetInstance().ExecuteNonQuery(sql);
            return true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //public static SessionBson LoadSession(string cardID)
        //{
        //    var filter = Builders<SessionBson>.Filter.And(
        //        Builders<SessionBson>.Filter.Eq("cardID", cardID),
        //        Builders<SessionBson>.Filter.Eq("isCheckedOut", false),
        //        Builders<SessionBson>.Filter.Eq("isDeleted", false));


        //    var collection = TGMTmongo.GetInstance().m_database.GetCollection<SessionBson>("session");
        //    var sessionBsons = collection.Find(filter).ToListAsync().Result;
        //    if (sessionBsons.Count == 0)
        //        return null;

        //    SessionBson sessionBson = sessionBsons[0];
        //    return sessionBson;
        //}

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //public static SessionBson LoadSessionByPk(string _pk)
        //{
        //    var filter = Builders<SessionBson>.Filter.And(
        //        Builders<SessionBson>.Filter.Eq("_id", _pk),
        //        Builders<SessionBson>.Filter.Eq("isCheckedOut", false),
        //        Builders<SessionBson>.Filter.Eq("isDeleted", false));


        //    var collection = TGMTmongo.GetInstance().m_database.GetCollection<SessionBson>("session");
        //    var sessionBsons = collection.Find(filter).ToListAsync().Result;
        //    if (sessionBsons.Count == 0)
        //        return null;

        //    SessionBson sessionBson = sessionBsons[0];
        //    return sessionBson;
        //}
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public class SessionMgr
    {
        public static List<Session> Sessions;

        public static bool LoadSession(bool checkin, bool checkout, DateTime fromDate, DateTime toDate, bool sortAsc, string plate = "")
        {
            Sessions = new List<Session>();
            string sql = string.Format("select * from Session where IsDeleted=0 and CheckinTime>='{0}' and CheckinTime <='{1}'",
                fromDate.ToString("yyyy-MM-dd HH:mm:ss"),
                toDate.ToString("yyyy-MM-dd HH:mm:ss"));

            DataSet ds = TGMTsqlite.GetInstance().LoadData(sql);
            if (ds == null)
                return false;

            DataTable tbl = ds.Tables[0];
            if (tbl.Rows.Count == 0)
                return false;

            foreach (DataRow row in tbl.Rows)
            {
                Session session = new Session
                {
                    id = row["id"].ToString(),
                    PlateCheckin = row["PlateCheckin"].ToString(),
                    PlateCheckout = row["PlateCheckout"].ToString(),
                    CardID = row["CardID"].ToString(),
                    CheckinTime = DateTime.Parse(row["CheckinTime"].ToString()),
                    ImagePaths = row["ImagePaths"].ToString(),
                    Status = row["Status"].ToString(),
                    StaffCheckin = row["StaffCheckin"].ToString(),
                    StaffCheckout = row["StaffCheckout"].ToString()
                };

                if(row["CheckoutTime"] != null && row["CheckoutTime"].ToString() != "")
                {
                    session.CheckoutTime = DateTime.Parse(row["CheckoutTime"].ToString());
                }
                

                if (plate != "")
                {
                    if (!session.PlateCheckin.Contains(plate) && !session.PlateCheckout.Contains(plate))
                    {
                        continue;
                    }
                }
                if(checkin && checkout)
                {
                    
                }
                else if(checkin)
                {
                    if (session.Status == "Đã về")
                        continue; ;
                }
                else if(checkout)
                {
                    if (session.Status == "Trong bãi")
                        continue; ;
                }
                else
                {
                    continue;
                }

                //session.CheckinTime = session.CheckinTime.AddHours(7);
                //if (session.CheckoutTime.Year != 1)
                //{
                //    session.CheckoutTime = session.CheckoutTime.AddHours(7);
                //}
                Sessions.Add(session);

                //if (!isusing && card.Status == "using")
                //    continue;
                //if (!free && card.Status == "free")
                //    continue;
                //if (!lost && card.Status == "lost")
                //    continue;
            }



            if (!sortAsc)
                Sessions = Sessions.OrderByDescending(o => o.CheckinTime).ToList();

            return Sessions.Count > 0;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int CountInParkingSession()
        {
            Sessions = new List<Session>();
            string sql = string.Format("select * from Session where IsDeleted=0 and Status='Trong bãi'");

            DataSet ds = TGMTsqlite.GetInstance().LoadData(sql);
            if (ds == null)
                return 0;

            DataTable tbl = ds.Tables[0];
            return tbl.Rows.Count;            
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Session QueryByCard(string cardID)
        {
            //Cards = new List<Card>();

            string sql = string.Format("select * from Session where IsDeleted='0' and Status='{1}' and CardID='{2}'", false, "Trong bãi", cardID);
            DataSet ds = TGMTsqlite.GetInstance().LoadData(sql);
            if (ds == null)
                return null;

            DataTable tbl = ds.Tables[0];
            if (tbl.Rows.Count == 0)
                return null;
            else if(tbl.Rows.Count > 1)
            {
                MsgBox.Show("Tìm thấy 2 lượt xe đang dùng thẻ " + cardID);
                return null;
            }

            DataRow row = tbl.Rows[0];
            Session s = new Session
            {
                id = row["id"].ToString(),
                PlateCheckin = row["PlateCheckin"].ToString(),
                CardID = row["CardID"].ToString(),
                CheckinTime = DateTime.Parse(row["CheckinTime"].ToString()),
                ImagePaths = row["ImagePaths"].ToString(),
                VehicleType = row["VehicleType"].ToString(),
                Status = row["Status"].ToString(),
                StaffCheckin = row["StaffCheckin"].ToString()
            };
            return s;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Session FindByPlate(string plate)
        {
            string sql = string.Format("select * from Session where IsDeleted=0 and PlateCheckin='{0}' and Status='{1}'",
                plate, "Trong bãi");
            DataSet ds = TGMTsqlite.GetInstance().LoadData(sql);
            if (ds == null)
                return null;

            DataTable tbl = ds.Tables[0];
            if (tbl.Rows.Count == 0)
                return null;
            else if (tbl.Rows.Count > 1)
            {
                MsgBox.Show("Tìm thấy 2 lượt xe trong bãi có cùng biển số: " + plate);
                return null;
            }

            DataRow row = tbl.Rows[0];
            Session s = new Session
            {
                id = row["id"].ToString(),
                PlateCheckin = row["PlateCheckin"].ToString(),
                CardID = row["CardID"].ToString(),
                CheckinTime = DateTime.Parse(row["CheckinTime"].ToString()),
                VehicleType = row["VehicleType"].ToString(),
                Status = row["Status"].ToString(),
                StaffCheckin = row["StaffCheckin"].ToString()
            };
            return s;
        }
    }
}
