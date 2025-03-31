#include <iostream>
using namespace std;


int main()
{
    double height, weight;

    cout << "체중(kg) 을 입력해주세요 : ";
    cin >> weight;

    cout << "키(cm) 를 입력해주세요 : ";
    cin >> height;

    height /= 100;
    
    double bmi = weight / (height * height);

    cout << "당신의 BMI 는 = " << bmi << endl;

    // 네임스페이스 = 이름을 담는 공간 
    // c#은 모든 코드가 클래스 안에 들어가 있어야 함
    // int main 은 C#에서는 static void Main (string[] args)
    // C#에서는 printf가 Console.WriteLine()
    // C#에서는 읽어오는 값이 string , if 173을 입력하면 문자열 173을 입력받음
    // string s = Console.ReadLine()
    // int age = int Parse(s)
    // h = double.Parse(s)

}