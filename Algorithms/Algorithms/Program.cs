// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Numerics;
using Algorithms.Exceptions;
using Algorithms;
using Algorithms.Heap;
using Algorithms.LinkedList;
using Algorithms.Sum;
using Algorithms.Tree;
using Algorithms.Sort;
using Algorithms.Search;
using Algorithms.DynamicProgramming;

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


//var input = new string[] { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5" };



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
/*var a = new string[] { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
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

Console.ReadKey();*/
/*int[] arr2 = { -5, -10, 0, -3, 8, 5, -1, 10 };
Algorithms.Sort.QuickSort.CountSort(arr2);
Algorithms.Sort.QuickSort.printArray(arr2);
int n = Convert.ToInt32(Console.ReadLine().Trim());

List<List<string>> arr = new List<List<string>>();

for (int i = 0; i < n; i++)
{
    var a = Console.ReadLine().TrimEnd().Split(' ').ToList();
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
}


int[] Input = new int[] { 1,4,3,5,6,2 };
//int[] A = new int[] { 4, 1, 3, 5, 6, 2 };
int[] A = new int[] { 2, 1, 3, 1, 2 };

var j = 0;
var s = 0;
for (var i = 1; i < A.Length; i++)
{
    var value = A[i];
    j = i - 1;
    while (j >= 0 && value < A[j])
    {
        A[j + 1] = A[j];
        j = j - 1;
        s = s + 1;
    }
    A[j + 1] = value;
}
Console.WriteLine(string.Join(" ", A));


int size = Input.Length;
int val = Input[0];
for (int i = 1; i <= size-1; i++)
{
    val = Input[i];   
    for ( j = i - 1; (j >=0) ; j--)
    {
        var v2 = Input[j];

        if (val < v2)
        {
            Input[j + 1] = Input[j];
            Input[j] = val;
        }
    }
    Console.WriteLine("{0}", string.Join(" ", Input));
}







for (int i = Input.Length - 1; i > 0; i--)
{
    val = Input[i];
    for ( j = i - 1; j >= 0; j--)
    {
        var v2 = Input[j];
        if (v2 > val)
        {
            Input[j + 1] = Input[j];
            Console.WriteLine("[{0}]", string.Join(" ", Input));
            Input[j] = val;
        }
            
    }

}
Console.WriteLine("[{0}]", string.Join(" ", Input));
Console.ReadKey();*/


/*SinglyLinkedList llist = new SinglyLinkedList();

int llistCount = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < llistCount; i++)
{
    int llistItem = Convert.ToInt32(Console.ReadLine());
    llist.InsertNode(llistItem);
}

var head = llist.head;
bool run = true;
while (run)
{
    Console.WriteLine(head.next.data);
    head.next = head.next.next;
    if (head.next == null)
    {
        run = false;
    }

}*/

/*
 
                '+'
               /   \
             'a'   '*'
                   /  \
                 'b'   '-'
                      /   \
                    '/'    'e'
                   /   \
                 'c'   'd'
    
 */



/*var n1 = new Node("a");
var n2 = new Node("+");
var n3 = new Node("*");
var n4 = new Node("b");
var n5 = new Node("-");
var n6 = new Node("/");
var n7 = new Node("c");
var n8 = new Node("d");
var n9 = new Node("e");

n6.Left = n7;
n6.Right = n8;

n5.Left = n6;
n5.Right = n9;

n3.Left = n4;
n3.Right = n5;

n2.Left = n1;
n2.Right = n3;

var tree = new BinaryTree(n2);
tree.SimetricTraversalString();*/

/*
 
                '3'
              /   \
            'e'    '5'
            / \     /
          'i' 'r'  'a'   
              / \    \
            'n' 'c'   'v'    
                  \
                  's'
    
 */

