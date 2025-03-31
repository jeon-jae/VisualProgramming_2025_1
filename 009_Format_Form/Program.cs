// See https://aka.ms/new-console-template for more information


//string.Format 조금 더 이해하기

Console.WriteLine("안녕하세요!! C# 입니다");
Console.WriteLine("10이하의 소수 : {0} {1} {2} {3}" , 2,3,5,7); //{0}{1}{2}{3} 은 그대로 출력되는게 아닌 입력한 2,3,5,7이 출력
//Console.WriteLine(string format, object arg0//{0}, object arg1{1}....);

string s = string.Format("10이하의 소수 : {0} {1} {2} {3}", 2, 3, 5, 7);
Console.WriteLine(s);

int v1 = 100;
double v2 = 1.234;

//Console.WriteLine(v1,v2); 오류! 하나의 문장으로 만들어야함
Console.WriteLine("v1 = " + v1 + ", v2 = "+v2 ); //문자열 + 숫자하면 문자열이 됨
Console.WriteLine("v1 = {0}, v2 = {1}" , v1 , v2);
Console.WriteLine($"v1 = {v1} , v2 = {v2}");

double x = 1234.567;
Console.WriteLine("{0:C}" , x ); // 소수점 밑에 커팅
Console.WriteLine("{0:E}", x); // 10^3으로 표시
Console.WriteLine("{0:F2}" , x);  // 소수점 밑에 두자리
Console.WriteLine("{0:N2}", x); // 소수점 밑에 두자리 1,234 로 바뀜 3자리마다 하나씩 , 을 넣어줌
Console.WriteLine("{0:#,#.##}" , x); // 소수점 밑에 두자리 1,234 로 바뀜 3자리마다 하나씩 , 을 넣어줌


//string.Format 문자열로 지정

