using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EDI_X12_Parser {
    internal class Program {
        static void Main(string[] args) {
            string ediFilename = @"c:\Users\Sheryl.Acree\Downloads\204_4819_RXOLogisticsFLSmidth.edi";
            string ediFileContents = File.ReadAllText(ediFilename);

            Console.WriteLine(ediFileContents);

            Console.WriteLine("\n\n Press enter to end;");
            Console.ReadLine();
        }
   
    }

}
