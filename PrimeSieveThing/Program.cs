namespace PrimeSieveThing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 0;
            Console.Write("How many numbers do you want: ");
            maxNum = Convert.ToInt32(Console.ReadLine());
            List<int> primes = PrimeList(maxNum); // create a list of prime numbers under the number entered
            //a list is a dynamic data structure
            //it works in a similar way to an array
            //Count is the list version of Length for an array
            //indexing starts at 0 as with an array
            for (int i = 0; i < primes.Count; i++) //iterate through the list
            {
                Console.Write(primes[i] + " ");//output the prime number
            }
            Console.WriteLine();


        }

        static List<int> PrimeList(int n)
        {
            // a list has a data type in the same way an array does
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
            // This goes through the boolean array and if the number is prime
            // it adds it to a list 
            // this results in a list only containing prime numbers
            for (int i = 2; i < n; i++)
            {
                if (nums[i])
                {
                    primes.Add(i); //adding an item to a list adds it at the end
                }
            }
            return primes;
        }
    }
}
