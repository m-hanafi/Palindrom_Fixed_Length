// See https://aka.ms/new-console-template for more information


namespace Palindrom_Fixed_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] queries = {1,2,3,4,5,90};
            int intLength = 3;

            KthPalindrome(queries,intLength);

        }

        static long[] KthPalindrome(int[] queries, int intLength)
        {

            List<int> lst_Pal = new List<int>();

            int i = 0;
            int rem = 0;
            int rev = 0;

            while (i.ToString().Length < intLength+1)
            {
                if (i.ToString().Length==intLength)
                {              
                    //reverse number     
                    int x = i;
                    while(x!=0)
                    {
                        rem = x%10;
                        rev = rev*10 + rem;
                        x/=10;
                    }

                    //Check palindrom
                    if (i==x)
                    {
                        lst_Pal.Add(i);
                    }               
                }
                i++;
            }

            long[] arrPal = new long[queries.Length];
            int j = 0;
            foreach (int index in queries)
            {
                int intpal = lst_Pal[index+1];
                arrPal[j] = intpal;
                j++;              
            }

            return arrPal;

        }
    }
    
}
