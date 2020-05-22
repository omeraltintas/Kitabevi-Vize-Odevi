using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitabevi.Sistemi
{
    class Program : Kitap
    {
        static void Main(string[] args)
        {        
            char cevap;
            Console.WriteLine("--------KİTABEVİ SİSTEMİNE HOŞGELDİNİZ--------");   
            do
            {           
                
                Console.WriteLine("YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ");
                Console.WriteLine("1-Kitap Ekleme İşlemi");
                Console.WriteLine("2-Kitapların Listesini Görüntüleme");
                char islem = Convert.ToChar(Console.ReadLine());
                if (islem == '1')
                {
                    Kitap.AddBook();
                }
                else if (islem == '2')
                {
                    Kitap.DisplayBooks(); 
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş");
                }
                Console.WriteLine("Devam Etmek İstiyor Musunuz ? (e/h)");
                cevap = Convert.ToChar(Console.ReadLine());
            } while (cevap == 'e');
            Console.WriteLine("--------------PROGRAM SONLANDIRILMIŞTIR--------------");
            Console.ReadKey();
        }
    }
}
