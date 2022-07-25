string FullName = "Zhaparov Aziz Mirlanovich";
int age = 18;
string adress = "zhaparovaziz03@gmail.com";
double MarkProgs = 40.5;
double MarkMaths = 30.3;
double MarkPhysics = 30.3;
string pattern = "Ф.И.О: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";
Console.WriteLine(pattern,
                  FullName,
                  age,
                  adress,
                  MarkProgs,
                  MarkMaths,
                  MarkPhysics);
Console.ReadKey();


float sum = (float)MarkProgs + (float)MarkMaths + (float)MarkPhysics; //Сумма всех элементов = 101,100006
float sums = sum / 3;
Console.WriteLine($"Среднее арифметическое всех баллов: {sums}");
Console.ReadKey();
