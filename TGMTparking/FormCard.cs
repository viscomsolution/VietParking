using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;
using TGMTparking.DBmgr;
using TGMTparking.Module;

namespace TGMTparking.UI
{
    

    public partial class FormCard : Form
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormCard()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormCard_Load(object sender, EventArgs e)
        {
            LoadCardList();
            TGMTsqlite.GetInstance().RemovePassword();

            //string cardReader = TGMTini.GetInstance().Read("card_reader", "Common");
            //if(cardReader == "1")
            //    ConnectCardReader();
            //else if(cardReader == "2")
            //{
            //    if (!AccessControlMgr.GetInstance().Connected)
            //    {

            //    }

            if(CardReaderMgr.GetInstance().IsConnected)
            {
                lblCardReader.Text = "Card reader: YES";
                lblCardReader.ForeColor = Color.White;
            };

            CardReaderMgr.GetInstance().onCardAppear += OnCardAppearHandler;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void OnCardAppearHandler(object sender, BoardEventArgs e)
        {
            this.Invoke(new Action(() => { OnCardVisible(e.cardID); }));
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void OnCardVisible(string cardID)
        {
            AddCardToGridview(cardID);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void AddCardToGridview(string cardID)
        {
            cardID = cardID.ToUpper();
            if (cardID == "")
            {
                PrintError("Cannot read card");
                return;
            }
            var card = CardMgr.Cards.FirstOrDefault(cc => cc.CardID == cardID);


            if (card == null) //card not exist in list
            {
                card = new Card()
                {
                    STT = (CardMgr.Cards.Count + 1).ToString(),
                    CardID = cardID,
                    CardNumber = "", 
                };

                if(card.Insert())
                {
                    CardMgr.Cards.Add(card);


                    grid_card.DataSource = null;
                    grid_card.DataSource = CardMgr.Cards;

                    PrintSuccess("Thêm thẻ thành công");
                }
            }
            else
            {
                PrintError("Thẻ đã tồn tại");
                timerClear.Start();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintError(string msg)
        {
            lblMessage.Text = msg;
            lblMessage.ForeColor = Color.Red;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintSuccess(string msg)
        {
            lblMessage.Text = msg;
            lblMessage.ForeColor = Color.White;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void LoadCardList()
        {
            grid_card.DataSource = null;
            bool loadSuccess = CardMgr.LoadCardList(chk_free.Checked, chk_using.Checked, chk_lost.Checked);

            if(loadSuccess)
            {
                grid_card.DataSource = CardMgr.Cards;
            }
            else
            {
                PrintError("Không tìm thấy thẻ");
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void timerClear_Tick(object sender, EventArgs e)
        {
            PrintError("");
            timerClear.Stop();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            CardReaderMgr.GetInstance().onCardAppear -= OnCardAppearHandler;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (grid_card.SelectedRows.Count == 0)
                return;

            var row = grid_card.SelectedRows[0];
            var cells = row.Cells;
            string cardID = cells["cardID"].Value.ToString();

            Card card = CardMgr.GetCard(cardID);
            card.IsDeleted = true;
            card.Update();
            LoadCardList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_lost_Click(object sender, EventArgs e)
        {
            if (grid_card.SelectedRows.Count == 0)
                return;

            var row = grid_card.SelectedRows[0];
            var cells = row.Cells;
            string cardID = cells["cardID"].Value.ToString();

            Card card = CardMgr.GetCard(cardID);
            if(card.Status == "Đã mất")
            {
                MsgBox.Show("Thẻ đã báo mất");
                return;
            }
            card.Status = "Đã mất";
            card.Update();

            LoadCardList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chk_using_CheckedChanged(object sender, EventArgs e)
        {
            LoadCardList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chk_free_CheckedChanged(object sender, EventArgs e)
        {
            LoadCardList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chk_lost_CheckedChanged(object sender, EventArgs e)
        {
            LoadCardList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_found_Click(object sender, EventArgs e)
        {
            if (grid_card.SelectedRows.Count == 0)
                return;

            var row = grid_card.SelectedRows[0];
            var cells = row.Cells;
            string cardID = cells["cardID"].Value.ToString();

            Card card = CardMgr.GetCard(cardID);
            card.Status = "Chưa dùng";
            card.Update();

            LoadCardList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void grid_card_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = grid_card.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow < 0)
                {
                    return;
                }

                var row = grid_card.Rows[currentMouseOverRow];
                var cells = row.Cells;
                string cardID = cells["cardID"].Value.ToString();

                Card card = CardMgr.GetCard(cardID);
                if (card.Status == "Đã mất")
                {
                    btn_found.Visible = true;
                    btn_lost.Visible = false;
                }
                else
                {
                    btn_found.Visible = false;
                    btn_lost.Visible = true;
                }
                ctx_menu.Show(grid_card, new Point(e.X, e.Y));
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (grid_card.SelectedRows.Count == 0)
                return;

            var row = grid_card.SelectedRows[0];
            string cardID = row.Cells["cardID"].Value.ToString();


            Session session = SessionMgr.QueryByCard(cardID);
            if(session != null)
            {
                if(session.CardID == cardID)
                {
                    MsgBox.Show("Vui lòng cho xe ra trước khi reset thẻ");
                    return;
                }
            }

            Card card = CardMgr.GetCard(cardID);
            card.Status = "Chưa dùng";
            card.Update();

            LoadCardList();
        }
    }
}
