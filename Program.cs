using System;

namespace Class_Kurucu_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
           //Söz dizimi
           //class SinifAdi
           //{
                /* [Erişim belirleyici] [Veri Tipi] ÖzellikAdi;
                   [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdı[Parametre Lsitesi]
                    {
                        Metot Komutları;
                    }
                 */
           //}

           /* Erişim belirleyicileri 
            *Private ==> tANIMLANDIĞI SINIF İÇERİSİNDE ERİŞİM
            *Public  ==> HERYERDEN ERİŞİM SAĞLANABİLİR
            *Internal ==> KENDİ BULUNDUĞU PROJE İÇERİSİNDE ERİŞİLEBİLEN DEĞİŞKENLER VE METOTLARA
            *Protected ==> SADECE TANIMLANDIĞI SINIF VE VEYA KALITIM ALDIĞI SIBNIFLARDA ERİŞİLEBİLİR
           */
            Console.WriteLine("************* Çalışan 1 ****************");
            Calisan calisan1 = new Calisan("Ayşe","Kara",12543678,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("************* Çalışan 2 ****************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad="Batu";
            calisan2.Soyad="Matu";
            calisan2.No=99999999;
            calisan2.Departman="Bakım Bölümü";
            calisan2.CalisanBilgileri();

            Console.WriteLine("************* Çalışan 3 ****************");
            Calisan calisan3 = new Calisan("Gökçe","Kabak");
            calisan3.CalisanBilgileri();


        }
    }

    class Calisan{

        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad,int no,string departman){
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;

        }
        public Calisan(string ad,string soyad){
            this.Ad=ad;
            this.Soyad=soyad;
        }
        public Calisan(){}
        public void CalisanBilgileri(){

            Console.WriteLine("Çalışan Adı : {0}",Ad);
            Console.WriteLine("Çalışan Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışanın numarası : {0}",No);
            Console.WriteLine("Çalışanın departmanı : {0}",Departman);

        }
    }
}
