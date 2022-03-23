using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nueipTest
{
    class Program
    {
        // 1. 物件導向-繼承/介面
        interface IVehicle
        {
        }
        class Car : IVehicle
        {
        }
        class Motorcycle : IVehicle
        {
        }
        class SportCar : Car
        {
        }

        // 2. 資料處理-字串
        class ex2
        {
            string demo = "人易科技:上 機 測 驗 - 演算法";

            public void showAnswers()
            {
                Console.WriteLine("0. 原字串:");
                Console.WriteLine(demo);
                Console.WriteLine("");

                demo = demo.Replace(':', '：');
                Console.WriteLine("1. 全型冒號:");
                Console.WriteLine(demo);
                Console.WriteLine("");

                demo = demo.Replace(" - ", "[preserve]");
                demo = demo.Replace(" ", "");
                demo = demo.Replace("[preserve]", " - ");
                Console.WriteLine("2. 去掉空白:");
                Console.WriteLine(demo);
                Console.WriteLine("");

                int position = demo.IndexOf('-');
                Console.WriteLine("3. 列印符號:");
                Console.WriteLine(demo.Substring(0, position));
                Console.WriteLine("");
            }
        }

        // 3. 資料處理-陣列
        class ex3
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> Odds;
            List<int> Evens;
            int OddMinusEven()
            {
                int ans = 0;
                foreach(int n in arr){
                    if (n % 2 == 0)
                        ans -= n;
                    else
                        ans += n;
                }
                return ans;
            }
            void Seperate()
            {
                Odds = new List<int>();
                Evens = new List<int>();
                foreach(int n in arr)
                {
                    if (n % 2 == 0)
                        Evens.Add(n);
                    else
                        Odds.Add(n);
                }
            }
            public void showAnswers()
            {
                Console.WriteLine("1. 奇數總和減偶數總和:");
                Console.WriteLine(OddMinusEven());
                Console.WriteLine("");

                Seperate();
                Console.WriteLine("2. 分割陣列:");
                Console.WriteLine("Evens: ");
                foreach (int n in Evens)
                    Console.Write($"{n} ");
                Console.WriteLine("");

                Console.WriteLine("Odds: ");
                foreach (int n in Odds)
                    Console.Write($"{n} ");
                Console.WriteLine("");
            }
        }

        // 4. 資料排序-正序
        class ex4
        {
            int[] arr = new int[] { 77, 5, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9 };
            void sort()
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    for(int j = i+1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            int tem = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tem;
                        }
                    }
                }
            }
            public void showAnswers()
            {
                Console.WriteLine("排序前:");
                foreach (int n in arr)
                    Console.Write($"{n}, ");
                Console.WriteLine("");

                sort();
                Console.WriteLine("排序後:");
                foreach (int n in arr)
                    Console.Write($"{n}, ");
                Console.WriteLine("");
            }
        }

        // 5. 邏輯處理-交集、差集、聯集
        class ex5
        {
            int[] arrA = new int[] { 77, 5, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9 };
            int[] arrB = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> arrC;
            List<int> arrD;
            List<int> arrE;
            void getArrC()
            {
                arrC = new List<int>();
                Dictionary<int, bool> map = new Dictionary<int, bool>();
                foreach (int n in arrB)
                    map[n] = false;
                foreach (int n in arrA)
                    map[n] = true;
                foreach(int n in arrB)
                    if (map[n])
                        arrC.Add(n);
            }
            void getArrD()
            {
                arrD = new List<int>();
                Dictionary<int, bool> map = new Dictionary<int, bool>();
                foreach (int n in arrA)
                    map[n] = false;
                foreach (int n in arrB)
                    map[n] = true;
                foreach (int n in arrA)
                    if (!map[n])
                        arrD.Add(n);
            }
            void getArrE()
            {
                arrE = new List<int>();
                Dictionary<int, bool> map = new Dictionary<int, bool>();
                foreach (int n in arrA)
                    map[n] = true;
                foreach (int n in arrB)
                    map[n] = true;
                foreach (var p in map)
                    if (p.Value)
                        arrE.Add(p.Key);
            }
            public void showAnswers()
            {
                getArrC();
                Console.WriteLine("1. 陣列a 交集 陣列b:");
                foreach (int n in arrC)
                    Console.Write($"{n} ");
                Console.WriteLine("");

                getArrD();
                Console.WriteLine("1. 陣列a 差集 陣列b:");
                foreach (int n in arrD)
                    Console.Write($"{n} ");
                Console.WriteLine("");

                getArrE();
                Console.WriteLine("1. 陣列a 聯集 陣列b:");
                foreach (int n in arrE)
                    Console.Write($"{n} ");
                Console.WriteLine("");
            }
        }

        // 6. 兩數總和
        class ex6
        {
            #region test case
            public void showAnswers()
            {
                int[] k = new int[] { 3, 2, 4 };
                int t = 6;
                int[] ans = twoSum(k, t);
                Console.WriteLine($"{ans[0]}, {ans[1]} ");
            }
            #endregion
            int[] twoSum(int[]nums,int target)
            {
                int[] ans = new int[2];
                for(int i = 0; i < nums.Length; i++)
                {
                    for(int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            ans[0] = i;
                            ans[1] = j;
                            break;
                        }
                    }
                }
                return ans;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== 2. 資料處理-字串 ===");
            new ex2().showAnswers();

            Console.WriteLine("=== 3. 資料處理-陣列 ===");
            new ex3().showAnswers();

            Console.WriteLine("=== 4. 資料排序-正序 ===");
            new ex4().showAnswers();

            Console.WriteLine("=== 5. 邏輯處理-交集、差集、聯集 ===");
            new ex5().showAnswers();

            Console.Read();
        }
    }
}
