using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode_Day_1
{
    class Program
    {
        public static List<Submarine> submarines = new List<Submarine>();
        static void Main(string[] args)
        {
            storeDatas();
            depthGrowCalc();
            Console.ReadKey();
        }

        private static void storeDatas()
        {
            string filelocation = "input.txt";
            StreamReader streamReader = new StreamReader(filelocation);
            string readline = "";
            

            if (File.Exists(filelocation))
            {
                while ((readline = streamReader.ReadLine()) != null)
                {
                    submarines.Add(new Submarine(int.Parse(readline)));
                }
            }
        }

        private static void depthGrowCalc()
        {
            
            int depthCount = 0;
            for(int i=0;i<submarines.Count-1;i++)
            {
                if(submarines[i].Depth < submarines[i+1].Depth)
                {
                    depthCount++;
                    
                }
            }
            Console.WriteLine(depthCount);
        }
    }


    public class Submarine
    {
        public int Depth;
        
        public Submarine(int depth)
        {
            this.Depth = depth;
        }

        public override string ToString()
        {
            return Depth.ToString();
        }
    }


}
