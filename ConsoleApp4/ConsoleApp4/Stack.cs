namespace ConsoleApp4;

public class MyStack<T>
{
    private List<T> items;

    public MyStack()
    {
        items = new List<T>();
    }

    public int Count()
    {
        return items.Count;
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("empty stack");
        }

        T item = items[items.Count - 1];
        items.RemoveAt(items.Count-1);
        return item;
    }

    public void Push(T itemToPush)
    {
        items.Add(itemToPush);
    }
}