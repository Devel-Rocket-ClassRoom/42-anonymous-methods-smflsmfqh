using System;

// 1
static int Square(int x) => x * x;

Calculator calc = Square;
Console.WriteLine(calc(5));
Console.WriteLine();

// 2
Transformer square = delegate (int x)
{
    return x * x;
};
Transformer cube = delegate (int x)
{
    return x * x * x;
};
Console.WriteLine($"3의 제곱: {square(3)}");
Console.WriteLine($"3의 세제곱: {cube(3)}");
Console.WriteLine();

// 3
Printer printer = delegate (string message)
{
    Console.WriteLine($"[메시지] {message}");
};
printer("안녕하세요!");
printer("익명 메서드를 사용 중입니다.");
Console.WriteLine();

// 4
Func<int, int> doubler = delegate (int x) { return x * 2; };
Action<string> logger = delegate (string msg) { Console.WriteLine($"[LOG] {msg}"); };
Console.WriteLine(doubler(10));
logger("작업 시작");
Console.WriteLine();

// 5
SimpleDelegate handler = delegate { Console.WriteLine("매개변수를 사용하지 않습니다."); };
handler(100, "테스트");
Console.WriteLine();

// 6
EventHandler onClick = delegate { Console.WriteLine("클릭 이벤트 발생!"); };
onClick(null, EventArgs.Empty);

// 6
delegate void EventHandler(object obj, EventArgs args);

// 5
delegate void SimpleDelegate(int x, string s);

// 3
delegate void Printer(string msg);

// 2
delegate int Transformer(int x);
// 1
delegate int Calculator(int x);
