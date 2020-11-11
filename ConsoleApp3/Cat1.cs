using System;

namespace ConsoleApp3
{
    internal class Cat
    {
        public int HungryStatus { get; internal set; }
        public Action<object, EventArgs> HungryStatusChanged { get; internal set; }
        public object Name { get; internal set; }

        internal void Feed(byte needFood)
        {
            throw new NotImplementedException();
        }
    }
}