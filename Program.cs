int num1 = 1;
int num2 = 2;
int temp;

temp = num2;
num2 = num1;
num1 = temp;

Console.WriteLine($"{num2}, {num1} is the orginal numbers.");
Console.WriteLine($"{num1}, {num2} is the reversed numbers.");