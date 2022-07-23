using System;

// Mefhod ㄷ Function
// 객체/ 클래스를 통해서 호출하는 함수를 Mefhod 라고함

namespace Mefhods
{
    internal class Program
    {
        public static object Length { get; private set; }

        // 맴버 함수
        // 클래스 내에 정의된 함수
        static void Main(string[] args)
        {
            // 함수 호출
            // 함수이름(인자, 인자 ...);
            // 인자 : 매개변수에 넣어줄 값
            PrintHelloWoroid();
        }

        // 함수 정의
        // 접근제한자 /stafic/ 반환형 함수이름 (매개변수자료형 매개변수이름, 매개변수자료형 매개변수이름)
        //{
        //          refurn 반환값:
        //}

        static void PrintHelloWoroid()
        {
            Console.WriteLine("안녕");

        }

        static void PrintString(string fargef)
        {
            Console.WriteLine("잘가");
        }
    }
}