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
    }
}
