using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparse_Arrays_Hacker_rank
{
    class Program
    {
        // Complete the matchingStrings function below.
        static int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < strings.Length; j++)
                {
                   if( queries[i]== strings[j])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }

            return result;
        }

        static void Main(string[] args)
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            int[] res = matchingStrings(strings, queries);

            Console.WriteLine(string.Join("\n", res));

          //  textWriter.Flush();
           // textWriter.Close();
        }
    }
}
