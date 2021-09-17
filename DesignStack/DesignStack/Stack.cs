using System;
using System.Collections.Generic;

namespace DesignStack
{
    public class Stack
    {
        private readonly List<object> _stackObjectList = new List<object>();

        public void Push(object obj)
        {
            if (obj.ToString() == "System.Object")
            {
                throw new InvalidOperationException("You cannot push a null object onto the stack.");
            }
            else
            {
                _stackObjectList.Add(obj);
            }
        }

        public object Pop()
        {
            var i = (_stackObjectList.Count - 1);
            if (i <= -1)
            {
                throw new InvalidOperationException("You cannot pop an object from an empty stack.");
            }
            else
            {
                var poppedObj = _stackObjectList[i];
                _stackObjectList.RemoveAt(i);
                return poppedObj;
            }
            
            
        }

        public void PublishStack()
        {
            foreach (var stackobj in _stackObjectList)
            {
                Console.WriteLine(stackobj);
            }
        }
        public void Clear()
        {
            _stackObjectList.Clear();
        }
    }
}