public class Card {
    enum Rank {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    enum Suit {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }
    Rank rank;
    Suit suit;
    public Card() {
        this.rank = (Rank) new Random().Next(0, 12);
        this.suit = (Suit) new Random().Next(0, 3);
    }
}