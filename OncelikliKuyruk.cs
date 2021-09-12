using System.Collections.Generic;
using System.Linq;

namespace ds_proje_2
{
    //Tuğcan Topaloğlu - 05190000072

    class OncelikliKuyruk
    {
        private Musteri temp;
        private List<Musteri> okList; //Oncelikli kuyruk listesi
       
        public OncelikliKuyruk()
        {
            this.okList = new List<Musteri>();
        }

        public Musteri remove()
        {
            temp = new Musteri(null, 0);
            foreach (Musteri item1 in okList) //ürün miktarı en yüksek olan müşteriyi buluyor ve müşterinin adını alıyor
            {
                if(item1.urunMiktari > temp.urunMiktari)
                {
                    temp = item1;
                }
                
            }
            okList.Remove(temp);
            return temp; //silinen müşterinin verisini döndürüyor

        }

        public void add (Musteri veri)
        {
            okList.Add(veri);
        }

        public bool isEmpty () //kuyruk boşsa "true" döndürür
        {
            return !okList.Any();
        }


    }
}
