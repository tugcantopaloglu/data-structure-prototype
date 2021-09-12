using System;
using System.Collections;
using System.Collections.Generic;


namespace ds_proje_2
{

    //Tuğcan Topaloğlu - 05190000072
    class Program
    {
        static void Main(string[] args)
        {
            //işlem görecek dizilerin girişi
            string[] MüşteriAdı = new string[] { "Ali", "Merve", "Veli", "Gülay", "Okan", "Zekiye", "Kemal", "Banu", "İlker", "Songül", "Nuri", "Deniz" };
            int[] ÜrünSayısı = new int[] { 8, 11, 16, 5, 15, 14, 19, 3, 18, 17, 13, 15 };

            //dinamik dizinin oluşturulması ve müşteri tipinde elemanların listeler halinde dinamik diziye aktarıldıktan sonra yazdırılması
            ArrayList dinamikDizi = BilesikVeriYapisi(MüşteriAdı, ÜrünSayısı);
            Console.WriteLine("Dinamik dizideki listelerin (her satır dinamik diziniz bir elemanını temsil edecek şekilde) yazdırılması:");
            ArrayListYazdir(dinamikDizi);
            Console.WriteLine();

            //dinamik dizideki eleman sayısının bulunması
            int dinamikDiziElemanSayisi = dinamikDizi.Count;
            Console.Write("{0} {1}", "Dinamik dizideki eleman (liste) sayısı:", dinamikDiziElemanSayisi);
            Console.WriteLine();
            Console.Write("{0} {1}", "Ortalama eleman sayısı:", MüşteriAdı.Length / dinamikDiziElemanSayisi);
            Console.WriteLine();
            Console.WriteLine();


            //yığıt oluşturup itemları yığıta atadıktan sonra itemlerın çıkarılarak ekrana yazdırılması
            Yigit ornekYigit = new Yigit(MüşteriAdı.Length);
            for (int i = 0; i < MüşteriAdı.Length; i++) //elemanları yığıta ekliyoruz.
            {
                Musteri yigitMusterisi = new Musteri(MüşteriAdı[i], ÜrünSayısı[i]);
                ornekYigit.push(yigitMusterisi);
            }
            Console.WriteLine("Yığıt yazdırılıyor:");
            while (ornekYigit.isEmpty() == false)
            {
                Console.Write(ornekYigit.peek());
                Console.Write("     ");
                ornekYigit.pop();
            }
            Console.WriteLine();
            Console.WriteLine();


            //kuyruk oluşturup itemları kuyruğa atadıktan sonra itemların çıkarılarak ekrana yazdırılması
            Kuyruk ornekKuyruk = new Kuyruk(MüşteriAdı.Length);

            //ortalama hesapları için değerler
            int kuyrukOncekiSure = 0;
            int[] kuyrukMusteriSuresi = new int[MüşteriAdı.Length];

            for (int i = 0; i < MüşteriAdı.Length; i++) //elemanları kuyruğa ekliyoruz.
            {
                Musteri kuyrukMusterisi = new Musteri(MüşteriAdı[i], ÜrünSayısı[i]);
                ornekKuyruk.insert(kuyrukMusterisi);

                //ortalama hesabı
                kuyrukOncekiSure += ornekKuyruk.peekFront().urunMiktari;
                kuyrukMusteriSuresi[i] = kuyrukOncekiSure;

            }
            Console.WriteLine("Kuyruk yazdırılıyor:");
            while (ornekKuyruk.isEmpty() == false)
            {
                Console.Write(ornekKuyruk.peekFront());
                Console.Write("     ");
                ornekKuyruk.remove();
            }
            Console.WriteLine();
            Console.WriteLine();


            //öncelikli kuyruk oluşturup itemları kuyruğa atadıktan sonra en büyük itemı çıkarıp yazdırıyoruz
            OncelikliKuyruk ornekOK = new OncelikliKuyruk(); //OK kısaltması öncelikli kuyruk anlamına geliyor

            //ortalama hesapları için değerler
            int oncelikliOncekiSure = 0;
            int[] oncelikliMusteriSuresi = new int[MüşteriAdı.Length];

            for (int i = 0; i < MüşteriAdı.Length; i++) //elemanları kuyruğa ekliyoruz.
            {
                Musteri oncelikliKuyrukMusterisi = new Musteri(MüşteriAdı[i], ÜrünSayısı[i]);
                ornekOK.add(oncelikliKuyrukMusterisi);
            }
            Console.WriteLine("Öncelikli Kuyruk yazdırılıyor:");
            while (ornekOK.isEmpty() == false)
            {
                Musteri temp = ornekOK.remove();
                //ortalama hesabı
                oncelikliOncekiSure += temp.urunMiktari;
                for (int i = 0; i < MüşteriAdı.Length; i++)
                {
                    oncelikliMusteriSuresi[i] = oncelikliOncekiSure;
                }
                //yazdırma
                Console.Write(temp);
                Console.Write("     ");
            }
            Console.WriteLine();
            Console.WriteLine();


            //güncellenmis öncelikli kuyruk oluşturup itemları kuyruğa atadıktan sonra en büyük itemı çıkarıp yazdırıyoruz
            GuncellenmisOncelikliKuyruk guncellenmisOrnekOK = new GuncellenmisOncelikliKuyruk(); //OK kısaltması öncelikli kuyruk anlamına geliyor
            for (int i = 0; i < MüşteriAdı.Length; i++) //elemanları kuyruğa ekliyoruz.
            {
                Musteri guncellenmisOncelikliKuyrukMusterisi = new Musteri(MüşteriAdı[i], ÜrünSayısı[i]);
                guncellenmisOrnekOK.add(guncellenmisOncelikliKuyrukMusterisi);
            }
            Console.WriteLine("Artan Sıra İle Öncelikli Kuyruk yazdırılıyor:");
            while (guncellenmisOrnekOK.isEmpty() == false)
            {
                Console.Write(guncellenmisOrnekOK.remove());
                Console.Write("     ");
            }
            Console.WriteLine();
            Console.WriteLine();


            //ortalama hesabı ve yazdırılması
            int kuyrukOrtalama = 0;
            int oncelikliOrtalama = 0;
            for (int i = 0; i < MüşteriAdı.Length; i++)
            {
                kuyrukOrtalama += kuyrukMusteriSuresi[i];
                oncelikliOrtalama += oncelikliMusteriSuresi[i];
            }

            Console.WriteLine("{0} {1}","Kuyruğa göre müşterilerin ortalama işlem süresi:", kuyrukOrtalama/(MüşteriAdı.Length));
            Console.WriteLine("{0} {1}", "Öncelikli Kuyruğa göre müşterilerin ortalama işlem süresi:", oncelikliOrtalama / (MüşteriAdı.Length));


            Console.ReadKey();
        }

