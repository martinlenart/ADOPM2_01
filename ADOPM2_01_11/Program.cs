using System;

namespace ADOPM2_01_11
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	public class PlayingCard
	{
		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }

		string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}
		public override string ToString() => $"{Value} of {Color}, a {BlackOrRed} card";

		public PlayingCard() { }
		public PlayingCard(PlayingCardColor color, PlayingCardValue value)
		{
			Color = color;
			Value = value;
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
		}
	}
}
