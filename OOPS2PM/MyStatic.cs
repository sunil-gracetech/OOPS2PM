using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS2PM
{
   static class MyStatic
    {
        public static string fname;
        public static string lname;
        public static int count = 0;

       
        public static string FullName()
        {
            return "Hello : "+fname + " " + lname;
        }
        
        //method overloading
        public static int Addition(int x,  int y)
        {
            return x + y;
        }
        public static double Addition(int x,  double y)
        {
            return x + y;
        }
        public static double Addition(double x,  double y)
        {
            return x + y;
        }
    }
}
