using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //First Assignment
            //ReadFromTxtFile readFromTxtFile = new ReadFromTxtFile();
            // readFromTxtFile.ReadFile(); 


            //Second assignment
            ReadMatching readMatching = new ReadMatching();

            readMatching.Success();
            //readMatching.Failed();
            //readMatching.Dialled();
            //readMatching.Missed();


        }
    }
    }

