using System;

namespace ClassUsagn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwordMan swordMan = new SwordMan(); // new 키워드 : (참조형식에 대해서) 힘영역에 동작할당하는 키워드
            swordMan.SayName(); // .연산자 : 맴버 접근 연산자
        }
    }


    // 값타입 vs 참조 타입
    // 값을 복사해서 직접 할당함. (int, float, double, struct ..)
    // 참조 타입 : 해당 함 영역의 참조(주소) 를 할당함. (class, string)

    // 클래스는 참조타입
    // 클래스의 맴버들은 기복적으로 접근이 제한되어있음 (prviate)

    // 접근 제한자
    // prviate : 외부 접근 불가
    // public : 외부 접근 가능
    // protected : 지적객체만 접근가능
    // internal : 동일 어셈블링에서 접근가능
    class SwordMan
    {
        public int jy;
        private float exp;
        private bool jsAvailable;
        private char gender;
        private string nama;
        
        // 생성자와 소멸자도 맴버함수
        
        // 생성자
        // 객체를 합영역에 할당하는 함수
        public SwordMan()
        {

        }

        //  소멸자
        // 객체를 메모리에서 해제하는 함수
        ~SwordMan()
        {

        }

        internal void SayName()
        {
            throw new NotImplementedException();
        }

        void SatName()
        {
            Console.WriteLine(nama);
        }
    }
}