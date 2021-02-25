using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkAraound
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfYear = 1985;
            person1.NationalIdentity = 123;


            //SelamVer(isim: "Engin");


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }




        static void SelamVer(string isim)
        {
            Console.WriteLine("Merhaba " + isim);
        }


        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine();
            return sonuc;

        }




    }
}
