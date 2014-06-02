using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Codeforces
{
    internal static class Program
    {
        private const string Problem = "a";

        private static void Solve()
        {
        }

        private static void Main()
        {
            var isDebbuger = Debugger.IsAttached;
            if (isDebbuger)
            {
                var projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent;
                var testsPath = Path.Combine(projectPath != null? projectPath.FullName: "", "tests");
                var files = Directory.GetFiles(testsPath, string.Format("{0}*.in", Problem));

                foreach (var file in files)
                {
                    Console.SetIn(new StreamReader(file));
                    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                    Solve();

                    Console.WriteLine();

                    Console.In.Close();
                    Console.SetIn(new StreamReader(Console.OpenStandardInput()));
                }

                Console.WriteLine();
                Console.WriteLine("Press any key for exit...");
                Console.ReadKey();
            }   
            else
                Solve();
        }

        private static int[] SortIndexs<T>(this IEnumerable<T> source) where T : IComparable
        {
            var array = source == null ? new List<T>() : source.ToList();
            var n = array.Count;
            var res = Enumerable.Range(0, n).ToArray();
            Array.Sort(res, (a, b) =>
            {
                var compare = array[a].CompareTo(array[b]);
                return compare == 0 ? a.CompareTo(b) : compare;
            });
            return res;
        }

        #region Reader

        private static string Read()
        {
            return Console.ReadLine();
        }

        private static void Read<T>(out T a1, out T a2)
        {
            var input = ReadArray();
            a1 = (T)Convert.ChangeType(input[0], typeof(T));
            a2 = (T)Convert.ChangeType(input[1], typeof(T));
        }

        private static void Read<T>(out T a1, out T a2, out T a3)
        {
            var input = ReadArray();
            a1 = (T)Convert.ChangeType(input[0], typeof(T));
            a2 = (T)Convert.ChangeType(input[1], typeof(T));
            a3 = (T)Convert.ChangeType(input[2], typeof(T));
        }

        private static void Read<T>(out T a1, out T a2, out T a3, out T a4)
        {
            var input = ReadArray();
            a1 = (T)Convert.ChangeType(input[0], typeof(T));
            a2 = (T)Convert.ChangeType(input[1], typeof(T));
            a3 = (T)Convert.ChangeType(input[2], typeof(T));
            a4 = (T)Convert.ChangeType(input[3], typeof(T));
        }

        private static void Read<T>(out T a1, out T a2, out T a3, out T a4, out T a5)
        {
            var input = ReadArray();
            a1 = (T)Convert.ChangeType(input[0], typeof(T));
            a2 = (T)Convert.ChangeType(input[1], typeof(T));
            a3 = (T)Convert.ChangeType(input[2], typeof(T));
            a4 = (T)Convert.ChangeType(input[3], typeof(T));
            a5 = (T)Convert.ChangeType(input[4], typeof(T));
        }

        private static void Read<T>(out T a1, out T a2, out T a3, out T a4, out T a5, out T a6)
        {
            var input = ReadArray();
            a1 = (T)Convert.ChangeType(input[0], typeof(T));
            a2 = (T)Convert.ChangeType(input[1], typeof(T));
            a3 = (T)Convert.ChangeType(input[2], typeof(T));
            a4 = (T)Convert.ChangeType(input[3], typeof(T));
            a5 = (T)Convert.ChangeType(input[4], typeof(T));
            a6 = (T)Convert.ChangeType(input[5], typeof(T));
        }

        private static int ReadInt()
        {
            return Int32.Parse(Read());
        }

        private static long ReadLong()
        {
            return long.Parse(Read());
        }

        private static double ReadDouble()
        {
            return double.Parse(Read(), CultureInfo.InvariantCulture);
        }

        private static T Read<T>()
        {
            return (T)Convert.ChangeType(Read(), typeof(T));
        }

        private static string[] ReadArray()
        {
            var readLine = Console.ReadLine();
            if (readLine != null)
                return readLine.Split(' ');

            throw new ArgumentException();
        }

        private static List<int> ReadIntArray()
        {
            return ReadArray().Select(Int32.Parse).ToList();
        }

        private static List<long> ReadLongArray()
        {
            return ReadArray().Select(long.Parse).ToList();
        }

        private static List<double> ReadDoubleArray()
        {
            return ReadArray().Select(d => double.Parse(d, CultureInfo.InvariantCulture)).ToList();
        }

        private static List<T> ReadArray<T>()
        {
            return ReadArray().Select(x => (T)Convert.ChangeType(x, typeof(T))).ToList();
        }

        private static void WriteLine(double value)
        {
            Console.WriteLine(value.ToString(CultureInfo.InvariantCulture));
        }

        private static void WriteLine(double value, string stringFormat)
        {
            Console.WriteLine(value.ToString(stringFormat, CultureInfo.InvariantCulture));
        }

        private static void WriteLine<T>(T value)
        {
            Console.WriteLine(value);
        }

        private static void Write(double value)
        {
            Console.Write(value.ToString(CultureInfo.InvariantCulture));
        }

        private static void Write(double value, string stringFormat)
        {
            Console.Write(value.ToString(stringFormat, CultureInfo.InvariantCulture));
        }

        private static void Write<T>(T value)
        {
            Console.Write(value);
        }

        #endregion
    }
}