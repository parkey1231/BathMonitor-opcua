﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public class Heater
    {
        private int temperature;//水温
        //烧水
        public void BoilWater( )
        {
            for(int i = 0; i <= 100; i++)
            {
                temperature = i;
                if(temperature>95)
                {
                    MakeAlert(temperature);
                    ShowMsg(temperature);
                }
            }
        }
        //发出语音报警
        private void MakeAlert(int param)
        {
            Console.WriteLine("Alarm:滴滴滴，水已经{0}度了：",param);
        }
        //显示水温
        private void ShowMsg(int param)
        {
            Console.WriteLine("Alarm:水快开了，当前温度：{0}度：", param);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Heater ht = new Heater( );
            ht.BoilWater( );
        }
    }

}
