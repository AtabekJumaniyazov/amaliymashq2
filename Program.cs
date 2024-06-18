//1.Kalkulyator:
// Foydalanuvchidan birinchi raqamni so'rash
Console.Write("Birinchi raqamni kiriting: ");
double firstNumber = double.Parse(Console.ReadLine());

// Foydalanuvchidan operatsiyani so'rash
Console.Write("Operatsiyani kiriting (+, -, *, /): ");
string operation = Console.ReadLine();

// Foydalanuvchidan ikkinchi raqamni so'rash
Console.Write("Ikkinchi raqamni kiriting: ");
double secondNumber = double.Parse(Console.ReadLine());

// Natijani hisoblash
double result = (operation == "+") ? firstNumber + secondNumber :
                (operation == "-") ? firstNumber - secondNumber :
                (operation == "*") ? firstNumber * secondNumber :
                (operation == "/") ? firstNumber / secondNumber : 0;

// Natijani chiqarish
Console.WriteLine("Natija: " + result);

//2. Raqamlar qatorining yig‘indisini hisoblash:
// Foydalanuvchidan N sonini so'rash
Console.Write("Iltimos, N musbat butun sonini kiriting: ");
int N = int.Parse(Console.ReadLine());

// Yig'indini hisoblash (formuladan foydalanish)
int sum = N * (N + 1) / 2;

// Natijani ekranga chiqarish
Console.WriteLine("1 dan " + N + " gacha bo'lgan sonlarning yig'indisi: " + sum);

//3.  Paritet tekshiruvi:
// Foydalanuvchidan son kiritishni so'rash
Console.Write("Iltimos, biror butun sonni kiriting: ");
int number = int.Parse(Console.ReadLine());

// Juft yoki toq ekanligini tekshirish va natijani chiqarish
string result1 = (number % 2 == 0) ? "Juft" : "Toq";
Console.WriteLine(result1);