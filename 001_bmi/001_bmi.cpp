#include <stdio.h>

int main()
{
	// 키와 체중을 입력받아서 , bmi를 계산하고 , 출력

	double height;
	double weight;
	

	printf("키(cm) 를 입력해주세요 : ");
	scanf_s("%lf", &height);

	printf("체중(kg) 을 입력해주세요 : ");
	scanf_s("%lf", &weight);

	height = height / 100;  //cm 를 m 로 환산 height /= 100으로 작성해도 됨

	double bmi = weight / (height * height);

	printf("BMI = %.2lf\n", bmi);



}