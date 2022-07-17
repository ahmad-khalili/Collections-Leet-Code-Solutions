using LeetCode.Collections;

MinStack stack = new();
stack.Push(-2);
stack.Push(0);
stack.Push(-3);
Console.WriteLine(stack.GetMin());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Top());
Console.WriteLine(stack.GetMin());