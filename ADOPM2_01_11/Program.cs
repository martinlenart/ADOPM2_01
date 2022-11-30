using System;
using System.Collections.Generic;
using System.Drawing;

namespace ADOPM2_01_11
{
	public enum PlayingCardColor
	{
		Clubs, Diamonds, Hearts, Spades, Last         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace, Last                // Poker Value order
	}
	public class PlayingCard
	{
		public PlayingCardColor Color { get; set; }
		public PlayingCardValue Value { get; set; }

		public string Message { get; set; }	

		string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}
		public override string ToString() => $"{Value} of {Color}, {Message}";

		private PlayingCard() { }
		private PlayingCard(PlayingCardColor color, PlayingCardValue value, string message=null)
		{
			Color = color;
			Value = value;
			Message = message;
		}
		
        
		public static class Factory
        {
			public static PlayingCard HighestCard ()
            {
				return new PlayingCard(PlayingCardColor.Spades, PlayingCardValue.Ace);
            }
			public static PlayingCard LowestCard ()
			{
				return new PlayingCard(PlayingCardColor.Clubs, PlayingCardValue.Two);
			}
			public static PlayingCard HighestCard(PlayingCardColor color)
			{
				return new PlayingCard(color, PlayingCardValue.Ace);
			}
			public static PlayingCard LowestCard(PlayingCardColor color)
			{
				return new PlayingCard(color, PlayingCardValue.Two);
			}

			public static PlayingCard RandomCard()
			{
				var rnd = new Random();
				var _color = rnd.Next((int)PlayingCardColor.Clubs, (int)PlayingCardColor.Last);
                var _value = rnd.Next((int)PlayingCardValue.Two, (int)PlayingCardValue.Last);

				var messages = "God Morgon, God Kväll, Hello, Good Bye".Split(", ");
				var Message = messages[rnd.Next(messages.Length)];

                return new PlayingCard((PlayingCardColor) _color, (PlayingCardValue) _value, Message);
			}
		}
    }
    class Program
    {
        static void Main(string[] args)
        {
			PlayingCard card1 = PlayingCard.Factory.HighestCard();
			Console.WriteLine(card1);

            Console.WriteLine(PlayingCard.Factory.LowestCard());
			Console.WriteLine(PlayingCard.Factory.HighestCard(PlayingCardColor.Diamonds));
			Console.WriteLine(PlayingCard.Factory.LowestCard(PlayingCardColor.Diamonds));

			Console.WriteLine();
			Console.WriteLine(PlayingCard.Factory.RandomCard());
            Console.WriteLine(PlayingCard.Factory.RandomCard());
            Console.WriteLine(PlayingCard.Factory.RandomCard());

			var cards = new List<PlayingCard>();
			for (int i = 0; i < 10_000; i++)
			{
				cards.Add(PlayingCard.Factory.RandomCard());	
			}
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine(cards[i]);
			}
        }
    }
}
