using System;

// 1
Calculator calc1 = delegate (int x)
{
    return x * x;
};

Calculator calc2 = x =>
{
    return x * x;
};

Calculator calc3 = x => x * x;


Console.WriteLine($"익명 메서드: {calc1(5)}");
Console.WriteLine($"람다식 (블록): {calc2(5)}");
Console.WriteLine($"람다식 (표현식): {calc3(5)}");
Console.WriteLine();

// 2
EventHandler handler1 = delegate { Console.WriteLine("이벤트 처리됨"); };
EventHandler handler2 = (obj, e) => Console.WriteLine("이벤트 처리됨");

handler1(null, EventArgs.Empty);
handler2(null, EventArgs.Empty);
Console.WriteLine();

// 3
GameEvent onScoreChange = delegate { };
GameEvent onGameOver = delegate { };
onScoreChange += delegate (string s, int i)
{
    Console.WriteLine($"[이벤트] {s}: {i}");
};
onGameOver += delegate (string s, int i)
{
    Console.WriteLine($"[이벤트] {s}: {i}");
};
onScoreChange("점수 변경", 500);
Console.WriteLine();

// 4
int[] nums = { 1, 2, 3, 4, 5 };
int sum = 0;

ProcessData(nums, delegate (int x)
{
    sum += x;
    Console.WriteLine($"처리 중: {x} 누적: {sum}");
    
});
static void ProcessData(int[] data, Action<int> callback)
{
    foreach (int x in data) { callback(x); }
}

// 3
delegate void GameEvent(string s, int i);

// 2
delegate void EventHandler(object obj, EventArgs e);

// 1
delegate int Calculator(int x);