/*var n1 = new Node("I");
var n2 = new Node("N");
var n3 = new Node("S");
var n4 = new Node("C");
var n5 = new Node("R");
var n6 = new Node("E");
var n7 = new Node("V");
var n8 = new Node("A");
var n9 = new Node("5");
var n0 = new Node("3");

n0.Left = n6;
n0.Right = n9;

n6.Left = n1;
n6.Right = n5;

n5.Left = n2;
n5.Right = n4;

n4.Right = n3;
n9.Left = n8;
n8.Right = n7;

var tree = new BinaryTree(n5);
tree.PosOrderTraversalString();
var h = tree.Height();*/

/*Random rd = new Random(77);
int[] values = new int[42];

for(int i = 0; i<42;i++)
{
    values[i] = rd.Next(1, 1000);
}

var bst = new BinarySearchTree();
foreach(var value in values)
    bst.Insert(value);

bst.InOrderInt();

var items = new int[] { 10002, 241, 993, 21, 49, 504, 1000 };

foreach(var item in items)
{
    var result = bst.Search(item);

    if (result == null)
        Console.WriteLine("{0} - Não encontrado", item);
    else
        Console.WriteLine(" {0} - encontrado", result.Root.DataInt);
}

var heloo = "";*/


/*List<int> prices = new List<int> { 1,3,2};
var k = 1;


var size = prices.Count();
var right = (size - 1) - k;
var spikRight = prices.ElementAt(size - 1- k);

var spikLeft = prices.ElementAt(k);
var count = 0;

List<int> r = new List<int>();
List<int> l = new List<int>();

for (int i = right + 1; i < size; i++)
{
    if (prices[i] < spikRight)
    {
        r.Add(prices[i]);
    }
}

for (int i = 0; i < right; i++)
{
    if (prices[i] < spikRight)
    {
        l.Add(prices[i]);
    }
}

if(r.Count == k || l.Count >0)
{
    count++;
}

r.Clear();
l.Clear();

for (int i = 0; i < k; i++)
{
    if (prices[i] < spikLeft)
    {
       l.Add(prices[i]);
    }
}

for (int i = k+1; i < size; i++)
{
    if (prices[i] < spikLeft)
    {
        r.Add(prices[i]);
    }
}

if (l.Count == k || r.Count > 0)
{
    count++;
}


var tes = "";

List<int> products = new List<int> { 2, 9, 4, 7, 5, 2 };
products.Sort();

long min = 0;
long max = 0;
int size = products.Count - 1;

List<long> results = new List<long>();

for (int i = 1; i <size; i++)
{
    int value = products[i];
   for(int j = 0; j <= i; j++)
   {
        if (value[])
   }

}*/

/*int[] values = new int[] {61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32};

var bst = new BinarySearchTree();
foreach (var value in values)
    bst.Insert(value);

Console.WriteLine("Pre remove -  order");
bst.InOrderInt();
Console.WriteLine("Pre remove - order level");
bst.LevelOrderTraversalInt();


bst.Remove(66,null, true);

Console.WriteLine("Pós remove - order");
bst.InOrderInt();
Console.WriteLine("Pós remove - order level");
bst.LevelOrderTraversalInt();


int min = bst.Min();
Console.WriteLine(min);

int max = bst.Max();
Console.WriteLine(max);*/


/*Graphs g = new Graphs(4);

g.AddEdge(0, 1);
g.AddEdge(0, 2);
g.AddEdge(1, 2);
g.AddEdge(2, 0);
g.AddEdge(2, 3);
g.AddEdge(3, 3);*/

/*List<int> inputs = new List<int> { 61, 89, 66, 43, 51, 16, 55, 11, 79, 77, 82, 32 };
Console.WriteLine("Input> [{0}]", string.Join(", ", inputs));
var teste = QuickSort2.Sort(inputs, 0, inputs.Count - 1);*/

/*int[] input = new int[] { 3, 1, 3, 4, 2 };

/*var result = Duplicate.SearchDuplicate(input, 0, input.Length-1);

var nums = new int[]{5, 7, 7, 8, 8,8, 10};
int target = 8;
var result = FirstLastPosition.SearchRange(nums, target);*/

//Anagrams.IsAnagram("rat", "car");
Anagrams.IsAnagram("anagram", "nagaram");
Console.ReadKey();









