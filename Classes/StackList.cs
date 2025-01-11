using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork13.Classes;
using HomeWork13.Interfaces;

namespace HomeWork13.Classes
{
    /// <summary>
    /// Основное задание - список
    /// </summary>
    public class StackList: IStackList
    {
        private readonly List<string> _stackList = new List<string> {};

        public StackList() {}

        public StackList(params string[] items)
        {
            Init(items);
        }

        public void Init(params string[] items)
        {
            foreach (var item in items)
                Add(item);
        }

        public void Add(string item) { _stackList.Add(item); }

        public string Pop()
        {
            if (Size == 0)
                throw new Exception("Стек пустой");
            int itemindex = Size - 1;
            string item = this._stackList[itemindex];
            this._stackList.RemoveAt(itemindex);
            return item;
        }

        public int Size { get { return _stackList.Count; } }

        public string? Top 
        {  
            get 
            {
                if (Size == 0)
                    return null;
                else
                    return this._stackList[Size - 1]; 
            } 
        }

        public static StackList Concat(params StackList[] stackLists)
        {
            StackList s = new StackList();
            foreach (var stackList in stackLists)
                s.Merge(stackList);
            return s;
        }

    }
}
