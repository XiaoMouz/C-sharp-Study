using System;

namespace 里氏转换练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] AIGroup = new Person[10];
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                int rNumber = r.Next(1,4);
                switch (rNumber)
                {
                    case 1: AIGroup[i] = new Person(); break;
                    case 2: AIGroup[i] = new Hunter(); break;
                    case 3: AIGroup[i] = new Teacher(); break;
                    case 4: AIGroup[i] = new Student();break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if(AIGroup[i] is Student)
                {
                    ((Student)AIGroup[i]).StudentSayHello();
                }else if(AIGroup[i] is Teacher)
                {
                    ((Teacher)AIGroup[i]).TeacherSayHello();
                }else if(AIGroup[i] is Hunter)
                {
                    ((Hunter)AIGroup[i]).HunterSayHello();
                }
                else
                {
                    AIGroup[i].SayHello();
                }
            }
        }
    }
}
