using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Table
    {
        private static Card slot1;
        public static Card Slot1
        {
            get { return slot1; }
            set
            {
                slot1 = value;
                cardValue++;
            }
        }
        public static void RemoveSlot1()
        {
            slot1 = null;
            cardValue--;
        }

        private static Card slot2;
        public static Card Slot2
        {
            get { return slot2; }
            set
            {
                slot2 = value;
                cardValue++;
            }
        }
        public static void RemoveSlot2()
        {
            slot2 = null;
            cardValue--;
        }

        private static Card slot3;
        public static Card Slot3
        {
            get { return slot3; }
            set
            {
                slot3 = value;
                cardValue++;
            }
        }
        public static void RemoveSlot3()
        {
            slot3 = null;
            cardValue--;
        }

        private static Card slot4;
        public static Card Slot4
        {
            get { return slot4; }
            set
            {
                slot4 = value;
                cardValue++;
            }
        }
        public static void RemoveSlot4()
        {
            slot4 = null;
            cardValue--;
        }

        private static Card slot5;
        public static Card Slot5
        {
            get { return slot5; }
            set
            {
                slot5 = value;
                cardValue++;
            }
        }
        public static void RemoveSlot5()
        {
            slot5 = null;
            cardValue--;
        }

        private static Card slot6;
        public static Card Slot6
        {
            get { return slot6; }
            set
            {
                slot6 = value;
                cardValue++;
            }
        }
        public static void RemoveSlot6()
        {
            slot6 = null;
            cardValue--;
        }

        public static int cardValue = 0;
        private static readonly Random random = new Random();

        public static void Distribution(ref List<Card> deck)
        {
            if (deck.Count > 0)
            {
                if (Slot1 == null)
                {
                    int index = random.Next(0, deck.Count);
                    Slot1 = deck[index];
                    deck.RemoveAt(index);
                }
                if (Slot2 == null)
                {
                    int index = random.Next(0, deck.Count);
                    Slot2 = deck[index];
                    deck.RemoveAt(index);
                }
                if (Slot3 == null)
                {
                    int index = random.Next(0, deck.Count);
                    Slot3 = deck[index];
                    deck.RemoveAt(index);
                }
                if (Slot4 == null)
                {
                    int index = random.Next(0, deck.Count);
                    Slot4 = deck[index];
                    deck.RemoveAt(index);
                }
                if (Slot5 == null)
                {
                    int index = random.Next(0, deck.Count);
                    Slot5 = deck[index];
                    deck.RemoveAt(index);
                }
                if (Slot6 == null)
                {
                    int index = random.Next(0, deck.Count);
                    Slot6 = deck[index];
                    deck.RemoveAt(index);
                }
            }
        }
        public static void Reset()
        {
            Slot1 = null;
            Slot2 = null;
            Slot3 = null;
            Slot4 = null;
            Slot5 = null;
            Slot6 = null;
            cardValue = 0;
        }
    }
}
