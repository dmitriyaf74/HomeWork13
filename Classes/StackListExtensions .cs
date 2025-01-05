using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using HomeWork13.Classes;


namespace HomeWork13.Classes
{
    /// <summary>
    /// Расширения для 2х классов
    /// Можно сделать общего родителя, но будем считать, что оба класса недоступны для изменений
    /// </summary>
    public static class StackListExtensions
    {
        public static void Merge(this StackList stackList, StackList stackList2)
        {
            while (stackList2.Size > 0)
                stackList.Add(stackList2.Pop());
        }

        public static void Merge(this StackOfItems stackList, StackOfItems stackList2)
        {
            while (stackList2.Size > 0)
                stackList.Add(stackList2.Pop());
        }
    }

}
