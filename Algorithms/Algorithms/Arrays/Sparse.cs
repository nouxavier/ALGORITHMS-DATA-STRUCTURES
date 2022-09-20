using System;
using System.Linq;
using Algorithms.Exceptions;
using static System.Net.Mime.MediaTypeNames;

namespace Algorithms.Arrays
{
    public class Sparse
    {
        public string[] StringList { get; private set; }
        public string[] Queries { get; private set; }
        const string MSG_LENGTH = "Input must be range size are 0 to 1000";


        public Sparse(string[] stringList, string[] queries)
        {
            if (stringList.Length < 1 || stringList.Length > 1000
                    || queries.Length < 1 || queries.Length > 1000)
                throw new DomainException(MSG_LENGTH);

            StringList = stringList;
            Queries = queries;
        }

        public int[] Contains()
        {
            List<int> result = new List<int>();
            var groupString = StringList.GroupBy(p => p).ToList();
               
            foreach (var item in Queries)
            {
                var group = groupString.Where(p => p.Key == item).ToList();
                if(group.Count> 0)
                    result.Add(group.First().Count());
                else
                    result.Add(0);
            }


            return result.ToArray();
        }
    }
}

