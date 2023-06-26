int InputNumber(){
    Console.Write("Введите число : ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <0 ){
        Console.Write("Число должно быть натуральным : ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;    
}
void InOutputArray(int len){
    Random rnd = new Random();
    int a = 0;
    int[] result = new int[len] ;
    for (int i = 0 ; i < len ; i++ ){
        result[i]= rnd.Next(100 , 999);
        if (result[i]%2==0){
            a = a + 1; 
        }
    }

    Console.Write("Ваш массив: [ ");
    for (int i = 0 ; i < len ; i++ ){
        Console.Write(result[i]);
        if ( i != (len-1)){
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
    Console.Write(" -> количество четных = " + a);
}

InOutputArray(InputNumber());