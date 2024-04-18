//Тема 11. Урок 1. Условный оператор

//int s1 = 0;
//int greate10 = 0;
//int less10 = 0;
//int max = int.MinValue;
//int min = int.MaxValue;
//Console.Write("Введите число 1:");
//int n1 = int.Parse(Console.ReadLine());
//s1 += n1;
//if (n1 > 10) greate10++;
//if (n1 < 10) less10++;
//if (n1 > max) max = n1;
//if (n1 < min) min = n1;
//Console.Write("Введите число 2:");
//int n2 = int.Parse(Console.ReadLine());
//s1 += n2;
//if (n2 > 10) greate10++;
//if (n2 < 10) less10++;
//if (n2 > max) max = n2;
//if (n2 < min) min = n2;
//Console.Write("Введите число 3:");
//int n3 = int.Parse(Console.ReadLine());
//s1 += n3;
//if (n3 > 10) greate10++;
//if (n3 < 10) less10++;
//if (n3 > max) max = n3;
//if (n3 < min) min = n3;
//Console.Write("Введите число 4:");
//int n4 = int.Parse(Console.ReadLine());
//s1 += n4;
//if (n4 > 10) greate10++;
//if (n4 < 10) less10++;
//if (n4 > max) max = n4;
//if (n4 < min) min = n4;
//Console.Write("Введите число 5:");
//int n5 = int.Parse(Console.ReadLine());
//s1 += n5;
//if (n5 > 10) greate10++;
//if (n5 < 10) less10++;
//if (n5 > max) max = n5;
//if (n5 < min) min = n5;
//Console.Write("Введите число 6:");
//int n6 = int.Parse(Console.ReadLine());
//s1 += n6;
//if (n6> 10) greate10++;
//if (n6 < 10) less10++;
//if (n6> max) max = n6;
//if (n6 < min) min = n6;
//Console.Write("Введите число 7:");
//int n7 = int.Parse(Console.ReadLine());
//s1 += n7;
//if (n7 > 10) greate10++;
//if (n7 < 10) less10++;
//if (n7 > max) max = n7;
//if (n7 < min) min = n7;
//Console.Write("Введите число 8:");
//int n8 = int.Parse(Console.ReadLine());
//s1 += n8;
//if (n8 > 10) greate10++;
//if (n8 < 10) less10++;
//if (n8 > max) max = n8;
//if (n8 < min) min = n8;
//Console.Write("Введите число 9:");
//int n9 = int.Parse(Console.ReadLine());
//s1 += n9;
//if (n9 > 10) greate10++;
//if (n9 < 10) less10++;
//if (n9 > max) max = n9;
//if (n9 < min) min = n9;
//Console.Write("Введите число 10:");
//int n10 = int.Parse(Console.ReadLine());
//s1 += n10;
//if (n10 > 10) greate10++;
//if (n10 < 10) less10++;
//if (n10 > max) max = n10;
//if (n10 < min) min = n10;
//Console.WriteLine($"Кол-во чисел больше 10: {greate10}");
//Console.WriteLine($"Кол-во чисел меньше 10: {less10}");
//Console.WriteLine($"Максимальное значение в списке: {max}");
//Console.WriteLine($"Максимальное значение в списке: {min}");

//int sum = n1+n2+n3+n4+n5+n6+n7+n8+n9+n10;

//Console.WriteLine($"Сумма всех чисел: {sum}");
//Console.WriteLine($"Среднее арифметическое всех чисел: {sum/10}");

//Тема 11. Урок 2. Условный оператор.
//Console.Write("Введите текущую температуру в С:");
//int C = int.Parse(Console.ReadLine());
//if (C > 20 && C < 50) Console.WriteLine("Сегодня на прогулку идут слоны, жирафы и львы");
//else if (C < 20 && C > 0) Console.WriteLine("Сегодня на прогулку идут медведи, волки и пингвины");
//else if (C == 20) Console.WriteLine("Сегодня на прогулку идет кенгуру");
//else Console.WriteLine("Сегодня на прогулку никто не идет");

//Тема 11. Урок 3. Условные операторы и класс Random
//Задача 1
//Random random = new Random();
//int n = random.Next(1, 6);
//Console.Write("Введите число:");
//int m = int.Parse(Console.ReadLine());
//if (n == m) Console.WriteLine("Вы выиграли");
//else Console.WriteLine("Вы проиграли");
//Задача2
//Console.Write("Введите порядковый номер текущего месяца:");
//int n = int.Parse(Console.ReadLine());
//if (n == 1) Console.WriteLine("Январь");
//if (n == 2) Console.WriteLine("Февраль");
//if (n == 3) Console.WriteLine("Март");
//if (n == 4) Console.WriteLine("Апрель");
//if (n == 5) Console.WriteLine("Май");
//if (n == 6) Console.WriteLine("Июнь");
//if (n == 7) Console.WriteLine("Июль");
//if (n == 8) Console.WriteLine("Август");
//if (n == 9) Console.WriteLine("Сентябрь");
//if (n == 10) Console.WriteLine("Октябрь");
//if (n == 11) Console.WriteLine("Январь");
//if (n == 12) Console.WriteLine("Декабрь");
//else Console.WriteLine("Нет такого месяца");

//тема 11. Урок 4. Условные операторы и класс Random
//Console.Write("Введите ваш возраст:");
//int age = int.Parse(Console.ReadLine());
//if (age < 18) Console.WriteLine("Вы слишкоммолоды для участия в выборах");
//else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете участвовать в выборах в качестве депутата");
//else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты");
//else Console.WriteLine("Ваш возраст слишком велик для участия в выборах");

//Console.WriteLine("Кандидаты в президенты солнечного города:\r\n Незнайка\r\n Лунтик\r\n Карлсон\r\n Дядя Фёдор");
//Console.Write("За кого бы вы голосовали:");
//string name = Console.ReadLine();
//if (name == "Незнайка") Console.WriteLine("А у тебя в животе арбуз вырастет!!!");
//else if (name == "Лунтик") Console.WriteLine("Я родился");
//else if (name == "Карлсон") Console.WriteLine("Спокойствие.Только спокойствие");
//else Console.WriteLine("Чтобы продать что-нибудь ненужное, нужно сначала купить что-нибудь ненужное, а у нас денег нет.");


