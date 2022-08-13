int NumberCont (int C, int N)  
// C - цифра в числе по счёту
// N - вводное число
{
    int i = 1;
    int mas = 1;
    do{
        mas= mas*10;
        i++;
    }while(i<=C-1);
     if (mas>=N){
                 Console.WriteLine( i + " цифры нет");
            return 0;
    }else{
                string str = ""+N;
                char [] ar = str.ToArray<char>();
                return (int)Char.GetNumericValue(ar[C-1]);
    }  
}


Console.WriteLine("" + NumberCont(9,12345678));
