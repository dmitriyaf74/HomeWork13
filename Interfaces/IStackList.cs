using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork13.Classes;

namespace HomeWork13.Interfaces
{
    internal interface IStackList
    {
        public void Init(params string[] items);
        public void Add(string item);
        public string Pop();
        public int Size { get; }
        public string Top { get; }
        public static IStackList Concat(params IStackList[] stackLists)
        {
            StackList s = new StackList();
            foreach (var stackList in stackLists)
                //s.Merge(stackList);
                while (stackList.Size > 0)
                    s.Add(stackList.Pop());
            return s;
        }
    }
}
