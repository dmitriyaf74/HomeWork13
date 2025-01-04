using HomeWork13.Classes;
using HomeWork13.Interfaces;

namespace HomeWork13
{
    internal class Program
    {

        private static void TaskMain(Type ClassType)
        {
            IStackList s = Activator.CreateInstance(ClassType) as IStackList;
            s.Init("a", "b", "c");
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

            var deleted = s.Pop();

            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
            s.Add("d");

            // size = 3, Top = 'd'
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

            s.Pop();
            s.Pop();
            s.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            //s.Pop();

        }

        private static void TaskAdd1_1()
        {
            var s = new StackList("a", "b", "c");
            s.Merge(new StackList("1", "2", "3"));
            while (s.Size > 0)
                Console.WriteLine(s.Pop());
        }

        private static void TaskAdd2_1()
        {
            var s = new StackOfItems("a", "b", "c");
            s.Merge(new StackOfItems("1", "2", "3"));
            while (s.Size > 0)
                Console.WriteLine(s.Pop());
        }


        private static void TaskAdd1_2()
        {
            var s = StackList.Concat(new StackList("a", "b", "c"), new StackList("1", "2", "3"), new StackList("А", "Б", "В"));
            while (s.Size > 0)
                Console.WriteLine(s.Pop());
        }

        private static void TaskAdd2_2()
        {
            var s = StackOfItems.Concat(new StackOfItems("a", "b", "c"), new StackOfItems("1", "2", "3"), new StackOfItems("А", "Б", "В"));
            while (s.Size > 0)
                Console.WriteLine(s.Pop());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Стек-лист");
            TaskMain(typeof(StackList));
            //---------------------------
            Console.WriteLine("");
            Console.WriteLine("Стек-цепочка");
            TaskMain(typeof(StackOfItems));


            //---------------------------


            Console.WriteLine("");
            Console.WriteLine("Стек-лист");
            TaskAdd1_1();
            //---------------------------
            Console.WriteLine("");
            Console.WriteLine("Стек-цепочка");
            TaskAdd2_1();


            //---------------------------


            Console.WriteLine("");
            Console.WriteLine("Стек-лист");
            TaskAdd1_2();
            //---------------------------
            Console.WriteLine("");
            Console.WriteLine("Стек-цепочка");
            TaskAdd2_2();


        }
    }
}
