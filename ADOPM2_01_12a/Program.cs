using System;

namespace ADOPM2_01_12a
{
    class Program
    {
		class FoldedSentence
		{
			string[] words = "a default sentence".Split();
			public string Sentence
			{
				init => words = value.Split();
			}
			public int Length
			{
				get
				{
					if (words.Length % 2 == 0) return words.Length / 2;
					return words.Length / 2 + 1;
				}
			}
		
			public (string, string) this[int idx] // indexer
			{
				get
				{
					if (idx >= Length) throw new IndexOutOfRangeException();

					return (words[idx], words[words.Length - 1 - idx]);
				}
			}
		}
		static void Main(string[] args)
        {
			var s1 = new FoldedSentence();
			Console.WriteLine(s1.Length);   // 2
			Console.WriteLine(s1[0]);       // (a, sentence)
			Console.WriteLine(s1[1]);       // (default, default)

			var s2 = new FoldedSentence { Sentence = "The quick brown fox catches the white rabbit" };
			Console.WriteLine(s2.Length);   // 4
			for (int i = 0; i < s2.Length; i++)
			{
				Console.WriteLine(s2[i]);   // (The, rabbit) (quick, white) (brown, the) (fox, catches)
			}
		}
	}
}
//Excercises:
//1.	Modify the code so in case of odd nr of words, the "folding word" is not repeated in the index.
//		So, in above example s1[1] should only be "default" not "default default"
