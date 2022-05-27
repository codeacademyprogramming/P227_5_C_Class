using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };

            AddNum(ref nums, 10);
            AddNum(ref nums, 44);
            AddNum(ref nums, 14);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            string name = "  Hello,   World!  ";

            RemoveEmpty(ref name);

            Console.WriteLine(name);

            int num = -10;

            MakePositive(ref num);

            Console.WriteLine(num);

            int[] numbers = { -2, 45, -20, -10 };

            MakePositive(numbers);

            foreach (var item in numbers)   
            {
                Console.WriteLine(item);
            }
        }


        static void SetZero(int[] arr)
        {
            arr[arr.Length - 1] = 0;
        }

        static void Reset(out int[] arr)
        {
            arr = new int[0];
        }

        #region Task1
        // Parameter olaraq integer array variable-i ve bir integer value qebul
        // eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.
        static void AddNum(ref int[] arr,int value)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;
            arr = newArr;
        }


        #endregion

        #region Task2
        // Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri
        // boşluqlar qalmayacaq hala gətirən metod

        static void RemoveEmpty(ref string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]!=' ')
                    newStr+=str[i];
            }

            str = newStr;
        }
        #endregion

        #region Task3
        //Qəbul etdiyi ədədi musbətə ceviren metod

        static void MakePositive(ref int num)
        {
            if (num < 0)
                num *= -1;
        }
        #endregion

        #region task4
        //Qəbul etdiyi ədədlər siyahısının içərisindəki bütün ədədləri
        //müsbət hala gətirən metod

        static void MakePositive(int[] arr)
        {
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    arr[i] *= -1;
            }
        }
        #endregion
    }
}
