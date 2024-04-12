namespace ConsoleApp4;

public class MyList<T>
{
    private List<T> newList;

    public MyList()
    {
        newList = new List<T>();
    }

    public void Add(T element)
    {
        newList.Add(element);
    }

    public T Remove(int index)
    {
        T obj = newList[index];
        newList.RemoveAt(index);
        return obj;
    }

    public bool Contains(T element)
    {
        return newList.Contains(element);
    }

    public void Clear()
    {
        newList.Clear();
    }

    public void InsertAt(T element, int index)
    {
        newList.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        newList.RemoveAt(index);
    }

    public T Find(int index)
    {
        T obj = newList[index];
        return obj;
    }
}