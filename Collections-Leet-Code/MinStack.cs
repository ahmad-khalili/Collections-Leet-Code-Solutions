namespace LeetCode.Collections;

public class MinStack
{
    private Stack<int> _stack;
    private Stack<int> _minStack;
    
    public MinStack()
    {
        _stack = new();
        _minStack = new();
    }

    public void Push(int item)
    {
        if (_minStack.Count == 0 || item < _minStack.Peek())
        {
            _minStack.Push(item);
        }
        _stack.Push(item);
    }

    public int Pop()
    {
        if (_minStack.Peek() == _stack.Peek())
        {
            _minStack.Pop();
        }

        return _stack.Pop();
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return _minStack.Peek();
    }
}