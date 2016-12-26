using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanceConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Result<int> {Success = true, Data = 5};
            var result2 = new Result<string> {Success = false, Data = "Shiva"};
            var helper = new ResultPrinter();

            helper.Print(result);
            helper.Print(result2);

        }

        public class Result<T>
        {
            public bool Success { get; set; }
            public T Data { get; set; }
            
        }

        public class ResultPrinter
        {
            public void Print<T>(Result<T> result)
            {
                Console.WriteLine(result.Success);
                Console.WriteLine(result.Data);
            }
        }

    }
}
