using System;
using System.Collections;
using System.Collections.Generic;

namespace Largest {
    class Driver {
        public static void Main() {
            ArrayClass obj1 = new ArrayClass();
            int res1 = obj1.ArrayNum();
            System.Console.WriteLine("Largest number of Array is: " + res1);

            ArrayListClass obj2 = new ArrayListClass();
            int res2 = obj2.ArrayListNum();
            System.Console.WriteLine("Largest number of ArrayList is: " + res2);

            LinkedListClass obj3 = new LinkedListClass();
            int res3 = obj3.LinkedListNum();
            System.Console.WriteLine("Largest number of LinkedList is: " + res3);
        }
    }
    class ArrayClass {
        public int ArrayNum() {
            int [] myArray = {1, 5, 3, 4, 2};
            int max = myArray[0];

            for (int i = 0; i < myArray.Length; i++) {
                if (myArray[i] > max) max = myArray[i];
            }

            return max;
        }
    }
    class ArrayListClass {
        public int ArrayListNum() {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add(-5);
            myArrayList.Add(3);
            myArrayList.Add(4);
            myArrayList.Add(20);

            int max = int.MinValue;
            foreach (int i in myArrayList)  {
                if (i > max) max = i;
            }

            return max;
        }
    }
    class LinkedListClass {
        public int LinkedListNum() {
            LinkedList <int> myLinkedList = new LinkedList<int>();
            myLinkedList.AddLast(19);
            myLinkedList.AddLast(5);
            myLinkedList.AddLast(-33);
            myLinkedList.AddLast(40);
            myLinkedList.AddLast(2);

            int max = int.MinValue;
            foreach (int i in myLinkedList)  {
                if (i > max) max = i;
            }
            
            return max;
        }
    }
}