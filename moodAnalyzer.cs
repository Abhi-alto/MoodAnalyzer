using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class moodAnalyzer
    {
        public string Msg;
        public moodAnalyzer()                           //Default constructor(empty)
        {

        }
        public moodAnalyzer(String Msg)                 //parameterized constructor
        {
            this.Msg = Msg;
        }
        public string AnalyzeMood()
        {
            if (find(Msg))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
        public bool find(string findMood)                   //segregating all the string and checking for the sad word
        {
            string[] ar = findMood.Split(' ');
            for (int x = 0; x < ar.Length; x++)
            {
                Console.WriteLine(ar[x]);
                ar[x] = ar[x].ToLower();
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


