using System;

namespace FillPrintProject
{
    public class FillPrint
    {
        int[] storage;
        
        public FillPrint(int capacity = 10)
        {
            storage = new int[capacity];
            Fill();
        }

        public string Print()
        {
            return String.Join(", ", storage);
        }

        private void Fill() {
            Random random  = new Random();
            for (int i = 0; i < storage.Length; i++)
            {
                storage[i] = random.Next(1, 100);
            }
        }

        public int this[int i] {
            get => storage[i];
        }
    }
}
