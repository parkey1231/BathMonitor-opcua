using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegataTest
{
    public delegate void GreetPeopleDelegate(string name);

    public interface IGreeting
    {
        void GreetPeople(string name);
    }
    public class EnglishGreeting : IGreeting
    {
        public void GreetPeople(string name)
        {
            Console.WriteLine("Mornig, " + name);
        }
    }
    public class ChineseGreeting : IGreeting
    {
        public void GreetPeople(string name)
        {
            Console.WriteLine("早上好, " + name);
        }
    }
    class Program
    {
        public enum Language
        {
            English, Chinese
        }

        private static void GreetPeople(string name,IGreeting greeting)
        {
            greeting.GreetPeople(name);
        }

        static void Main(string[] args)
        {
            GreetPeople("parkey");
            GreetPeople("dy", Language.Chinese);
            GreetPeople("dy", Language.English);
            GreetPeople("dy", EnglishGreeting);
            GreetPeople("dy", ChineseGreeting);
            Console.WriteLine("-------------------------------------------------");
            GreetPeopleDelegate deleg1, deleg2, deleg3;
            GreetPeopleDelegate deleg4 = new GreetPeopleDelegate(ChineseGreeting);
            deleg1 = EnglishGreeting;
            deleg2 = ChineseGreeting;
            deleg3 = EnglishGreeting;
            deleg3 += ChineseGreeting;
            deleg4 += EnglishGreeting;
            deleg3 += EnglishGreeting;
            deleg3 += ChineseGreeting;
            GreetPeople("de", deleg1);
            GreetPeople("de", deleg2);
            GreetPeople("de", deleg3);
            GreetPeople("kk", deleg4);
            Console.WriteLine("-------------------------------------------------");
            GreetPeople("dy", new EnglishGreeting( ));
            GreetPeople("dy", new ChineseGreeting( ));
            Console.ReadLine( );
        }

        public static void GreetPeople(string name)
        {
            // 做某些额外的事情，比如初始化之类，此处略
            EnglishGreeting(name);

        }
        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }


        public static void GreetPeople(string name, Language lang)
        {
            //做某些额外的事情，比如初始化之类，此处略

            switch(lang)
            {
                case Language.English:
                    EnglishGreeting(name);
                    break;
                case Language.Chinese:
                    ChineseGreeting(name);
                    break;
            }

        }
        public static void GreetPeople(string name, GreetPeopleDelegate greetPeople)
        {
            greetPeople(name);
        }


    }
}
