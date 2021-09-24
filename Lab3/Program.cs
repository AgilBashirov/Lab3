using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Integer tipli massive Array.Resize() istifade ederek yeni bir eded daxil eden method yazin.
            #region task1

            //int[] arr = { 11, 22, 33 };

            //AddNumber(ref arr, 44);

            #endregion

            // 2. "Hello World!" u byte formatina cevirib  byte[] tipinde parametr qebul edib onu stringe ceviren method yazin. 
            #region task2

            //string sentence = "Hello World!";
            //byte[] byteSentence = Encoding.UTF8.GetBytes(sentence);
            //ByteConverter(byteSentence);

            #endregion

            // 3. Verilmish cumlede yan-yana duran ilk eyni herfi tap. Misal "Hello World!" - "ll". 
            //    ve sol terefden hemin cut heriflerin sonuna kimi goturub yeni string qaytaran method yazin.
            #region task3

            //string cumle = "Hello World! ";
            //Console.WriteLine(FindTwins(cumle));

            #endregion

            // 4. Bir FullInfo() methodu yazin. 
            //    Hansi ki Ad, Soyad, Yashini bir stringde daxil etdikde bolshluga gore bolub StringBuildere birleshdirib consola chap etsin.
            #region task4

            //string info = "Agil Bashirov 27";

            //FullInfo(info);

            #endregion

            // 5. string[] massivinde olke adlarinin evveli I herfi ile bashlayib,
            //    sonu land -ile olanlari sechen method yazin. EndsWith()(England, Finland, Iceland, Ireland)
            #region task5

            //string[] countries = { "England", "Finland", "Iceland", "Ireland" };

            //SelectByEdge(countries,"i","land");

            #endregion

            // 6. "T-shirt", "Jacket", "Sweater", "Shirt", "Jeans" sozleri yerleshen massivden 
            //    "shir" yazaraq => "T-Shirt" ve "Shirt" i sechin.
            #region task6

            //string[] clothers = { "T-shirt", "Jacket", "Sweater", "Shirt", "Jeans" };

            //Search(clothers, "shir");

            #endregion

            // 7. "on bir sifir doqquz iki min bir" cunlesinde nece "bir" sozu oldugunu ve dayandiqlari indexleri goster.
            #region task7

            //string sentence = "on bir sifir doqquz iki min bir";
            //string word = "bir";
            //FindIndex(sentence, word);

            #endregion

        }

        //1
        static void AddNumber(ref  int[] arr, int n)
        {
            Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length - 1] = n;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        //2
        static void ByteConverter(byte[] arr)
        {
            string sentence = Encoding.UTF8.GetString(arr);
            Console.WriteLine(sentence);
        }

        //3
        static string FindTwins(string cumle)
        {
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == cumle[i + 1])
                {
                    int index = i;
                    cumle = cumle.Substring(0, index + 2);
                    break;
                }
            }


            return cumle;
        }

        //4
        static void FullInfo(string info)
        {
            StringBuilder sb = new StringBuilder();

            int index = -1;
            bool isExist = info.Contains(" ");

            if (isExist)
            {
                do
                {
                    index = info.IndexOf(" ");

                    isExist = info.Contains(" ");

                    if (index == -1 && isExist == false)
                    {
                        sb.Append(info);
                        break;
                    }

                    string word = info.Substring(0, index);
                    sb.Append(word);
                    sb.Append(" ");

                    info = info.Substring(index + 1);

                } while (index != -1);
            }
            else
            {
                sb.Append(info);
            }

           

            Console.WriteLine(sb);
        }

        //5
        static void SelectByEdge(string[] arr, string start, string end)
        {

            CultureInfo ci = new CultureInfo("en");

            string a = start.ToUpper(ci);
            string b = end.ToUpper(ci);


            foreach (var item in arr)
            {
                string word = item.ToUpper(ci);

                bool isStart = word.StartsWith(a);
                bool isEnd = word.EndsWith(b);

                if (isStart && isEnd)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //6
        static void Search(string[] arr, string pre)
        {
            CultureInfo ci = new CultureInfo("en");
            pre = pre.ToLower(ci);

            foreach (var item in arr)
            {
                if (item.ToLower().Contains(pre))
                {
                    Console.WriteLine(item);
                }
            }
        }

        //7
        static void FindIndex(string sentence, string word)
        {
            int index = -1;
            int count = 0;

            do
            {
                index = sentence.IndexOf(word, index + 1);

                if (index == -1)
                    break;

                Console.WriteLine(index);
                count++;


            } while (index != -1);

            Console.WriteLine(count);
        }
    }
}
