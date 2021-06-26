using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Planet
    {
        private static readonly int max = 1;
        private static int type;
        public static int Type
        {
            get { return type; }
            set
            {
                if (value < 0) type = max;
                if (value > max) type = 0;
                type = value;
            }
        }

        public static List<Card> GetDeck()
        {
            switch (Type)
            {
                case 0: return new List<Card>
                {
                    new EnemyCard("Навозник", 3, 2),
                    new EnemyCard("Навозник", 3, 2),
                    new EnemyCard("Навозник", 3, 2),
                    new EnemyCard("Рогач", 4, 5),
                    new EnemyCard("Рогач", 4, 5),
                    new EnemyCard("Гипнобабочка", 5, 5),
                    new EnemyCard("Гипнобабочка", 5, 5),
                    new EnemyCard("Стрекоза костолом", 12, 10),
                    new EnemyCard("Кровавый пронзатель", 8, 16),

                    new WeaponCard("Плазмо нож", 2, 2),
                    new WeaponCard("Плазмо нож", 2, 3),
                    new WeaponCard("Электроплеть", 2, 5),
                    new WeaponCard("Лазерный пистолет", 4, 2),
                    new WeaponCard("Лазерный пистолет", 5, 2),

                    new ArmorCard("Стильные очки", ArmorCard.Slot.Helmet, 1, 0),
                    new ArmorCard("Каска в краске", ArmorCard.Slot.Helmet, 2, 2),
                    new ArmorCard("Шлем астронавта", ArmorCard.Slot.Helmet, 3, 4),

                    new ArmorCard("Корпус ржавого робота", ArmorCard.Slot.Breastplate, 2, 6),
                    new ArmorCard("Энергетическая кираса", ArmorCard.Slot.Breastplate, 4, 4),

                    new ArmorCard("Прыгательные ботинки", ArmorCard.Slot.Boots, 2, 8),
                    new ArmorCard("Элктротопот 220V", ArmorCard.Slot.Boots, 3, 6),

                    new HealCard("Пластырь", 2),
                    new HealCard("Пластырь", 2),
                    new HealCard("Пластырь", 2),
                    new HealCard("Антисептик с нанороботами", 3),
                    new HealCard("Космический подорожник", 4),
                    new HealCard("Космический подорожник", 4),
                    new HealCard("Сухпаёк космонавта", 8),
                    new HealCard("Имплант", 10),
                    new HealCard("Ржавый имплант", 6),
                };
                case 1: return new List<Card>
                {

                };
            }
            return null;
        }
    }
}
