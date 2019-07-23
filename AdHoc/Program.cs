using System;

namespace AdHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            int[] arr = new int[] { 1, 3, 4, 5, 6, 7, 235, 263, 32 };
            Console.WriteLine(myClass.GetMax(arr));
            Constructor constructor = new Constructor();
            constructor.Show();
            Human[] human = new Human [2];
            Gender gender = new Gender("barsik", 23, "female");
            human[0] = gender;
            Console.WriteLine(human[0].Name + human[0].Age);
            Human man = gender; //UpCast
            Console.WriteLine(man.Name);
            if (man is Gender woman)//DownCast
            {
                Console.WriteLine(woman.Name);
            }

            Console.ReadKey();
        }
    }
}
