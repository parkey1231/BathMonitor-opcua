using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    //定义委托，它定义了可以代表的方法的类型
    public delegate void GreetingDelegate(string name);
    //新建的GreetingManager类
    public class GreetingManager
    {
        public GreetingDelegate delegate1;
        //这一次我们在这里声明一个事件
        public event GreetingDelegate MakeGreet;
        public void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }
        //public void GreetPeople(string name)
        //{
        //    //if(delegate1 != null) delegate1(name);
        //    delegate1?.Invoke(name);//这个是简化版
        //}
        public void GreetPeople(string name)
        {
            MakeGreet(name);
        }
    }
    class Program
    {
        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }
        static void Main(string[] args)
        {
            GreetingManager gm = new GreetingManager( );
            gm.GreetPeople("mk", EnglishGreeting);
            gm.GreetPeople("lj", ChineseGreeting);
            Console.WriteLine("-----------------------------------------");
            GreetingDelegate delegate1;
            delegate1 = EnglishGreeting;
            delegate1 += ChineseGreeting;
            gm.GreetPeople("Jimmy Zhang", delegate1);
            Console.WriteLine("-----------------------------------------");
            //gm.delegate1  = ChineseGreeting;
            //gm.delegate1 += EnglishGreeting;
            //gm.delegate1 = new GreetingDelegate(EnglishGreeting);
            gm.delegate1 = ChineseGreeting;
            gm.GreetPeople("parkey", gm.delegate1);
            Console.WriteLine("-----------------------------------------");
            GreetingManager greeting = new GreetingManager( );
            greeting.MakeGreet += ChineseGreeting;
            greeting.MakeGreet += EnglishGreeting;
            greeting.GreetPeople("dy");

            Console.WriteLine("-----------------------------------------");
            //：事件应该由事件的发布者触发，而不应该由事件的客户端（客户程序）来触发
            Publisher pub = new Publisher( );
            Subcriber sub = new Subcriber( );
            pub.NumberChanged += new NumberChangedEventHandler(sub.OnNumberChanged);
            pub.DoSomething( );
            //pub.NumberChanged(100);
            
            Console.ReadLine( );


        }
        // 定义委托
        public delegate void NumberChangedEventHandler(int count);
        //定义事件发布者
        public class Publisher
        {
            private int count;
            //public NumberChangedEventHandler NumberChanged; // 声明委托变量
            public event NumberChangedEventHandler NumberChanged;        // 声明一个事件
            public void DoSomething( )
            {
                //完成一些工作......
                if(NumberChanged != null)
                {
                    count++;
                    NumberChanged(count);
                }

            }
        }

        //定义事件订阅
        public class Subcriber
        {
            public void OnNumberChanged(int count)
            {
                Console.WriteLine("Subsciber no tified: count = {0}", count);
            }
        }




    }
}
