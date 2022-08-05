using System;
using System.Collections;
using System.Collections.Generic;

namespace Largest {
    class Driver {
        public static void Main() {
            ArrayClass obj1 = new ArrayClass();
            obj1.ArrayNum();

            ArrayListClass obj2 = new ArrayListClass();
            obj2.ArrayListNum();

            LinkedListClass obj3 = new LinkedListClass();
            obj3.LinkedListNum();
        }
    }
    class ArrayClass {
        public void ArrayNum() {
            int [] myArray = {1, 5, 3, 4, 2};
            int max = myArray[0];
            for (int i = 0; i < myArray.Length; i++) {
                if (myArray[i] > max) max = myArray[i];
            }
            System.Console.WriteLine("Largest number of Array is: " + max);
        }
    }
    class ArrayListClass {
        public void ArrayListNum() {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add(5);
            myArrayList.Add(3);
            myArrayList.Add(4);
            myArrayList.Add(2);

            int max = int.MinValue;
            foreach (int i in myArrayList)  {
                if (i > max) max = i;
            }
            System.Console.WriteLine("Largest number of ArrayList is: " + max);
        }
    }
    class LinkedListClass {
        public void LinkedListNum() {
            LinkedList <int> myLinkedList = new LinkedList<int>();
            myLinkedList.AddLast(1);
            myLinkedList.AddLast(5);
            myLinkedList.AddLast(3);
            myLinkedList.AddLast(4);
            myLinkedList.AddLast(2);

            int max = int.MinValue;
            foreach (int i in myLinkedList)  {
                if (i > max) max = i;
            }
            System.Console.WriteLine("Largest number of LinkedList is: " + max);
        }
    }
}