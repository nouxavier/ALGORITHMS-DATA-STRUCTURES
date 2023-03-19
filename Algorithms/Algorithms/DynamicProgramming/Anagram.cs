using System;
namespace Algorithms.DynamicProgramming
{
    public class Anagrams
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            
            var sChar = s.ToCharArray();
            Dictionary<char, List<char>> d = new Dictionary<char, List<char>>();
            List<char> l;
            foreach (var item in sChar)
            {

                if (!d.TryGetValue(item, out l))
                {
                    l = new List<char>();
                    l.Add(item);
                    d.Add(item, l);
                }
                else
                {
                    l.Add(item);
                }
                    

            }

            foreach (var item in t.ToArray())
            {
                if (d.TryGetValue(item, out l))
                {
                    if(l.Count> 0)
                        l.RemoveAt(0);
                    if (l.Count == 0)
                        d.Remove(item);

                }

            }

            if (d.Count > 0)
            {
                return false;
            }

            return true;
           

        }

    }
}

