namespace LeetCode.Collections;

public class Program
{
    public static ListNode ReverseList(ListNode? head) {
        if (head ==  null){
            return head;
        }

        ListNode prev = null;
        ListNode curr = head;
        while(curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
    static void Main()
    {
        ListNode node = new ListNode(1);
        ListNode nextNode = new ListNode(2);
        ListNode thirdNode = new ListNode(3);
        node.next = nextNode;
        nextNode.next = thirdNode;

        ListNode dummy = node;

        Console.Write("Original: ");
        
        while (dummy != null)
        {
            Console.Write($"{dummy.val} ");
            dummy = dummy.next;
        }

        ListNode reversedList = ReverseList(node);
        

        Console.WriteLine();

        Console.Write("Reversed: ");
        
        while (reversedList != null)
        {
            Console.Write($"{reversedList.val} ");
            reversedList = reversedList.next;
        }
}
}