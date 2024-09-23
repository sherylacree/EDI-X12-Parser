using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EDI_X12_Parser {
     class Program {
        static void Main(string[]args) {
            string ediFilename = @"\\tql.com\shares\RedirectedFolders\Sheryl.Acree\My Documents\Udemy EDI Training Documents\Sample_850_01_Orig.edi.txt";
           //insert any file name above
            string ediFileContents = File.ReadAllText(ediFilename);

            Console.WriteLine(ediFileContents);

            string elementSeperator = ediFileContents.Substring(103,1);
            //add the position # of the file's element seperator here, this one is an asterisk, for C# it will be position # minus 1            
            string lineSeperator = ediFileContents.Substring(105, 1);
            //add the position # of the file's line/segment seperator here, this one is a tilde,  for C# it will be position # minus 1  

            ediFileContents = ediFileContents.Replace("\r", "").Replace("\n", "");//replace the carriage return and line feeds with nothing

            
            Console.WriteLine("elementSeperator = " + elementSeperator);
            Console.WriteLine("lineSeperator = " + lineSeperator );

            string[] lines = ediFileContents.Split(char.Parse(lineSeperator));
            Console.WriteLine("Number of lines = " + lines.Length);
            

            foreach (string line in lines) 
                {
               
                Console.WriteLine(line);
                string[] elements = line.Split(char.Parse(elementSeperator));
                int loopCounter = 0;
                string segment = "";
                string elNum = "";
                string elName = "";

                foreach (string el in elements) 
                {
                    if (loopCounter == 0)
                        {
                    segment = el;
                    }
                    else {
                        elNum = loopCounter.ToString("D2");
                        elName = segment + elNum;
                    Console.WriteLine( elName + " = " + el);
                    }
                    
                    loopCounter++;
                }
           
            
            }

            Console.WriteLine("\n\n Press enter to end;");//to keep the data on screen
            Console.ReadLine();
        }
   
    }

}
