using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnersGuide
{
    public class P383_RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var dicMag= new Dictionary<char, int>();
            var dicNote = new Dictionary<char, int>();

            foreach(var r in ransomNote)
            {
                if(!dicNote.ContainsKey(r))
                {
                    dicNote.Add(r, 1);
                }
                else
                    dicNote[r]++;
            }

            foreach (var r in magazine)
            {
                if (!dicMag.ContainsKey(r))
                {
                    dicMag.Add(r, 1);
                }
                else
                    dicMag[r]++;
            }

            int val = 0;
            foreach (var pair in dicNote)
            {
                bool isInMagazine = dicMag.TryGetValue(pair.Key, out val);
                if (!isInMagazine) return false;

                bool notEnoughtLetters = val < pair.Value;
                if (notEnoughtLetters) return false;
            }

            return true;
        }
    }
}
