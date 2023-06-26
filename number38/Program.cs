int InputNumber(){
    Console.Write("Введите число : ");
    int a = Convert.ToInt32(Console.ReadLine());
    while (a <0 ){
        Console.Write("Число должно быть натуральным : ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    return a ;    
}
double GetRandDouble(){
    Random rnd = new Random();
    return (Math.Round((rnd.Next(-99 , 99) + rnd.NextDouble()),3));
}

void InOutputArray(int len){
    Random rnd = new Random();
    double max = -100 , min = 100;
    double[] result = new double[len] ;
    for (int i = 0 ; i < len ; i++ ){
        result[i]= GetRandDouble();
        if (max < result[i]){
            max = result[i]; 
        }
        if (min > result[i]){
            min = result[i];
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
    Console.Write(" -> разница между максимальным и минимальным элементов массива = {0} - {1} = {2} ", max ,min ,Math.Round(max-min , 3));
}

InOutputArray(InputNumber());