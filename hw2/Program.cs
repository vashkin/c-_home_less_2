 Console.Write("Введите число дня недели\n");
 Console.WriteLine("от 1 до 7:");
 int days = Convert.ToInt32( Console.ReadLine()!);


 string [] ar = { "","понедельник", "вторник", "среду", "четверг", "пятницу", "субботу", "воскресенье"};


 if (days>=6 ){
    Console.WriteLine("В "+ar[days] + " отдыхаем");
 }else if(days != 0) {
    Console.WriteLine("В "+ar[days] + " работаем");
 }
