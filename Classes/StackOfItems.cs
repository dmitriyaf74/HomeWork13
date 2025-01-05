using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork13.Classes;
using HomeWork13.Interfaces;
using HomeWork13.Interfaces;

namespace HomeWork13.Classes
{
    /// <summary>
    /// Последнее задание - цепочка
    /// </summary>
    public class StackOfItems: IStackList
    {
        private class StackItem
        {
            public string Value;
            public StackItem PrevItem;
            public StackItem(StackItem prevItem, string value)
            {
                PrevItem = prevItem;
                Value = value;
            }
        }

        StackItem CurItem = null;
        int size = 0;


        public StackOfItems() {}
        public StackOfItems(params string[] items)
        {
            Init(items);
        }

        public void Init(params string[] items)
        {
            foreach (var item in items)
                Add(item);
        }

        public void Add(string item)
        {
            CurItem = new StackItem(CurItem, item);
            size++;
        }

        public string Pop()
        {
            if (this.CurItem == null)
                throw new Exception("Стек пустой");
            string item = this.CurItem.Value;
            this.CurItem = this.CurItem.PrevItem;
            size--;
            return item;
        }

        public int Size { get { return size; } }

        /*StackItem должен быть public
        public void AddItem(StackItem item)
        {
            item.PrevItem = this.CurItem;
            CurItem = item;
            size++;
        }

        public StackItem PopItem()
        {
            if (this.CurItem == null)
                throw new Exception("Стек пустой");
            StackItem item = this.CurItem;
            this.CurItem = this.CurItem.PrevItem;
            size--;
            return item;
        }*/


        public string Top
        {
            get
            {
                if (Size == 0)
                    return null;
                else
                    return this.CurItem.Value;
            }
        }

        public static StackOfItems Concat(params StackOfItems[] stackLists)
        {
            StackOfItems s = new StackOfItems();
            foreach (var stackList in stackLists)
                s.Merge(stackList);
            return s;
        }


    }
}
