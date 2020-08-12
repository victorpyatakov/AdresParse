using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParseLibrary;

namespace AdressParse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Санкт-Петербург, трасса Малой Октябрьской железной дороги 'мост через р.Кузьминку', литера Г1
            // регистр у станция - Станция

            string adress = "Санкт-Петербург, поселок Парголово, Выборгское шоссе, дом 230, Корпус 3, Литера Г";
          
            Parse parse = new Parse {};

            parse.GetAdres(adress);
            
        }
    }
}
