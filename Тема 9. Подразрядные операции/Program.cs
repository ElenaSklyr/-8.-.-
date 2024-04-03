//1
Console.WriteLine(8 & 3);
Console.WriteLine(22 & 4);
//2
Console.WriteLine(65 | 29);
Console.WriteLine(44 | 12);
//3
Console.WriteLine(249 ^ 8);
int n = 249;
int key = 8;
int crypt = n ^ key;
Console.WriteLine($"Зашифрованное сообщение:{crypt}");
int encrypt = crypt ^ key;
Console.WriteLine($"Расшифрованное сообщение:{encrypt}");
