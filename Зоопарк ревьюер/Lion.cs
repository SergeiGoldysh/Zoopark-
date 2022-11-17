using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зоопарк_ревьюер
{
    public class Lion : Mammals, Interface1
    {
        public Lion(string name) : base(name)
        {
        }

        public void GetInfo()
        {
            Detachment();
            Info();
            AnimalSound();
        }

        public void AnimalSound()
        {
            Console.WriteLine("Лев издает такой звук: Roooaaaarrrrr!!!!!");
        }

        public void Detachment()
        {
            Console.WriteLine("Лев из отряда - Хищных (“плотоядных”) животных - питаются другими животными.");
        }

        public void Info()
        {
            Console.WriteLine("Лев — вид хищных млекопитающих," +
            " один из пяти представителей рода пантер (Panthera)," +
            " относящегося к подсемейству больших кошек в составе семейства" +
            " кошачьих. Наряду с тигром — самая крупная из ныне живущих кошек," +
            " масса некоторых самцов может достигать 250 кг");
        }
    }

}
