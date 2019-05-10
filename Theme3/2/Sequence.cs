using System;
namespace Classes_overload_soution
{
    public class Sequence
    {
        private double[] sequence;
        public Sequence(int n, double x1, double q)
        {
            sequence = new double[n];
            sequence.SetValue(x1, 0);
            x1 *= q;
            for (int i = 1; i < n; i++)
            {
                sequence.SetValue(x1, i);
                x1 *= q;
            }
        }
        public Sequence(string seq)
        {
            string[] seq_t = seq.Split(',');
            sequence = new double[seq_t.Length];
            int i = 0;
            foreach(string elem in seq_t)
            {
                sequence.SetValue(int.Parse(elem), i);
                i++;
            }
        }

        public int CountOfPositive
        {
            get
            {
                int count = 0;
                foreach (double val in sequence)
                    if (val >= 0)
                        count++;

                return count;
            }
        }

        public void Print()
        {
            foreach(double elem in sequence)
            {
                Console.Write(elem);
                Console.Write(" ");
            }
            Console.Write("\n");
        }

        public double MultBetw()
        {
            int minIndex = 0;
            int maxIndex = 0;
            double mult = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] > sequence[maxIndex]) maxIndex = i;
                if (sequence[i] < sequence[minIndex]) minIndex = i;
            }
            for (int i = Math.Min(minIndex, maxIndex) + 1; i < Math.Max(minIndex, maxIndex); i++)
                mult *= sequence[i];
            return mult;
        }
    }
}
