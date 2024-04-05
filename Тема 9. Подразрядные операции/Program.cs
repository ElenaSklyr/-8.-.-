//Тема 9. Урок1. Подразрядные операции и операции присваивания
//Задание 1

//Console.WriteLine(8 & 3);
//Console.WriteLine(22 & 4);

//Задание 2

//Console.WriteLine(65 | 29);
//Console.WriteLine(44 | 12);

//Задание 3

//Console.WriteLine(249 ^ 8);
//int n = 249;
//int key = 8;
//int crypt = n ^ key;
//Console.WriteLine($"Зашифрованное сообщение:{crypt}");
//int encrypt = crypt ^ key;
//Console.WriteLine($"Расшифрованное сообщение:{encrypt}");

//Тема 9. Урок2. Подразрядные операции и операции присваивания
//Задание 1

//long x = 264895468854;
//long result = ~264895468854;
//result = result + 1;
//Console.WriteLine(result);

//long y = 256;
//long result1 = ~256;
//result1 = result1 + 1;
//Console.WriteLine(result1);

//Задание 2

//Console.WriteLine(256>>1);//256 в дв.сис-ме 100000000, сдвигаем на 1 вправо, получаем 010000000.это 128 в десятичной сис-ме
//Console.WriteLine(256<<5);//256 в дв.сис-ме 100000000, сдвигаем на 5 влево 10000000000000. это 8192 в десятичной сис-ме
//Console.WriteLine(32856<<3);//32856 в дв.сис-ме 0001000000001011000, сдвигаем на 3 влево, получаем 1000000001011000000. это 262848 в десят.сис-ме
//Console.WriteLine(32856 >> 2);//32856 в дв.сис-ме 0001000000001011000, сдвигаем на 2 вправо, получаем 0000010000000010110. это 8214 в десят. сис-ме

//Задание 3

//int x1 = 289;
//int y1 = 144;
//int z1 = 36274;
//x1 += 2487;
//y1 += 2487;
//z1 += 2487;
//Console.WriteLine($"{x1},{y1},{z1}");//x1=2487+289=2776, y1=144+2874=2631, z1 = 36274+2487=38761
//x1 -= 2487;
//y1 -= 2487;
//z1 -= 2487;
//Console.WriteLine($"{x1},{y1},{z1}");//x1=2776-2487=289, y1=2631-2487=144, z1=38761-2487=36274
//x1 *= 2487;
//y1 *= 2487;
//z1 *= 2487;
//Console.WriteLine($"{x1},{y1},{z1}");//x1=289*2487=718743,y1=144*2487=358128 z1 = 36274*2487=90213438
//x1 /= 2487;
//y1 /= 2487;
//z1 /= 2487;
//Console.WriteLine($"{x1},{y1},{z1}");//x1=718743/2487=289, y1=358128/2487=144, z1=90213438/2487=36274
//x1 %= 2487;
//y1 %= 2487;
//z1 %= 2487;
//Console.WriteLine($"{x1},{y1},{z1}");//вот тут не поняла

//Тема.10. Урок1. Класс Math

//Console.Write("Введите радиус:");
//double R = double.Parse(s:Console.ReadLine());
//Console.WriteLine($"Площадь круга равна: {(Math.PI * Math.Pow(R, 2)):F2}");
//Console.WriteLine($"Длина окружности равна:{(2 * Math.PI * R):F2}");

//Тема 10.Урок2.Класс Math

//Console.Write("Введите длину гипотенузы:");
//double c = double.Parse(Console.ReadLine());
//Console.Write("Введите длину 1-го катета:");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine($"Длина 2-го катета равна:{Math.Sqrt(c * c - a * a):F2}");




