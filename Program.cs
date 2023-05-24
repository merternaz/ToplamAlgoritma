using System;
using System.Collections.Generic;

namespace structures
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Kac adet sayı girilecek ? :");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            List<int> entry=new List<int>();
            for(int i=0;i<x;i++){
                int y=Convert.ToInt32(Console.ReadLine());
                entry.Add(y);
            }

            double showNum=0;

            for(int a=0;a<entry.Count;a++){
                if(a>0 && a%2!=0){
                    if(entry[a]!=entry[a-1]){
                        showNum=entry[a]+entry[a-1];
                    }else{
                        showNum=Math.Pow(entry[a]+entry[a],2);
                    }
                    Console.Write(showNum+" ");
                }

                
                
            }
        }
    }
}