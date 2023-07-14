using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConAppCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection!!!");
            // ClassName objectName=new ClassName();
            //objectName.MemberName
            //bjectName.PropertyName
            //objectName.MethodName
            //ArrayList arrayList=new ArrayList();
            //array.List.Add("Ram");
            //console.WriteLine("Capacity is: \t"+arrayList.capacity);
            //arrayList.Add("Ram");
            //arrayList.Add("Ram");
            //arrayList.Add("Ram");



            //ArrayList arrayList = new ArrayList
            //{
            //    "Sam",
            //    "Ravi",
            //    "Amit",

            //};
            //Console.WriteLine("Number of Element in Array List are:\t" + arrayList.Count);
            //Console.WriteLine("Capacity of Array list is:\t" + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add("Amit");
            //arrayList.Add("Sunita");
            //Console.WriteLine("After adding two more elements in array List");
            //Console.WriteLine("Number of Element in Array List are:\t"+arrayList.Count);
            //Console.WriteLine("Capacity of Array List is:\t"+arrayList.Capacity);   
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Sort();
            //Console.WriteLine("***Sorted Array List***");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Reverse the list");
            //arrayList.Reverse();
            //Console.WriteLine("Sorted Array List in Dsc");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //ArrayList myList = new ArrayList { 12, 45, 30, 11 };
            //Console.WriteLine("Number List");
            //foreach (int i in myList)
            //{
            //    Console.WriteLine(i);
            //}
            //myList.Reverse();
            //Console.WriteLine("Reverse Number List");
            //foreach(int i in myList)
            //{
            //    Console.WriteLine(i);
            //}
            //myList.Sort();
            //Console.WriteLine("Sort Number List");
            //foreach(int i in myList)
            //{
            //    Console.WriteLine(i);
            //}

            //myList.Remove(45);
            //Console.WriteLine("After Removing 45");
            //foreach(int i in myList)
            //{
            //    Console.WriteLine(i);
            //}

            //ArrayList hardwareList=new ArrayList();
            //hardwareList.Add("CD");
            //hardwareList.Add("Printer");
            //hardwareList.Add("KeyBoard");
            //hardwareList.Add("Mouse");
            //hardwareList.Add("Network Card");
            //Console.WriteLine("Initial Hardware List");
            //for(int i=0; i<hardwareList.Count; i++)
            //{
            //    Console.WriteLine(hardwareList[i]);
            //}
            //Console.WriteLine("Enter item to search & update");
            //string searchItem=Console.ReadLine();
            //int index=hardwareList.IndexOf(searchItem);
            //if (index == -1)
            //{
            //    Console.WriteLine($"No Such item{searchItem}  exist in hardware list");
            //}
            //else
            //{
            //    Console.WriteLine("Enter Update item");
            //    hardwareList[index]=Console.ReadLine();
            //    Console.WriteLine("Update Hardware List is as follows!!!");
            //    for(int i=0; i<hardwareList.Count;i++)
            //    {
            //        Console.WriteLine(hardwareList[i]);
            //    }
            //}
            //string newItem;
            //Console.WriteLine("Enter new Item");
            //newItem = Console.ReadLine();
            //hardwareList.Add(newItem);
            //Console.WriteLine("List after adding new hardware");
            //for(int i= 0; i < hardwareList.Count; i++)
            //{
            //    Console.WriteLine(hardwareList[i]);
            //}

            //Example HashTable
            //hashtable[key]

            Hashtable hardware = new Hashtable() { { 1, "Compact Disc" }, { 2, "DVD" }, { 3, "PenDrive" } };
            Console.WriteLine("List of keys");
            foreach (var k in hardware.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("List of Values");
            foreach (var v in hardware.Values)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Hardware key \t Name of Hardware");
            foreach (var k in hardware.Keys)
            {
                Console.WriteLine(k + "\t \t" + hardware[k]);
            }


            Console.ReadKey();

        }
    }
}
