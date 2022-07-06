namespace LeetCode.Collections;

public class Program
{
    public static int[] DeckRevealedIncreasing(int[] deck)
    {
        Queue<int> indexQueue = new Queue<int>();

        for (int i = 0; i < deck.Length; i++)
        {
            indexQueue.Enqueue(i);
        }

        int[] result = new int[deck.Length];
        Array.Sort(deck);

        foreach (var card in deck)
        {
            result[indexQueue.Dequeue()] = card;
            if (indexQueue.Count > 0)
            {
                indexQueue.Enqueue(indexQueue.Dequeue());
            }
        }

        return result;
    }

    static void Main()
    {
        var deck = new int[] {17, 13, 11, 2, 3, 5, 7 };
        var revealingDeck = DeckRevealedIncreasing(deck);

        Console.Write("[");
        foreach (var card in revealingDeck)
        {
            if (Array.IndexOf(revealingDeck, card) == revealingDeck.Length - 1)
                Console.Write(card);
            else
                Console.Write($"{card}, ");
        }
        Console.Write("]");
    }
}