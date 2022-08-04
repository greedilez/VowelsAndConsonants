using System;

namespace VowelsAndConsonants
{
    class Program
    {
        private static string vowels = "AOEIU";

        private static string consonants = "BCDFGJKLMNPQSTVXZHRWY";

        private static string targetWord = string.Empty;

        private static int vCount, cCount;

        static void Main(string[] args)
        {
            while (true)
            {
                ResetAll();
                Console.WriteLine("Enter word: ");
                targetWord = Console.ReadLine();
                string upperCaseTarget = targetWord.ToUpper();
                for (int i = 0; i < upperCaseTarget.Length; i++)
                {
                    for (int v = 0; v < vowels.Length; v++) if (upperCaseTarget[i] == vowels[v]) vCount++;

                    for (int c = 0; c < consonants.Length; c++) if (upperCaseTarget[i] == consonants[c]) cCount++;
                }
                Console.WriteLine($"Vowels count: {vCount}, Consonants count: {cCount}");
            }
        }

        private static void ResetAll()
        {
            targetWord = string.Empty;
            vCount = 0;
            cCount = 0;
        }
    }
}
