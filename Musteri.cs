namespace ds_proje_2
{
    //Tuğcan Topaloğlu - 05190000072

    class Musteri
    {
        public string musteriAdi { get; set; }
        public int urunMiktari { get; set; }

        public Musteri(string musteriAdi, int urunMiktari)
        {
            this.musteriAdi = musteriAdi;
            this.urunMiktari = urunMiktari;
        }

        public override string ToString()
        {
            return "(" + musteriAdi + ", " + urunMiktari + ")";
        }

    }
}
