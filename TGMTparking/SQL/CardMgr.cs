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
    public class Card
    {
        [Browsable(false)]
        public string id { get; set; }
        public string STT { get; set; }
        [DisplayName("Mã thẻ")]
        public string CardID { get; set; }
        [DisplayName("Số thẻ")]
        public string CardNumber { get; set; }
        [DisplayName("Trạng thái")]
        public string Status { get; set; } //Đang dùng, Chưa dùng, Đã mất
        [DisplayName("Giờ cập nhật")]
        public DateTime TimeUpdate { get; set; } //Using, Free, Lost
        [Browsable(false)]
        public bool IsDeleted { get; set; }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Card()
        {
            IsDeleted = false;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Insert()
        {
            if(CardMgr.IsCardExist(CardID))
            {
                MsgBox.Show("Đã có thẻ " + CardID);
                return false;
            }
            string sql = string.Format("INSERT INTO Card(CardID, TimeUpdate, IsDeleted) VALUES('{0}','{1}','{2}')",
                CardID,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                false);


            TGMTsqlite.GetInstance().ExecuteNonQuery(sql);
            return true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Update()
        {
            string sql = string.Format("UPDATE Card set Status='{0}', TimeUpdate='{1}' where CardID='{2}'",
                Status,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                CardID);
            TGMTsqlite.GetInstance().ExecuteNonQuery(sql);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Delete()
        {
            string sql = string.Format("UPDATE Card set IsDeleted='{0}', TimeUpdate='{1}' where CardID='{2}'",
                true,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                CardID);
            TGMTsqlite.GetInstance().ExecuteNonQuery(sql);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Reset()
        {
            string sql = string.Format("UPDATE Card set Status='{0}', TimeUpdate='{1}' where CardID='{2}'",
                "Chưa dùng",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                CardID);
            TGMTsqlite.GetInstance().ExecuteNonQuery(sql);
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    class CardMgr
    {
        public static List<Card> Cards;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool LoadCardList(bool free = true, bool isusing = true, bool lost = true)
        {
            Cards = new List<Card>();

            string sql = string.Format("select * from Card where IsDeleted='{0}'", false);
            DataSet ds = TGMTsqlite.GetInstance().LoadData(sql);
            if (ds == null)
                return false;

            DataTable tbl = ds.Tables[0];
            if (tbl.Rows.Count == 0)
                return false;

            foreach(DataRow row in tbl.Rows)
            {
                Card card = new Card
                {
                    id = row["id"].ToString(),
                    CardID = row["CardID"].ToString(),
                    CardNumber = row["CardNumber"].ToString(),
                    
                    Status = row["Status"].ToString(),
                    IsDeleted = row["IsDeleted"].ToString() == "1",
                };

                if(row["TimeUpdate"] != null && row["TimeUpdate"].ToString() != "")
                {
                    card.TimeUpdate = DateTime.Parse(row["TimeUpdate"].ToString());
                }
                


                if (!isusing && card.Status == "Đang dùng")
                    continue;
                if (!free && card.Status == "Chưa dùng")
                    continue;
                if (!lost && card.Status == "Đã mất")
                    continue;

                card.STT = (CardMgr.Cards.Count + 1).ToString();

                Cards.Add(card);
            }

            return Cards.Count > 0;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int CountNotUisng()
        {
            int count = 0;
            for(int i=0; i< Cards.Count; i++)
            {
                if (Cards[i].Status == "Chưa dùng")
                    count++;
            }
            return count;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Card GetCard(string cardID)
        {
            if (Cards == null)
                return null;
            foreach (Card card in Cards)
            {
                if (card.CardID == cardID)
                    return card;
            }
            return null;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool IsCardExist(string cardID)
        {
            Card card = GetCard(cardID);
            return card != null;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool DeleteCard(string cardID)
        {
            foreach (Card card in Cards)
            {
                if (card.CardID == cardID)
                {
                    card.Delete();
                    LoadCardList();
                    return true;
                }
            }
            return false;
        }

    }
}
