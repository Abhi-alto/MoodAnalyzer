using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class moodAnalyzer
    {
        public string AnalyzeMood(String mood)
        {
            if (find(mood))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
        public bool find(string findMood)
        {
            string[] ar = findMood.Split(' ');
            for (int x = 0; x < ar.Length; x++)
            {
                Console.WriteLine(ar[x]);
                ar[x]=ar[x].ToLower();
                Console.WriteLine(ar[x]);
                if (ar[x].Equals("sad"))
                {
                    return false;
                }
            }
            return true;
        }

    }
}

