using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Aggregate function
            //List<int> list = new List<int>() {  1, 2, 3, 4 };
            //var Result = list.Aggregate(0 , fun);
            //var Sum = list.Aggregate(0 , (totalSum , i) => totalSum + i);
            //Console.WriteLine(Result);
            //Console.WriteLine(Sum);
            #endregion

            #region All function
            //return true if all elements saticfy the condition
            //List<string> list = new List<string>() { "Ahmed", "Amr", "Ammar" };
            //var Result = list.All(word => word.StartsWith('A'));
            //Console.WriteLine(Result);
            #endregion

            #region Any function
            //return true if any element in the sequance exist or satisfy the condition
            //List<int> list = new List<int>();
            //var Result = list.Any();
            //Console.WriteLine(Result);
            //list.AddRange(new int[] { 1 , 2 , 3 , 4 ,5});
            //Result = list.Any(element => element % 2 == 0);
            //Console.WriteLine(Result);
            #endregion

            #region Append function
            //Add item to end of a copy of array original one dose not change
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5};
            //var Result = list.Append(9);
            //foreach(var item in Result) {
            //    Console.WriteLine(item);    
            //}
            #endregion

            #region Average function
            //return BaseNumberConverter represent average of the specified sequance
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5};
            //var Result = list.Average(num => num % 2);
            //var Result2 = list.Average();
            //var Result3 = list.Where(num => num % 2 == 0).Average();
            //Console.WriteLine(Result);
            //Console.WriteLine(Result2);
            //Console.WriteLine(Result3);
            #endregion

            #region Contains function
            //Determines whether a sequence contains a specified element.
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5};
            //var Result = list.Contains(5);
            //var Result2 = list.Contains(0);
            //Console.WriteLine(Result);
            //Console.WriteLine(Result2);
            #endregion

            #region Count function
            // return number of element in array or number of element satisfy a condition.
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 7, 8, 9 };
            //var Result = list.Count();
            //var Result2 = list.Count(num => num % 2 == 0);
            //Console.WriteLine(Result);
            //Console.WriteLine(Result2);
            #endregion

            #region Distinct function
            // return sequance of distinct values
            //List<int> list = new List<int>() { 1, 1, 2, 2, 3, 3};
            //var Result = list.Distinct();
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region ElementAtOrDefult function
            // if element find return element else returndefult value of the data type of sequance
            //List<string> list = new List<string>() { "AA", "BB", "CC"};
            //string Result = list.ElementAtOrDefault(10);
            //Console.WriteLine(string.IsNullOrEmpty(Result));
            #endregion

            #region FirstOrDefult function
            // return first element satisfy a condition other wise return the null
            // if no condition return the first element of array of null if array is empty
            //List<string> list = new List<string>();
            //List<int> list2 = new List<int>() { 1, 2, 3, 4};
            //var Result = list.FirstOrDefault();
            //var Result2 = list2.FirstOrDefault(num => num % 2 == 0);
            //Console.WriteLine(Result is null);
            //Console.WriteLine(Result2);
            #endregion

            #region GroupBy function
            //List<Person> list = new List<Person>() {
            //    new Person{Age = 8 , Name = "Ahmed"},
            //    new Person{Age = 4 , Name = "Yaser"},
            //    new Person{Age = 1 , Name = "Yousef"},
            //    new Person{Age = 4 , Name = "Mohamed"}
            //};

            //var Result = list.GroupBy(element => element.Age);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var value in item)
            //        Console.WriteLine(value.Name);
            //}

            //var Result2 = from person in list
            //              group person by person.Age;
            //foreach (var item in Result2)
            //{
            //    Console.Write(item.Key + " : ");
            //    foreach (var value in item)
            //        Console.Write(value.Name + " ");
            //    Console.WriteLine();
            //}

            //List<Person> list2 = new List<Person>() {
            //    new Person{Age = 8.3f , Name = "Ahmed"},
            //    new Person{Age = 4.9f , Name = "Yaser"},
            //    new Person{Age = 1.5f , Name = "Yousef"},
            //    new Person{Age = 4.3f , Name = "Mohamed"}
            //};
            //var Result3 = from person in list2
            //              group person by Math.Floor(person.Age)
            //              into AgeGroups
            //              select new { Key = AgeGroups.Key, Count = AgeGroups.Count() };
            //foreach (var item in Result3)
            //{
            //    Console.WriteLine(item);
            //}

            //var Result4 = list2.GroupBy(person => Math.Floor(person.Age), person => person.Age);
            //var Result5 = Result4.Select(Age => new { Key = Age.Key, Count = Age.Count(), Min = Age.Min(), Max = Age.Max()});
            //foreach (var item in Result5)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region LastOrDefult function
            // return last element satisfy a condition other wise return null
            // if no condition return the last element of array or null if empty
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            //List<string> list2 = new List<string>();
            //var Result = list.LastOrDefault(i => i % 2 == 0);
            //var Result2 = list2.LastOrDefault();
            //Console.WriteLine(Result);
            //Console.WriteLine(Result2 is null);
            #endregion

            #region Max function
            // return max number satsify the condition
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 7};
            //var Result = list.Max();
            //Console.WriteLine(Result);

            //Dictionary<int , string> d = new Dictionary<int , string>()
            //{
            //    {1 , "Ahmed"},
            //    {2 , "Yousef"},
            //    {3 , "Yaser"},
            //    {4 , "Mohamed"}
            //};
            //var Result2 = d.Max(item => item.Key + item.Value.Length);
            //Console.WriteLine(Result2);
            #endregion

            #region Min Function
            // return min number satsify the condition
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 7 };
            //var Result = list.Min();
            //Console.WriteLine(Result);

            //Dictionary<int, string> d = new Dictionary<int, string>()
            //{
            //    {1 , "Ahmed"},
            //    {2 , "Yousef"},
            //    {3 , "Yaser"},
            //    {4 , "Mohamed"}
            //};
            //var Result2 = d.Min(item => item.Key + item.Value.Length);
            //Console.WriteLine(Result2);
            #endregion

            #region OrderBy function
            // Sorts the elements of a sequence in ascending order according to a key.
            //List<int> list = new List<int>() { 2, 4, 5, 2, 1, 3};
            //var Result = list.OrderBy(x => x);
            //foreach ( var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> list = new List<Person>()
            //{
            //    new Person() {Age = 8, Name = "Ahmed"},
            //    new Person() {Age = 10, Name = "Yousef"},
            //    new Person() {Age = 2, Name = "Yaser"},
            //    new Person() {Age = 4, Name = "Mohamed"}
            //};

            //var Result = list.OrderBy(x => x.Age);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Age + " " + item.Name);
            //}
            #endregion

            #region Select function
            // Projects each element of a sequence into a new form by incorporating the element's index
            //List<int> list = new List<int>()
            //{
            //    1 , 2, 3, 4, 5, 6, 7, 8, 9, 10,
            //};
            //var Result = list.Select(x => x * x);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region SingleOrDefult function
            /// if no condition Returns the only element of a sequence, or a default value if the sequence is empty; 
            /// this method throws an exception if there is more than one element in the sequence.
            /// Returns the only element of a sequence that satisfies a specified condition or a default value if no such element exists; 
            /// this method throws an exception if more than one element satisfies the condition.
            //List<int> list = new List<int>() { 1, 2, 3, 5, 7 };
            //var Result = list.SingleOrDefault(item => item % 2 == 0);
            //Console.WriteLine(Result);

            //List<int> list2 = new List<int>();
            //var Result2 = list2.SingleOrDefault();
            //Console.WriteLine(Result2 is 0);
            #endregion

            #region Where function
            //Filters a sequence of values based on a predicate.
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            //var Result = list.Where(i => i % 2 == 0);
            //foreach ( var i in Result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            Console.ReadKey();
        }
        public class Person
        {
            public float Age { get; set; }
            public string Name { get; set; }
        }

        static int fun (int totalSum , int i)
        {
            if(i % 2 == 0)
                totalSum += i;
            return totalSum;
        }
    }
}
