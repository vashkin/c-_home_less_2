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
                 
            return 555;
    }
    else
    {
                string str = ""+N;
                char [] ar = str.ToArray<char>();
                return (int)Char.GetNumericValue(ar[C-1]);
    }  
}






//первое условие

Console.WriteLine("Первое задание: ");
int Number= NumberCont(2,456);
if (Number>=11){
Console.WriteLine("Данной цифры нет");
}else{
Console.WriteLine("" + Number);
}

 Number= NumberCont(2,782);
if (Number>=11){
Console.WriteLine("Данной цифры нет");
}else{
Console.WriteLine("" + Number);
}

 Number= NumberCont(2,918);
if (Number>=11){
Console.WriteLine("Данной цифры нет");
}else{
Console.WriteLine("" + Number);
}
 // второе условие
 
Console.WriteLine("Второе задание: ");
 Number= NumberCont(3,645);
if (Number>=11){
Console.WriteLine("Данной цифры нет");
}else{
Console.WriteLine("" + Number);
}

Number= NumberCont(3,78);
if (Number>=11){
Console.WriteLine("Данной цифры нет");
}else{
Console.WriteLine("" + Number);
}

Number= NumberCont(3,32679);
if (Number>=11){
Console.WriteLine("Данной цифры нет");
}else{
Console.WriteLine("" + Number);
}