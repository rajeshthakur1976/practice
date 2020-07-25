using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

    namespace ClassLibrary1
{
    public class ClsCollections
    {
        Hashtable hTable = new Hashtable();
        Stack stack = new Stack();
        private void test1()
        {
            hTable.Add("Name", "rajes");
            hTable.Add("Age", 40);
            var xx= hTable["Name"];
            // stack
            stack.Push(10);
            stack.Push("hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');


        }

    }
}
