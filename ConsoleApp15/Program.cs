using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Ali","Aliev",26,new int[] {1,2,3,4,5,6,7,8,9,10});
            human.getNum(human);
        }
    }
}
