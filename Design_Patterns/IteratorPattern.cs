using System.Collections.Generic;
class CollectionWithArray
{
    public string[] lists;
    public int MAX_SIZE = 10;
    public int NoOfItems = 0;
    public CollectionWithArray()
    {
        lists = new string[MAX_SIZE];
        Addlist("Sam");
        Addlist("Stephen");
        Addlist("Steve");
        Addlist("Peter");
        Addlist("Tony");
    }
    public void Addlist(string list)
    {
        if (NoOfItems < MAX_SIZE)
        {
            lists[NoOfItems++] = list;
        }
        else
        {
            System.Console.WriteLine("Array Full");
        }
    }
    public IIterator CreateIterator()
    {
        return new CollectionWithArrayIterator(lists);
    }
    public string[] getlists()
    {
        return this.lists;
    }
}
class CollectionWithList
{
    public List<string> list;
    public CollectionWithList()
    {
        list = new List<string>();
        Addlist("ramesh");
        Addlist("suresh");
        Addlist("kisne");
        Addlist("hari");
        Addlist("gopal");
        Addlist("balram");
    }

    public IIterator CreateIterator()
    {
        return new CollectionWithListIterator(list);
    }

    public void Addlist(string list)
    {
        this.list.Add(list);
    }
    public List<string> getList()
    {
        return list;
    }

}


interface IIterator
{
    bool HasNext();
    string Next();
}

class CollectionWithArrayIterator : IIterator
{
    public string[] array;
    public int Position = 0;
    public CollectionWithArrayIterator(string[] array)
    {
        this.array = array;
    }

    public bool HasNext()
    {
        if (Position >= array.Length || array[Position] == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public string Next()
    {
        return array[Position++];
    }
}
class CollectionWithListIterator : IIterator
{
    public List<string> list;
    public int Position = 0;

    public CollectionWithListIterator(List<string> list)
    {
        this.list = list;
    }
    public bool HasNext()
    {
        if (Position >= list.Count)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public string Next()
    {
        return list[Position++];
    }
}

public class MyClass
{
    public static void Main(string[] args)
    {
        CollectionWithArray arr = new CollectionWithArray();
        IIterator iterator = arr.CreateIterator();
        while (iterator.HasNext())
        {
            System.Console.WriteLine(iterator.Next());
        }

        System.Console.WriteLine("");

        CollectionWithList list = new CollectionWithList();
        IIterator iterator2 = list.CreateIterator();
        while (iterator2.HasNext())
        {
            System.Console.WriteLine(iterator2.Next());
        }

    }
}