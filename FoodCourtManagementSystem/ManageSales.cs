using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodCourtManagementSystem
{
    public class ManageSales
    {
        private int itemId;
        private string ItemName;


        // ADD ITEM
        public void AddItemToTheManageSales()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\sales.txt", FileMode.Append, FileAccess.Write);
            StreamWriter swObj = new StreamWriter(fileStreamObj);
            int counter = 1, totalItem;
            Console.WriteLine("Enter total number Of Food Item you want to add in the ManageSales");
            totalItem = Convert.ToInt32(Console.ReadLine());
            while (counter <= totalItem)
            {
                Console.WriteLine("Enter itemId.");
                itemId = Convert.ToInt32(Console.ReadLine());
                swObj.Write(itemId + ",");

                Console.WriteLine("Enter item name.");
                ItemName = Console.ReadLine();
                swObj.Write(ItemName + ",");

                counter++;
            }
            swObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");

        }
        // EDIT ITEM
        public void EditItemDetailFile(string itemName)
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\sales.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);

            FileStream fileStreamWObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\sales.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamWObj);

            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] itemDataArr = line.Split(',');
                if (line.Contains(itemName))
                {
                    continue;
                }
                else
                {
                    for (int i = 0; i < itemDataArr.Length; i++)
                        streamWriterObj.Write(itemDataArr[i] + ",");
                }

            }
            streamWriterObj.Close();
            streamWriterObj.Close();

            File.Delete(@"C: \Users\Boss\Desktop\New folder\file2.txt");
            File.Move(@"C:\Users\Boss\Desktop\console\ConsoleApp\LibraryManagment\LibraryManagment", @"C:\Users\Boss\Desktop\New folder\sales.txt");

        }

        // AVAILABLE ITEM
        public void ShowAvailableItem()
        {

            FileStream fileStreamObj = new FileStream(@"C:\Users\Boss\Desktop\New folder\sales.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            Console.WriteLine("itemId\titemName\titemOwner");
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] itemDataArr = line.Split(',');

                for (int i = 0; i < itemDataArr.Length; i++)
                {
                    Console.Write(itemDataArr[i] + "\t");
                    if (i == 1)
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("");
            }
            streamReaderObj.Close();
            fileStreamObj.Close();
        }


    }

    
}
    

