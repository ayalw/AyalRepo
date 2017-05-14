using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AyalTest15 //
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ! ! !");
            Console.ReadKey();

            #region Old         

            #region BST
            //int[] arr = { 4, 2, 9, 3, 1, 7, 5 };
            //Console.WriteLine("Building BST for array: {0}", string.Join("", arr));
            //Console.ReadKey();

            //var tree = BuildBst(arr);
            //Console.WriteLine("Final tree: {0}", tree);
            //Console.ReadKey();

            #region distance
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int searchedChild = arr[i];
            //    Console.WriteLine(string.Format("Finding Distance from {0} to child {1}.", tree.Val, searchedChild));
            //    Console.ReadKey();
            //    int result = tree.DistanceToChild(searchedChild);
            //    Console.WriteLine(string.Format("Got distance: {0}", result));
            //    Console.ReadKey();
            //}
            #endregion distance

            #region find node     
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int searchedChild = arr[i];
            //    Console.WriteLine(string.Format("Finding Node {0}.", searchedChild));
            //    Console.ReadKey();
            //    var node = tree.FindChildNode(searchedChild);
            //    Console.WriteLine("Found sub tree: {0}", node);                
            //    Console.ReadKey();
            //}
            #endregion find node

            #region findLCA
            //int val1 = 1;
            //int val2 = 5;
            //Console.WriteLine(string.Format("Finding LCA for val1={0}, val2={1}", val1, val2));
            //Console.ReadKey();
            //TreeNode<int> lcaNode = tree.FindCommonAncestor(val1, val2);
            //Console.WriteLine(string.Format("Found LCA node value: {0}", lcaNode.Val));
            //Console.Read();
            #endregion findLCA

            #region findDist from n1,n2
            //int n1 = 3;
            //int n2 = 9;
            //Console.WriteLine(string.Format("Finding distance between n1={0}, n2={1}", n1, n2));
            //Console.ReadKey();
            //int dist = tree.FindDist(n1, n2);

            //Console.WriteLine(string.Format("got distance: {0}", dist));
            //Console.ReadKey();
            #endregion findDist from n1,n2

            #endregion BST

            #region ReverseNumber

            //int n = 35286;
            //Console.WriteLine("starting ReverseNumber, n="+n);
            //Console.ReadKey();
            //int result = ReverseNumber(n);
            //Console.WriteLine("result="+result);
            //Console.ReadKey();

            #endregion ReverseNumber

            #region IsPalindrome

            //int n = 0;
            //Console.WriteLine("Starting IsPalindrome, n="+n);
            //Console.ReadKey();
            //bool result = IsPalindrome(n);
            //Console.WriteLine(result);
            //Console.ReadKey();

            #endregion IsPalindrome

            #region FindSumOfDigits

            //int n = 4517;
            //Console.WriteLine(string.Format("Starting FindSumOfDigits, n={0}", n));
            //Console.ReadKey();
            //int result = FindSumOfDigits(n);
            //Console.WriteLine(string.Format("result={0}", result));
            //Console.ReadKey();

            #endregion FindSumOfDigits

            #region GCD

            //int a = 18;
            //int b = 72;
            //Console.WriteLine(string.Format("Starting FindGCD, a={0}, b={1}", a, b));
            //Console.ReadKey();
            //int result = FindGcd(a, b);
            //Console.WriteLine(string.Format("result={0}", result));
            //Console.ReadKey();

            #endregion GCD

            #region IsPairExists

            //int[] arr = { 1, 2, 3, 4, 10 };
            //int sum = 8;
            //Console.WriteLine("starting IsPairExists");
            //Console.ReadKey();
            //bool result = IsPairExists(arr, sum);
            //Console.WriteLine("result: " + result);
            //Console.ReadKey();

            #endregion

            #region Perms

            //string str = "abc";
            //Console.WriteLine("Starting all perms, str={0}", str);
            //Console.ReadKey();
            //var result = AllPerms(str);
            //foreach (string perm in result)
            //{
            //    Console.WriteLine(perm);
            //}
            //Console.ReadKey();

            #endregion Perms

            #region FibIterative

            //Console.WriteLine("Hello ! ! !");
            //Console.ReadKey();

            //int n = 6;
            //Console.WriteLine(string.Format("Starting FibIterative, n={0}", n));
            //Console.ReadKey();
            //int fibResult = FibIterative(n);
            //Console.WriteLine(string.Format("Got result: {0}", fibResult));
            //Console.ReadKey();

            #endregion FibIterative

            #region CountSubstringOccurances

            //string str = "cc";
            //string substr = "ccc";
            //Console.WriteLine(string.Format("Starting CountSubstringOccurances str={0} substr={1}", str, substr));
            //Console.ReadKey();
            //int result = CountSubstringOccurances(str, substr);
            //Console.WriteLine("Got result:" + result);
            //Console.ReadKey();

            #endregion CountSubstringOccurances

            #region Kata DubStep

            //Console.WriteLine("Starting Dubstep...");
            //Console.ReadKey();
            //string s = SongDecoder("WUBWUBABCWUB");
            //Console.WriteLine("Got result: " + s);
            //Console.ReadKey();

            #endregion Kata Dubstep

            #region Kata FindEvenIndex

            //Console.WriteLine("FindEvenIndex");
            //Console.ReadKey();
            //int res = FindEvenIndex(new[] { 1, 2, 3, 4, 3, 2, 1 });

            #endregion FindEvenIndex

            #region Kata Street Fighter 2

            //Console.WriteLine("Starting Street Fighter 2.");
            //Console.ReadKey();
            //var fighters = new string[][]
            //{
            //    new string[] {"Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega"},
            //    new string[] {"Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison"},
            //};
            //var moves = new string[] { "up", "left", "right", "left", "left" };
            //var expected = new string[] { "Ryu", "Vega", "Ryu", "Vega", "Balrog" };
            //var result = StreetFighterSelection(fighters, new int[] { 0, 0 }, moves);

            #endregion Kata Street Fighter 2

            #region Accum
            //Console.WriteLine("***Accum Start***");
            //string s = "ZpglnRxqenU";
            //Console.WriteLine($"result for '{s}' is '{Accum(s)}'.");
            //Console.WriteLine("***Accum End***");
            //Console.ReadKey();

            #endregion Accum

            #region MinMax
            //Console.WriteLine("***MinMax Start***");
            //int[] input = {1, 2, 5, -1, 12, 20};
            //int[] res = MinMax(input);
            //Console.WriteLine($"res for {input} is min={res[0]}, max={res[1]}");

            //Console.WriteLine("***MinMax End***");
            //Console.ReadKey();
            #endregion MinMax

            #region descending

            //Console.WriteLine("***Descending Start***");
            //int input1 = 113123;
            //Console.WriteLine($"result for {input1} is {DescendingOrder(input1)}");

            //Console.WriteLine("***Descending End***");
            //Console.ReadKey();

            #endregion

            #region Bittorrent
            //Console.WriteLine("Starting IsFileDone");
            ////[0,1] [2,4] [3,6] [6,7]
            //int[][] chunkArray = {new[] {0, 1}, new[] {3,6}, new [] {2,4}, new[] {6,7}};
            //bool isDone = IsFileDone(chunkArray, 8);
            //Console.WriteLine($"result for [0,1] [2,4] [3,6] [6,7], 8 ==> {isDone}");
            //Console.ReadKey();

            #endregion

            #region Kata InArray
            //Console.WriteLine("Starting InArray");
            //string[] a1 = new string[] { "arp", "live", "strong" };
            //string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            //var result = InArray(a1, a2);
            //Console.ReadKey();
            #endregion Kata InArray

            #region Kata FirstNonRepeating
            //Console.WriteLine("Starting FirstNonRepeating");
            //string input2 = "balballiuhciuDSDVZzzsfhio";
            //string output2 = FirstNonRepeatingLetter(input2);
            //Console.ReadKey();
            #endregion Kata FirstNonRepeating

            #region Kata Unfairness
            //Console.WriteLine("starting Unfairness");
            //Console.ReadKey();
            //var resUnfairness = MinUnfairness(new[] {30, 100, 1000, 150, 60, 250, 10, 120, 20}, 3);
            //Console.WriteLine($"resUnfairness={resUnfairness}");
            //Console.ReadKey();

            #endregion Kata Unfairness

            #endregion old
        }

        public static bool IsRotation(string s1, string s2)
        {
            // waterbottle, erbottlewat --> true
            // waterbottle, ttlewaterbo --> true
            //watwat1, 2watwat --> false
            // waterbottle, botawat --> false
            if (s1.Length != s2.Length) return false;
            int i = 0;
            while (s1[0] != s2[i])
            {
                i++;
            }
            return false;
        }

        #region ZeroizeRowColumn
        public static void ZeroizeRowColumn(int[][] matrix, int m, int n)
        {
            bool[] rowsToZeroize = new bool[m];
            bool[] colsToZeroize = new bool[n];
            //m rows, n columns
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowsToZeroize[i] = true;
                        colsToZeroize[j] = true;
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (rowsToZeroize[i] || colsToZeroize[j]) matrix[i][j] = 0;
                }
            }
        }
        #endregion ZeroizeRowColumn

        #region ReplaceSpaces
        public static string ReplaceSpaces(string str)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
        #endregion ReplaceSpaces

        #region TotalScore
        public static int totalScore(string[] blocks, int n)
        {
            int score = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < blocks.Length; i++)
            {
                int current = 0;

                bool isNumber = int.TryParse(blocks[i], out current);
                if (isNumber)
                {
                    score += current;
                    stack.Push(current);
                    //Console.WriteLine(string.Format("i={0}, blocks[i]={3}, current={1}, score={2}", i, current, score, blocks[i]));
                }
                else
                {
                    if (blocks[i] == "X")
                    {
                        int last;
                        if (stack.Count == 0)
                        {
                            last = 0;
                        }
                        else
                        {
                            last = stack.Pop();
                            stack.Push(last);
                        }
                        current = last * 2;
                        score += current;
                        stack.Push(current);
                        //Console.WriteLine(string.Format("i={0}, blocks[i]={3}, current={1}, score={2}", i, current, score, blocks[i]));
                    }
                    if (blocks[i] == "+")
                    {
                        int last = stack.Count == 0 ? 0 : stack.Pop();
                        int beforeLast = stack.Count == 0 ? 0 : stack.Pop();
                        stack.Push(beforeLast);
                        stack.Push(last);
                        current = beforeLast + last;
                        score += current;
                        stack.Push(current);
                        //Console.WriteLine(string.Format("i={0}, blocks[i]={3}, current={1}, score={2}", i, current, score, blocks[i]));
                    }
                    if (blocks[i] == "Z")
                    {
                        int last = stack.Count == 0 ? 0 : stack.Pop();
                        score -= last;
                        //Console.WriteLine(string.Format("i={0}, blocks[i]={3}, current={1}, score={2}", i, "Z", score, blocks[i]));
                    }
                }
            }
            return score;
        }
        #endregion TotalScore

        #region ReverseNumber
        private static int ReverseNumber(int n)
        {
            int reversed = 0;
            Stack<int> stack = new Stack<int>();
            
            while (n > 0)
            {
                stack.Push(n%10);
                n = n/10;
            }
            int count = 0;
            while (stack.Count > 0)
            {
                reversed += (stack.Pop()*(int)Math.Pow(10, count));
                count++;
            }
            return reversed;
        }
        #endregion ReverseNumber

        #region IsPalindrome
        private static bool IsPalindrome(int n)
        {
            List<int> digits = new List<int>();
            while (n != 0)
            {
                digits.Add(n%10);
                n = n/10;
            }
            int[] arr = digits.ToArray();
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                if (arr[start] != arr[end]) return false;
                start++;
                end--;
            }
            return true;
        }
        #endregion IsPalindrome

        #region FindSumOfDigits
        private static int FindSumOfDigits(int n)
        {
            //451-->4+5+1-->10
            int sum1 = 0;
            while (n != 0)
            {
                sum1 += n % 10;
                n = n / 10;
            }
            return sum1;
        }
        #endregion FindSumOfDigits

        #region FindGCD
        private static int FindGcd(int a, int b)
        {
            int min, max;
            if (a >= b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }
            for (int n = min; n >= 1; n--)
            {
                if (max % n == 0 && min % n == 0) return n;
            }
            return 1;
        }
        #endregion FindGCD

        #region IsPairExists


        private static bool IsPairExists(int[] arr, int sum)
        {
            //9
            //{2,3,2,4,4,5,6,16};
            Array.Sort(arr);
            int low = 0;
            int hi = arr.Length - 1;
            while (low < hi)
            {
                int currentSum = arr[low] + arr[hi];
                if (currentSum == sum) return true;
                if (currentSum < sum) low++;
                if (currentSum > sum) hi--;
            }
            return false;
        }
        #endregion IsPairExists

        #region AllPerms
        private static List<string> AllPerms(string str)
        {
            var result = new List<string>();
            if (str.Length == 0)
            {
                result.Add("");
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    char ch = str[i];
                    string rest = str.Substring(0, i) + str.Substring(i+1);
                    List<string> subResults = AllPerms(rest);
                    foreach (string subResult in subResults)
                    {
                        //result.Add(subResult);
                        result.Add(ch + subResult);
                    }
                }
            }
            return result;
        }
        #endregion AllPerms

        #region AllSubstrings
        private static List<string> AllSubstrings(string str)
        {
            var result = new List<string>();
            if (str.Length <= 1)
            {
                result.Add(str);
            }
            else
            {
                var rest1 = AllSubstrings(str.Substring(1, str.Length - 1));
                var rest2 = AllSubstrings(str.Substring(0, str.Length));
                result.AddRange(rest1);
                result.AddRange(rest2);
            }
            return result;
        }
        #endregion AllSubstrings

        #region FibIterative    
        private static int FibIterative(int n)
        {
            // 1,2,3,4,5,6,7...
            // 1,1,2,3,5,8,13...
            if (n == 1) return 1;
            if (n == 2) return 2;
            int n1 = 1;
            int n2 = 1;
            int fib = -1;
            for (int i = 1; i < n; i++)
            {
                fib = n1 + n2;
                n1 = n2;
                n2 = fib;
            }
            return n2;
        }
        #endregion FibIterative

        #region CountSubstringOccurances

        private static int CountSubstringOccurances(string str, string substr)
        {
            int count = 0;
            int i = 0;
            while (i < str.Length)
            {
                int j = 0;
                while (i < str.Length && j < substr.Length && substr[j] == str[i])
                {
                    i++;
                    j++;
                }
                if (j >= substr.Length) count++;
                i++;
            }
            return count;
        }
        #endregion CountSubstringOccurances

        #region Kata DubStep
        public static string SongDecoder(string input)
        {
            Console.WriteLine("input="+input);
            Console.ReadKey();
            //string[] splitted = input.Split(new[] {"WUB"}, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", input.Split(new[] { "WUB" }, StringSplitOptions.RemoveEmptyEntries));
        }
        #endregion Kata Dubstep

        #region Kata LogisticsMap
        public static int[,] LogisticMap(int width, int height, int[] xs, int[] ys)
        {
            var result = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    result[i, j] = int.MaxValue;
                }
            }
            int n = xs.Length; // =ys.Length this is number of logistics points.
            for (int m = 0; m < n; m++)
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int dist = FindDistance(y, x, ys[m], xs[m]);
                        result[y, x] = Math.Min(result[y, x], dist);
                    }
                }
            }
            return result;
        }

        private static int FindDistance(int fromY, int fromX, int toY, int toX)
        {
            return Math.Abs(toY - fromY) + Math.Abs(toX - fromX);
        }
        #endregion Kata LogisticsMap

        #region Kata FirstNonRepeating
        public static string FirstNonRepeatingLetter(string s)
        {
            if (s == null || s == "") return "";
            List<char> nonRepeatingLetters = new List<char>();
            bool[] allChars = new bool[26];
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                bool isLowerCase = 'a' <= ch && ch <= 'z';
                bool isUpperCase = 'A' <= ch && ch <= 'Z';
                bool isLetter = isLowerCase || isUpperCase;

                char chLower = isLetter ? char.ToLower(ch) : ch;
                int index = chLower - (int)('a');
                if (allChars[index] == false)
                {
                    nonRepeatingLetters.Add(ch);
                    allChars[index] = true;
                }
                else
                {
                    nonRepeatingLetters.Remove(ch); // check syntax
                    nonRepeatingLetters.Remove(chLower); // check syntax
                }
            }
            if (nonRepeatingLetters.Count == 0) return "";
            return nonRepeatingLetters.First().ToString();
        }
        #endregion Kata FirstNonRepeating

        #region Kata InArray
        public static string[] InArray(string[] array1, string[] array2)
        {
            List<string> result = new List<string>();
            foreach (string s1 in array1)
            {
                foreach (string s2 in array2)
                {
                    if (s2.Contains(s1)) result.Add(s1);
                }
            }
            result.Sort();
            return result.ToArray();
        }
        #endregion Kata InArray

        #region Bittorrent


        public static bool IsFileDone(int[][] chunks, int size)
        {
            List<Chunk> chunkList = ConvertToChunkList(chunks);
            chunkList.Sort((chunk1, chunk2) => chunk1.Start > chunk2.Start ? 1 : chunk1.Start == chunk2.Start ? 0 : -1);
            //Now chunks are sorted by start.
            if (chunkList.First().Start != 0) //edges
            {
                return false;
            }
            int rightmostEnd = 0;
            int count = 1;
            Chunk prevChunk = chunkList.First();

            while (count < chunkList.Count && rightmostEnd < size - 1) //[0,1] [2,4] [3,6] [6,7]
            {
                var currentChunk = chunkList[count];
                if (currentChunk.Start - prevChunk.End > 1)
                {
                    return false;
                }
                rightmostEnd = Math.Max(prevChunk.End, currentChunk.End);
                prevChunk = currentChunk;
                count++;
            }

            return rightmostEnd == size - 1;

        }

        //[0,1] [2,4] [3,6] [6,7]
        private static List<Chunk> ConvertToChunkList(int[][] chunks)
        {
            var list = new List<Chunk>();
            foreach (int[] ch in chunks)
            {
                list.Add(new Chunk {Start = ch[0], End = ch[1]});
            }
            return list;
        }

        #endregion

        #region Kata Descending
        public static int DescendingOrder(int num)
        {
            string numStr = "" + num;
            List<int> numList = numStr.ToList().Select(ch => (int)char.GetNumericValue(ch)).ToList();
            numList.Sort();
            numList.Reverse();
            return Convert.ToInt32(string.Join("", numList));
        }
        #endregion Kata Descending

        #region Kata MinMax
        public static int[] MinMax(int[] lst)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (int i in lst)
            {
                if (i < min) min = i;
                if (i > max) max = i;
            }
            return new int[] { min, max };
        }
        #endregion

        #region Kata Accum
        //Accumul.Accum("abcd");    // "A-Bb-Ccc-Dddd"
        //Accumul.Accum("RqaEzty"); // "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
        //Accumul.Accum("cwAt");    // "C-Ww-Aaa-Tttt"
        public static String Accum(string s)
        {
            if (s.Length == 0) return "";
            string result = ""+char.ToUpper(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                string word = ""+char.ToUpper(s[i]);
                for (int j = 0; j < i; j++)
                {
                    word += char.ToLower(s[i]);
                }
                result = $"{result}-{word}";
            }
            return result;
        }
        #endregion

        #region Kata Counting Sheep
        private static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(t => t);
        }
        #endregion

        # region Kata IQTest 
        private static void FindIndexWithDifferentEvenness()
        {
            Console.WriteLine("Hello World");
            string s = "1 3 6 1";
            Console.WriteLine($"result for '{s}' is '{Test(s)}'.");
            s = "1 2 1 1";
            Console.WriteLine($"result for '{s}' is '{Test(s)}'.");
            s = "2 1 1 1";
            Console.WriteLine($"result for '{s}' is '{Test(s)}'.");
            s = "1 1 1 2";
            Console.WriteLine($"result for '{s}' is '{Test(s)}'.");

            Console.ReadKey();

        }

        private static int Test(string numbers)
        {
            string[] s = numbers.Split(' ');
            List<int> list = s.Select(int.Parse).ToList();
            if (list.Count < 3)
            {
                return 1; // no meaning for result when list is less than 3 items
            }
            int prev = list[0];
            int generalOddity = GetGeneralOddity(list); // 0 means even, 1 means odd
            for (int i = 1; i < list.Count; i++)
            {
                if ((prev + list[i]) % 2 == 1) // oddity has changed, we are near!
                {
                    if (list[i] % 2 == generalOddity)
                    {
                        return i;
                    }
                    return i + 1;
                }
                prev = list[i];
            }
            return -1; //would only happen for invalid input
        }

        private static int GetGeneralOddity(List<int> list)
        {
            if (list.Count < 3) throw new ArgumentException("list must be at least 3 items.");
            if (list[0] % 2 == list[1] % 2) return list[0] % 2;
            return list[2] % 2;
        }
        #endregion

        #region Kata Unfairness

        //Kata.MinUnfairness([1,2,3,1,5,19,8],2)=?

        public static int MinUnfairness(int[] arr, int k)
        {
            if (arr.Length == 0 || k == 0)
                return 0;

            Array.Sort(arr);
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length - k + 1; i++)
            {
                if (arr[i + k - 1] - arr[i] < min)
                {
                    min = arr[i + k - 1] - arr[i];
                }
            }

            return min;
        }

        public static int FindEvenIndex(int[] arr)
        {
            int leftSum, rightSum, totalSum;
            totalSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalSum += arr[i];
            }
            leftSum = arr[0];
            rightSum = totalSum-arr[0]-arr[1];
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (leftSum == rightSum) return i;
                leftSum += arr[i];
                rightSum -= arr[i+1];
            }
            return -1;
        }

        public static int MinUnfairness1(int[] arr, int k)
        {
            return FindUnfairness(arr, FindBestSubset(arr, k, 0));
        }

        private static List<int> FindBestSubset(int[] arr, int k, int start)
        {
            List<int> subset = new List<int>();
            if (k == 1)
            {
                subset.Add(start);
                return subset;
            }

            if (arr.Length - start < k)
            {
                
            }

            // option 1: array[start] is included in the result
            List<int> subset1 = FindBestSubset(arr, k - 1, start + 1);
            subset1.Add(start);

            //option 2: array[start] is not included in the result
            List<int> subset2 = FindBestSubset(arr, k, start + 1);

            if (FindUnfairness(arr, subset1) <= FindUnfairness(arr, subset2))
            {
                return subset1;
            }
            return subset2;
        }

        private static int FindUnfairness(int[] arr, List<int> subset)
        {
            if (subset.Count == 0) return int.MaxValue;
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (int index in subset)
            {
                if (arr[index] > max) max = arr[index];
                if (arr[index] < min) min = arr[index];
            }
            return max - min;
        }
        #endregion Kata Unfairness

        #region Kata Duplicate Encoder
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            Dictionary<char, List<int>> dic = new Dictionary<char, List<int>>();
            for (int i = 0; i < word.Length; i++)
            {
                if (dic[word[i]]==null) dic[word[i]] = new List<int>();
                dic[word[i]].Add(i);
            }
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (dic[word[i]].Count > 1) result += "(";
                else result += ")";
            }
            return result;
        }
        #endregion

        #region StreetFighter
        public static string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        {
            //position={0,0} is upper left
            //position={1,0} is lower left
            string[] result = new string[moves.Length];
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == "up")
                {
                    if (position[0] == 1) position[0] = 0;
                }
                if (moves[i] == "down")
                {
                    if (position[0] == 0) position[0] = 1;
                }
                if (moves[i] == "right")
                {
                    position[1] = position[1] == 5 ? 0 : position[1]++;
                }
                if (moves[i] == "left")
                {
                    position[1] = position[1] == 0 ? 5 : position[1]--;
                }
                result[i] = fighters[position[0]][position[1]];
            }
            return result;
        }
        #endregion StreetFighter

        #region FibIterative
        private static ulong FibIterative(ulong n)
        {
            double sqrt5 = Math.Sqrt(5);
            double p1 = (1 + sqrt5) / 2;
            double p2 = -1 * (p1 - 1);

            double n1 = Math.Pow(p1, n + 1);
            double n2 = Math.Pow(p2, n + 1);
            return (ulong)((n1 - n2) / sqrt5);
        }
        #endregion FibIterative

        #region BST
        public static TreeNode<int> BuildBst(int[] arr)
        {
            if (arr.Length == 0) return null;
            TreeNode<int> root = new TreeNode<int>(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                root.AddVal(arr[i]);
            }
            return root;
        }
        #endregion BST
    }

    #region TreeNode Class
    public class TreeNode<T> where T : IComparable
    {
        public T Val { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode (T val)
        {
            Val = val;
        }
        
        public override string ToString() //PRE ORDER
        {
            return string.Format("[{0},L={1},R={2}]", Val, Left, Right);
        }

        public TreeNode<T> FindChildNode(T childValue)
        {
            if (childValue.CompareTo(Val) == 0) return this;
            if (childValue.CompareTo(Val) < 0)
            {
                if (Left != null) return Left.FindChildNode(childValue);
                return null;
            }
            if (Right != null) return Right.FindChildNode(childValue);
            return null;
        }

        public int FindDist(T val1, T val2)
        {
            TreeNode<T> lcaNode = FindCommonAncestor(val1, val2);
            return lcaNode.DistanceToChild(val1) + lcaNode.DistanceToChild(val2);
        }

        public TreeNode<T> FindCommonAncestor(T val1, T val2)
        {            
            TreeNode<T> n1 = FindChildNode(val1);
            TreeNode<T> n2 = FindChildNode(val2);
            if (n1 == null || n2 == null) return null;

            if (val1.CompareTo(val2) == 0) return n1; // if n1 and n2 are same node, it's alscom LCA.

            if (val1.CompareTo(Val) == 0 || val2.CompareTo(Val) == 0) return this; // if n1 or n2 is root, root is LCA.

            if ((val1.CompareTo(Val) < 0 && val2.CompareTo(Val) > 0)
                || (val1.CompareTo(Val) > 0 && val2.CompareTo(Val) < 0)) // if n1 and n2 are on different sides of root, root is LCA.
            {
                return this;
            }

            // if we got here then either both n1,n2 are to my left or both n1,n2 are to my right.
            if (val1.CompareTo(Val) < 0)
            {
                if (Left == null) return null;
                return Left.FindCommonAncestor(val1, val2);
            }
            if (Right == null) return null;
            return Right.FindCommonAncestor(val1, val2);
        }

        public int DistanceToChild(T childValue)
        {
            if (childValue.CompareTo(Val) == 0) return 0;
            if (Left != null)
            {
                int leftResult = Left.DistanceToChild(childValue);
                if (leftResult != -1) return leftResult + 1;
            }
            if (Right != null)
            {
                int rightResult = Right.DistanceToChild(childValue);
                if (rightResult != -1) return rightResult + 1;
            }
            return -1;
        }

        public void AddVal(T insertedVal)
        {
            Console.WriteLine(string.Format("Adding valure {0} to tree: {1}", insertedVal, this));
            if ((insertedVal.CompareTo(Val) == 0))
            {
                //Do nothing.
            }

            if ((insertedVal.CompareTo(Val) < 0))
            {
                if (Left == null)
                {
                    Left = new TreeNode<T>(insertedVal);
                }
                else
                {
                    Left.AddVal(insertedVal);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new TreeNode<T>(insertedVal);
                }
                else
                {
                    Right.AddVal(insertedVal);
                }
            }
            
        }
    }
    #endregion TreeNode class

    #region Chunk Class
    class Chunk
    {
        public int Start { get; set; }
        public int End { get; set; }

    }
    #endregion Chink Class
}
