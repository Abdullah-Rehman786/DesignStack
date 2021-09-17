using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace DesignStack
{
    public class Program
    {
        private static void Main(string[] args)
        {

            var firstStack = new Stack();
            var trialObjectList = new List<object> {"Object1", "Object2", "Object3", "Object4" };
            var nullObj = new object();

            //trying to Pop() from an empty Stack
            try
            {
                Console.WriteLine(firstStack.Pop());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);

            }

            //Adding objects to the stack & catching a null object trying to be added
            try
            {
                firstStack.Push(trialObjectList[0]);
                firstStack.Push(trialObjectList[1]);
                firstStack.Push(trialObjectList[2]);
                firstStack.Push(trialObjectList[3]);
                firstStack.Push(nullObj);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Write order of all objects in the stack
            firstStack.PublishStack();
            Console.WriteLine("");

            //Pop each item from the stack
            foreach (var item in trialObjectList)
            {
                Console.WriteLine(firstStack.Pop());

            }
            
            firstStack.Clear();
        }
    }
}
