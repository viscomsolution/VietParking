using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardReaderService;

namespace TGMTparking.Module
{
    public class BoardEventArgs : EventArgs
    {
        public enum BoardEvents
        {
            PressButton = 0,
            CardAppear = 1,
            Disconnected
        }
        public string cardID { get; private set; }
        public int readerID { get; private set; }
        public int ButtonID { get; private set; }
        public BoardEvents Event { get; private set; }

        public BoardEventArgs(BoardEvents boardevent, string _cardID = "", int _readerID = 0)
        {
            cardID = _cardID;
            readerID = _readerID;
            Event = boardevent;
        }

        public BoardEventArgs(string _cardID = "", int _readerID = 0)
        {
            cardID = _cardID;
            readerID = _readerID;
            Event = BoardEvents.CardAppear;
        }

        public BoardEventArgs(int buttonID)
        {
            ButtonID = buttonID;
            Event = BoardEvents.PressButton;
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    class CardReaderMgr
    {
        static CardReaderMgr m_instance;
        bool m_isConnected = false;


        public delegate void OnCardAppearHandler(object sender, BoardEventArgs e);
        public OnCardAppearHandler onCardAppear;


        public delegate void OnBoardDisconnectedHandler(object sender, BoardEventArgs e);
        public OnBoardDisconnectedHandler onBoardDisconnectedHandler;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static CardReaderMgr GetInstance()
        {
            if (m_instance == null)
                m_instance = new CardReaderMgr();
            return m_instance;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public CardReaderMgr()
        {

        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool IsConnected { get { return m_isConnected;} } 

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool ConnectToCardReader()
        {
            var lst = ModWinsCardReader.ListModWinsCards();
            if (lst != null)
            {
                foreach (CardReaderInfo item in lst)
                {
                    CardReader.AddCardReaderInfo(new CardReaderInfo() { Type = "ModWinsCard", SerialNumber = item.SerialNumber, CallName = "ModWins" });
                }
                var res = CardReader.ConnectReader();
                if (res.Contains("sẵn sàng"))
                {
                    CardReader.AddEventHandler(CardReader.m_listCardReaderInfo, onReadCard, null);


                    m_isConnected = true;
                }
                else
                {
                    m_isConnected = false;
                }
            }
            else
            {
                m_isConnected = false;
            }
            return m_isConnected;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void onReadCard(object sender, CardReaderEventArgs e)
        {
            if(onCardAppear != null)
            {
                BoardEventArgs ee = new BoardEventArgs(e.CardID);
                onCardAppear?.Invoke(this, ee);
            }
        }
    }
}
