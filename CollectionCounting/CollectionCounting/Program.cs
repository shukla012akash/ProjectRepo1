using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace CollectionCounting
{
    internal class Program
    {
        static ArrayList al = new ArrayList();
        static void Main(string[] args)
        {
       

          
            
                //reading string from the local file
                FileStream fileStream = new FileStream(@"C:\Users\Boss\Desktop\New folder\string.txt", FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);

                streamWriter.Close();
                fileStream.Close();

                // Read entire text file content in one string  
                string myString = File.ReadAllText(@"C:\Users\Boss\Desktop\New folder\string.txt");
                myString.ToLower();

                //creating obj of charsCounting
                CharCounting charsCounting = new CharCounting();

                //assigning char-frequency pairs in Dictionary collection
                Dictionary<char, int> result = charsCounting.CountFrequencyOfEachString(myString);

                //printing all char-frequency pairs
                foreach (char c in result.Keys)
                {
                    Console.WriteLine(c + ": " + result[c]);
                }
            
        }
    }
}
    

