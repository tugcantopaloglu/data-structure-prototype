namespace ds_proje_2
{
    //Tuğcan Topaloğlu - 05190000072

    class Kuyruk
    {
        private int maxSize;
        private Musteri[] kuyrukArray;
        private int front;
        private int rear;
        private int nItems;

    public Kuyruk(int s) {
            maxSize = s;
            kuyrukArray = new Musteri[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }
       
    
    
    public void insert(Musteri j) // sıranın arkasına item ekleme
    {
        if (rear == maxSize - 1)
            {
               rear = -1;
            }
           
            kuyrukArray[++rear] = j; 
            nItems++; 
    }
    
    public Musteri remove() // sırada öndeki itemı çıkarıyor
    {
        Musteri temp = kuyrukArray[front++]; 
        if (front == maxSize) {
                front = 0;
            }
            
        nItems--; 
        return temp;
    }
    
    public Musteri peekFront() // kuyruğun önündeki itema bakma
    {
        return kuyrukArray[front];
    }
    
    public bool isEmpty() // kuyruk boş mu kontrolü "true" ise boştur
        {
        return (nItems == 0);
    }
    
    public bool isFull() // kuyruk dolu mu kontrolü "true" ise doludur
        {
        return (nItems == maxSize);
    }
    
    public int size() // kuyruktaki item sayısı
    {
        return nItems;
    }
    
}
}

