namespace PrimeSieveThing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 0;
            Console.Write("How many numbers do you want: ");
            maxNum = Convert.ToInt32(Console.ReadLine());
            List<int> primes = PrimeList(maxNum);
            for(int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i]+" ");
            }
            Console.WriteLine();


        }
    
    static List<int> PrimeList(int n)
    {
        List<int> primes = new List<int>();
        bool[] nums = new bool[n];
        for (int i = 2; i < nums.Length; i++)
        {
            nums[i] = true;
        }
        // for i = 2, 3, 4, ..., not exceeding √n do
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            //if A[i] is true
            if (nums[i])
            {
                //for j = i2, i2 + i, i2 + 2i, i2 + 3i, ..., not exceeding n do
                for (int j = i * i; j < n; j += i)
                {
                    nums[j] = false; //set A[j] := false
                }
            }

        }

        for (int i = 2; i < n; i++)
        {
            if (nums[i])
            {
                primes.Add(i);
            }
        }
        return primes;
    }
    }
}
