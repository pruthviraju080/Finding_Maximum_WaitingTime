using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {

        public static int Find_Maxium_WaitingTime(int[] A, int X, int Y, int Z)
        {
            // 1 2 3 4 5 6 7 -- 1 7 2 6 3 5 4

            //var A = new int[] {5};    

            var dispen = new Dictionary<string, int>
            {
                {"X",X },
                {"Y", Y },
                {"Z", Z },
                {"x", 0 },
                {"y", 0 },
                {"z",0 }

            };

            var seconds = 0;
            //var currentDispence = 0;
            var list = new List<int>(A);
            var array = new List<int>();
            foreach (var item in list)
            {
                array.Add(item);
            }

            var loopcount = 0;
            //var count = 0;
            var secondsCount = 0;
                
            //var array = list;
            while (list.Count > 0)
            {
                var currentDispence = 0;
                var i = 0;

                while (currentDispence < 3)
                {
                    if (list.Count > 0 && dispen.ElementAt(currentDispence).Value - array[i] >= 0
                            && seconds >= dispen[dispen.ElementAt(currentDispence).Key.ToLower()])
                    {
                        dispen[dispen.ElementAt(currentDispence).Key.ToLower()] =
                                dispen.ElementAt(currentDispence).Value - (dispen.ElementAt(currentDispence).Value - array[i]);
                        dispen[dispen.ElementAt(currentDispence).Key] = dispen.ElementAt(currentDispence).Value - array[i];
                        list.Remove(array[i]);
                        secondsCount = secondsCount + dispen[dispen.ElementAt(currentDispence).Key.ToLower()];
                        i++;
                    }

                    currentDispence++;
                    
                }

                if (list.Count == 0) return seconds;

                if (loopcount > A.Length * 3) return -1;

                array.Clear();
                foreach (var item in list)
                {
                    array.Add(item);
                }

                seconds++;
                loopcount++;
            }
            
            return seconds;
        }
        static void Main(string[] args)
        {
            //var A = new int[] {5};
            var A = new int[] { 2, 8, 4, 3, 2 };
            //access the function 
            //Console.WriteLine("The Maximum Waiting time: " + Find_Maxium_WaitingTime(A, 4, 0, 3));

            Console.WriteLine("The Maximum Waiting time: " + Find_Maxium_WaitingTime(A, 7, 11, 3));

        }
    }
}
