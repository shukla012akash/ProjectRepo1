using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    internal class ReadMatching
    {
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\TextFile.txt", FileMode.Create, FileAccess.Write);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
        }

        public void Success()
        {
            ReadMatching readMatchingObj = new ReadMatching();
            readMatchingObj.ReadFile("Success");
        }
        public void Failed()
        {
            ReadMatching readMatchingObj = new ReadMatching();
            readMatchingObj.ReadFile("Failed");
        }
        public void Dialled()
        {
            ReadMatching readAllMatchingObj = new ReadMatching();
            readAllMatchingObj.ReadFile("Dialled");
        }
        public void Missed()
        {
            ReadMatching readMatchingObj = new ReadMatching();
            readMatchingObj.ReadFile("Missed");
        }

        //ReadFile method Takes Status as a input and print all records of same status  
        public void ReadFile(String status)
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\iamte\Desktop\networkLogs1.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t    Time\tStatus\t   Network");

            //declaring a empty string for concatanate line between empty lines and then search for desired status records

            string result = "";
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    if (line.StartsWith("Date"))
                    {
                        string[] dateNTimeArr = line.Split(' ');
                        string[] dateArr = dateNTimeArr[0].Split(':');
                        result = result + dateArr[1] + "   ";
                        result = result + dateNTimeArr[1] + "\t";
                    }
                    else
                    {
                        string[] myValues = line.Split(':');
                        if (myValues[0] == "Network")
                        {
                            result += "   " + myValues[1];
                            if (result.Contains(status))
                            {
                                Console.WriteLine(result);
                            }
                            result = "";
                        }
                        else
                        {
                            result = result + myValues[1] + "\t";
                        }
                    }
                }
            }


        }
    }
}
