namespace Next_Permutaton
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            while(m > 0)
            {
                string line = Console.ReadLine();
                Console.WriteLine(line);
                int[] t = Array.ConvertAll(line.Split(' '), int.Parse);
                int pos = t.Length - 2;
                while(pos >= 0 && t[pos] > t[pos + 1])
                {
                    pos--;
                }
                int nextPos = t.Length - 1;
                while(pos < nextPos && t[pos] >= t[nextPos])
                {
                    --nextPos;
                }
                int tmp = t[pos];
                t[pos] = t[nextPos];
                t[nextPos] = tmp;
                for (int i = pos + 1, j = t.Length - 1; i < j; i++,j--)
                {
                    tmp = t[i];
                    t[i] = t[j];
                    t[j] = tmp;
                }
                Console.WriteLine($"{string.Join(" ",t)}");
                --m;
            }
        }
    }
}
