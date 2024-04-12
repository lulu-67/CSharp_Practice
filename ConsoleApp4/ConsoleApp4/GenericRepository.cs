namespace ConsoleApp4;

public class GenericRepository<T>: IRepository<T> where T:class, IEntity
{
    private readonly List<T> _list;

    public GenericRepository()
    {
        _list = new List<T>();
    }
    public void Add(T item)
    {
        _list.Add(item);
    }

    public void Remove(T item)
    {
        _list.Remove(item);
    }

    public void Save()
    {
        
    }

    public IEnumerable<T> GetAll()
    {
        return _list;
    }

    public T GetById(int id)
    {
        for (int i = 0; i < _list.Count; i++)
        {
            if (_list[i].id == id)
            {
                return _list[i];
            }
        }

        return null;
    }
}