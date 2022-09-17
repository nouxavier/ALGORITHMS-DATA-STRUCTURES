// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;
using Algorithms.Exceptions;
using Algorithms.Sum;

/*int[,] Input = new int[,] { { 11, 2, 4 }, { 4, 5,6}, { 10, 8, -12 } };

int[] resultRight = new int[Input.GetLength(0)];
int[] resultLeft = new int[Input.GetLength(0)];
int left = 0;
int right = 0;
int aux = 0;
int index = Input.GetLength(0) - 1;

for (int i = 0; i <= index; i++)
{
    resultRight[aux] = Input[i, i];
    left = left+Input[i, i];
    resultLeft[aux] = Input[i, index - i];
    right = right + Input[i, index - i];
    aux++;
}
var result = left - right;

Console.WriteLine(resultRight);
Console.WriteLine(resultLeft);*/

/* int[] Input = new int[] { 1, 3, 5, 7, 9 };
long min = Input[0];
long max = Input[0];
long sum = 0;
for (int i = 0; i <= Input.Length - 1; i++)
{

    if (min > Input[i])
        min = Input[i];

    if (max < Input[i])
        max = Input[i];

    sum += Input[i];
}

Console.Write("{0} {1}", (sum - max), (sum - min));
        

Console.Write("{0} {1}", min, max);

Console.ReadKey();*/


var input = new string[] { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5" };



//var input = new string[] { "1", "200", "150", "3" };
/*List<KeyValuePair<string, BigInteger>> ListInput = new List<KeyValuePair<string, BigInteger>>();

bool convert;
for (int i = 0; i <= input.Length - 1; i++)
{
    convert = BigInteger.TryParse(input[i], out BigInteger value);
  
    ListInput.Add(new KeyValuePair<string, BigInteger>(input[i], value));
}

int size = ListInput.Count;






for (int j = 0; j < size-1; j++)
{
    BigInteger val = ListInput[j].Value;

    Console.WriteLine("Item lista j{0}", val);
    Console.WriteLine("j = {0}", j);
    Console.WriteLine("--------");



    for (int i = size-1; i > j; i--)
    {
        BigInteger val2 = ListInput[i].Value;
        if (val < val2)
        {
            var aux = ListInput[i];
            ListInput[i] = ListInput[i - 1];
            ListInput[i - 1] = aux;
            Console.WriteLine("Movimenta aux {0}", aux);
            foreach(var item in ListInput)
            {
                Console.Write(" {0} ", item.Key);
            }

        }

        Console.WriteLine("Item lista i {0}", val2);
        Console.WriteLine("i = {0}", i);
        Console.WriteLine("--------");
    }
};

Console.ReadKey();*/
var a = new string[] { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
Array.Sort(a, (left, right) => {
    if (left.Length != right.Length)
        return left.Length - right.Length;
    else
        return string.CompareOrdinal(left, right); // left.CompareTo(right) is too slow
});
for (int i = 0; i < a.Length; i++)
    Console.WriteLine(a[i]);

var l = a.ToList();

l.Sort((left, right) => {
    if (left.Length != right.Length)
        return left.Length - right.Length;
    else
        return string.CompareOrdinal(left, right); // left.CompareTo(right) is too slow
});

for (int i = 0; i < l.Count; i++)
    Console.WriteLine(l[i]);

Console.ReadKey();