        public static ArrayList BilesikVeriYapisi(string[] musteriAdi, int[] urunSayisi)
        {
            ArrayList arrayListesi = new ArrayList(); //arraylist oluşturuldu 
            Random random = new Random();
            int musteriSayisi = musteriAdi.Length; //liste oluştururken büyüklük hatası almamak için müşteri sayısı düzenleniyor
            int sayac = 0;
            while (musteriSayisi!=0) {
                List<Musteri> genericListe = new List<Musteri>(); //arraylistin içine girecek olan generic list oluşturuldu
                int randomSayi = random.Next(1, 6);//1-5 arası random sayı alındı

                if (randomSayi > musteriSayisi) //üretilen rastgele sayı son kısımda o sayı kadar ürün kalmazsa diye işlem yapılıyor
                {
                    randomSayi = musteriSayisi;
                }

                for (int i = 0; i < randomSayi; i++)
                {
                    Musteri musteriOrnegi = new Musteri(musteriAdi[sayac], urunSayisi[sayac]); //müşteri bilgileri dizilerinden bilgiler alınıp müşteri sınıfına atanıyor
                    genericListe.Add(musteriOrnegi); //listeye müşteri tipinde bilgiler atılıyor
                    sayac++;
                }

                arrayListesi.Add(genericListe); //liste array liste atanıyor
                musteriSayisi -= randomSayi;
            }
            return arrayListesi;
        }

        public static void ArrayListYazdir(ArrayList arrayList)
        {
            foreach (List<Musteri> item in arrayList)
            {
                foreach (Musteri item1 in item)
                {
                    Console.Write("{0}, {1}", item1.musteriAdi, item1.urunMiktari);
                    Console.Write("     ");
                }
                Console.WriteLine();
            }
        }
    }
}



