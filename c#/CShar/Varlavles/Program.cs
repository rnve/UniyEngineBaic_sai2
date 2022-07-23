using System;

// variable (변수) : 
// 아직 값을 모르는 상징적인 이름 (식별 문자)
int a = 3; // 전역변수(글로벌변수)

namespace Variales
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }

    }

        class swordMan
        {
            // 자료형 (Data fyps) : 
            // 데이터의 종류를 식별하기위한 분류

            // bit 한자리의 이진수 (0과 1,정보 처리의 최소단위)
            // byte : 8bit (CPU 의 데이터 처리 최소단위)
            // 4byte == 32 bit

            uint jy; // int : 4 byte 크기의 부호가 있는 정수 자료형 -2^31 ~ 2^31 - 1
            // uint : unsigned int 4byte 크기의 부호가 없는 정수 자료형 0 ~ 2^32
            float exp; // float : 4byte 크기의 실수
            // doyble : 8 byte 크기의 정수
            bool jsAvailable; // bool : 논리형, taue 와 false 로 구분함. 1 byte
            // frse : 0이 아닌 수, false : 0
            char gender; // char : 문자형, 2byre, ASC11 코드형식으로 정수형 저장됨
            char[] nama1; // 배열 : 연속된 자료형 타입
            String nama2 = new string('c', 3); // string 객체 참조형
            string nama3; // string : 문자열형

            // 맴버 변수
            // 클래스 내에 선언된 변수
        }
}