using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseLibrary
{
    public class Parse
    {
        List<TemplateAdress> tempAdress = new List<TemplateAdress>();

        public void GetAdres(string address)
        {
            Console.WriteLine(address + "\n");

            // убрали пробелы и разделили в массив по запятой
            string[] words = address.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            int literaIndex = GetLitera(words);
            int korpusIndex = GetKorpus(words);
            int houseIndex = GetHouse(words);
            int toponimIndex = GetToponim(words);

            //   if (words[1].Contains("улица"))
            //   {
            tempAdress.Add(new TemplateAdress() { Region = words[0], City = "" , Toponim = (toponimIndex != -1) ? words[toponimIndex] : "", House = (houseIndex != -1) ? words[houseIndex] : "", Korpus = (korpusIndex != -1) ? words[korpusIndex] : "", Litera = (literaIndex != -1) ? words[literaIndex] : "" });
        //    }


            foreach ( TemplateAdress t in tempAdress)
            {

                Console.WriteLine("Region: " + t.Region);
                Console.WriteLine("City: " + t.City);
                Console.WriteLine("Toponim: " + t.Toponim);
                Console.WriteLine("House: " + t.House);
                Console.WriteLine("Korpus: " + t.Korpus);
                Console.WriteLine("Litera: " + t.Litera);

            }

            Console.WriteLine();
        }

        /// <summary>
        /// Возвращает индекс массива, если встречает топоним. -1 иначе
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        static int GetToponim(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower().Contains("улица")      || words[i].ToLower().Contains("проспект")  || words[i].ToLower().Contains("проезд")   || 
                    words[i].ToLower().Contains("шоссе")      || words[i].ToLower().Contains("пост")      || words[i].ToLower().Contains("линия")    ||
                    words[i].ToLower().Contains("набережная") || words[i].ToLower().Contains("переулок")  || words[i].ToLower().Contains("площадь")  ||
                    words[i].ToLower().Contains("канал")      || words[i].ToLower().Contains("аллея")     || words[i].ToLower().Contains("порта")    ||
                    words[i].ToLower().Contains("бульвар")    || words[i].ToLower().Contains("проток")    || words[i].ToLower().Contains("дорога")   ||
                    words[i].ToLower().Contains("станция")    || words[i].ToLower().Contains("мост")      || words[i].ToLower().Contains("кладбище") ||
                    words[i].ToLower().Contains("путепровод"))
                {
                    return i;
                }
            }

            return -1;
        }
        /// <summary>
        /// Возвращает индекс массива, если встречает литера. -1 иначе
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        static int GetLitera(string[] words)
        {

            for ( int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower().Contains("литера"))
                {
                    return i;
                }
            }

            return -1;
        }
        /// <summary>
        /// Возвращает индекс массива, если встречает корпус. -1 иначе
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        static int GetKorpus(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower().Contains("корпус"))
                {
                    return i;
                }
            }

            return -1;
        }
        /// <summary>
        /// Возвращает индекс массива, если встречает дом. -1 иначе
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        static int GetHouse(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower().Contains("дом"))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
