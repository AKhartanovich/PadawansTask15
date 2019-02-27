using System;
using System.Collections.Generic;
using System.Linq;

namespace PadawansTask15
{
    public class EnumerableTask
    {
        /// <summary> Transforms all strings to upper case.</summary>
        /// <param name="data">Source string sequence.</param>
        /// <returns>
        ///   Returns sequence of source strings in uppercase.
        /// </returns>
        /// <example>
        ///    {"a", "b", "c"} => { "A", "B", "C" }
        ///    { "A", "B", "C" } => { "A", "B", "C" }
        ///    { "a", "A", "", null } => { "A", "A", "", null }
        /// </example>
        public IEnumerable<string> GetUppercaseStrings(IEnumerable<string> data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }
            var mass = data.ToArray();
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] != null)
                {
                    mass[i] = mass[i].ToUpper();
                }
                else
                {
                    mass[i] = null;
                }
            }
            return mass;

            // TODO : Implement GetUppercaseStrings
            //throw new NotImplementedException();
        }

        /// <summary> Transforms an each string from sequence to its length.</summary>
        /// <param name="data">Source strings sequence.</param>
        /// <returns>
        ///   Returns sequence of strings length.
        /// </returns>
        /// <example>
        ///   { } => { }
        ///   {"a", "aa", "aaa" } => { 1, 2, 3 }
        ///   {"aa", "bb", "cc", "", "  ", null } => { 2, 2, 2, 0, 2, 0 }
        /// </example>
        public IEnumerable<int> GetStringsLength(IEnumerable<string> data)
        {
            var mass = data.ToArray();
            int[] result = new int[mass.Length];
            for(int i = 0; i < mass.Length;i++)
            {
                if ( mass[i] != null)
                {
                    result[i] = mass[i].Length;
                }
                else
                {
                    result[i] = 0;
                }

            }
            return result;
            // TODO : Implement GetStringsLength
            throw new NotImplementedException();
        }

        /// <summary>Transforms integer sequence to its square sequence, f(x) = x * x. </summary>
        /// <param name="data">Source int sequence.</param>
        /// <returns>
        ///   Returns sequence of squared items.
        /// </returns>
        /// <example>
        ///   { } => { }
        ///   { 1, 2, 3, 4, 5 } => { 1, 4, 9, 16, 25 }
        ///   { -1, -2, -3, -4, -5 } => { 1, 4, 9, 16, 25 }
        /// </example>
        public IEnumerable<long> GetSquareSequence(IEnumerable<int> data)
        {
            var mass = data.ToArray();
            var abs = new long[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = Math.Abs(mass[i]) * Math.Abs(mass[i]);
            }
            for (int i = 0; i < mass.Length; i++)
            {
                abs[i] = mass[i];
            }
            return abs;
            // TODO : Implement GetSquareSequence
            //throw new NotImplementedException();
        }

        /// <summary> Filters a string sequence by a prefix value (case insensitive).</summary>
        /// <param name="data">Source string sequence.</param>
        /// <param name="prefix">Prefix value to filter.</param>
        /// <returns>
        ///  Returns items from data that started with required prefix (case insensitive).
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when prefix is null.</exception>
        /// <example>
        ///  { "aaa", "bbbb", "ccc", null }, prefix = "b"  =>  { "bbbb" }
        ///  { "aaa", "bbbb", "ccc", null }, prefix = "B"  =>  { "bbbb" }
        ///  { "a","b","c" }, prefix = "D"  => { }
        ///  { "a","b","c" }, prefix = ""   => { "a","b","c" }
        ///  { "a","b","c", null }, prefix = ""   => { "a","b","c" }
        ///  { "a","b","c" }, prefix = null => ArgumentNullException
        /// </example>
        public IEnumerable<string> GetPrefixItems(IEnumerable<string> data, string prefix)
        {
            var str = data.ToArray();
            prefix = prefix.ToLower();
            data = data.Where(a => !String.IsNullOrEmpty(a)).ToArray();
            if (prefix == "")
            {
                yield return data.ToString();
            }
            if(prefix == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].StartsWith(prefix))
                {
                    yield return str[i];
                }
            }

            // TODO : Implement GetPrefixItems
            //throw new NotImplementedException();
        }

        /// <summary> Finds the 3 largest numbers from a sequence.</summary>
        /// <param name="data">Source sequence.</param>
        /// <returns>
        ///   Returns the 3 largest numbers from a sequence.
        /// </returns>
        /// <example>
        ///   { } => { }
        ///   { 1, 2 } => { 2, 1 }
        ///   { 1, 2, 3 } => { 3, 2, 1 }
        ///   { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } => { 10, 9, 8 }
        ///   { 10, 10, 10, 10 } => { 10, 10, 10 }
        /// </example>
        public IEnumerable<int> Get3LargestItems(IEnumerable<int> data)
        {
            var mass = data.ToArray();
            int[] mass1;
            if (mass.Length < 3)
            {
                mass1 = new int[mass.Length];
                Array.Sort(mass);
                Array.Reverse(mass);
                for (int i = 0; i< mass.Length;i++)
                {
                    mass1[i] = mass[i];
                }
            }
            else
            {
                mass1 = new int[3];
                Array.Sort(mass);
                Array.Reverse(mass);
                for (int i = 0; i < 3; i++)
                { mass1[i] = mass[i]; }

            }
            return mass1;
            // TODO : Implement Get3LargestItems
            throw new NotImplementedException();
        }

        /// <summary> Calculates sum of all integers from object array.</summary>
        /// <param name="data">Source array.</param>
        /// <returns>
        ///    Returns the sum of all integers from object array.
        /// </returns>
        /// <example>
        ///    { 1, true, "a", "b", false, 1 } => 2
        ///    { true, false } => 0
        ///    { 10, "ten", 10 } => 20 
        ///    { } => 0
        /// </example>
        public int GetSumOfAllIntegers(object[] data)
        {
            int sum = 0;
             return sum = data.OfType<int>().Sum();
            // TODO : Implement GetSumOfAllIntegers
            throw new NotImplementedException();
        }
    }
}