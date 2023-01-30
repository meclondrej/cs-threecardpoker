public class Combinations {
    public static int getHighCard(Card c1, Card c2, Card c3) {
        int high = (int) c1.rank;
        if ((int) c2.rank > high) {
            high = (int) c2.rank;
        }
        if ((int) c3.rank > high) {
            high = (int) c3.rank;
        }
        return high;
    }
    public static bool getPair(Card c1, Card c2, Card c3) {
        if ((int) c1.rank == (int) c2.rank) {
            return true;
        }
        if ((int) c2.rank == (int) c3.rank) {
            return true;
        }
        if ((int) c1.rank == (int) c3.rank) {
            return true;
        }
        return false;
    }
    public static bool getFlush(Card c1, Card c2, Card c3) {
        if ((int) c1.suit == (int) c2.suit && (int) c2.suit == (int) c3.suit) {
            return true;
        }
        return false;
    }
    public static bool getStraight(Card c1, Card c2, Card c3) {
        int c1r = (int) c1.rank;
        int c2r = (int) c2.rank;
        int c3r = (int) c3.rank;
        if (
            (c1r + 1 == c2r && c1r + 2 == c3r) ||
            (c1r + 1 == c3r && c1r + 2 == c2r) ||
            (c2r + 1 == c3r && c1r + 2 == c1r) ||
            (c2r + 1 == c1r && c1r + 2 == c3r) ||
            (c3r + 1 == c2r && c1r + 2 == c1r) ||
            (c3r + 1 == c1r && c1r + 2 == c2r)
        ) {
            return true;
        }
        return false;
    }
    public static bool getThreeOfAKind(Card c1, Card c2, Card c3) {
        if (
            (int) c1.rank == (int) c2.rank &&
            (int) c1.rank == (int) c3.rank
        ) {
            return true;
        }
        return false;
    }
    public static bool getStraightFlush(Card c1, Card c2, Card c3) {
        if (Combinations.getFlush(c1, c2, c3) && Combinations.getStraight(c1, c2, c3)) {
            return true;
        }
        return false;
    }
    public static int resolveHand(Card c1, Card c2, Card c3) {
        if (Combinations.getStraightFlush(c1, c2, c3)) {
            return 6;
        }
        else if (Combinations.getThreeOfAKind(c1, c2, c3)) {
            return 5;
        }
        else if (Combinations.getStraight(c1, c2, c3)) {
            return 4;
        }
        else if (Combinations.getFlush(c1, c2, c3)) {
            return 3;
        }
        else if (Combinations.getPair(c1, c2, c3)) {
            return 2;
        } else {
            return 1;
        }
    }
}