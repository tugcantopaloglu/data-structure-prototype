namespace ds_proje_2
{
    //Tuğcan Topaloğlu - 05190000072

    class Yigit
    {
        private int maxSize; // yığıtın büyüklüğü
        private Musteri[] yigitArray;
        private int top; // yığıtın üstü
                       
        public Yigit(int arrayBoyutu) // constructor
        {
            maxSize = arrayBoyutu; // array boyutu ayarlama
            yigitArray = new Musteri[maxSize]; // Musteri tipinde array oluştur
            top = -1; // item olmadığının göstergesi
        }
       
        public void push(Musteri newItem) // yığıtın üstüne item koy
        {
            yigitArray[++top] = newItem; 
        }


        public Musteri pop() //yığıtın üstünden item çıkar
        {
            return yigitArray[top--]; 
        }
   
        public Musteri peek() // yığıtın üstündeki item'a bak
        {
            return yigitArray[top];
        }
     
        public bool isEmpty() // yığıt boş mu kontrolü "true" ise boştur
        {
            return (top == -1);
        }
      
        public bool isFull() // yığıt dolu mu kontrolü "true" ise doludur
        {
            return (top == maxSize - 1);
        }
    
    }
}
