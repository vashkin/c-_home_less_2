int NumberCont (int C, int N)  
// C - цифра в числе по счёту
// N - вводное число
{
string str = ""+N;
char [] ar = str.ToArray<char>();
return (int)Char.GetNumericValue(ar[C]);
}

Console.WriteLine("" + NumberCont(1,12345678));
