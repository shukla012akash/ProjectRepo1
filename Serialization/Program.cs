using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        public static void SerializeData()
        {
            string str = "Welcome at TutorialRide.";
            // Create file to save the data.
            FileStream fs = new FileStream(@"D:\MyDataFile.txt", FileMode.Create);
            // BinaryFormatter object will perform the serialization
            BinaryFormatter bf = new BinaryFormatter();
            // Serialize() method serializes the data to the file
            bf.Serialize(fs, str);
            // Close the file
            fs.Close();
        }
        static void DeSerializeData()
        {
            // Open file to read the data
            FileStream fs = new FileStream(@"D:\MyDataFile.txt", FileMode.Open);
            // BinaryFormatter object performs the deserialization
            BinaryFormatter bf = new BinaryFormatter();
            // Create the object to store the deserialized data
            string data = "";
            data = (string)bf.Deserialize(fs);
            //// Close the file
            fs.Close();
            // Display the deserialized strings
            Console.WriteLine("Your deserialize data is ");
            Console.WriteLine(data);
        }
    }
}
        
    

        
            