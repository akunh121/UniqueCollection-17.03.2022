using System.Collections;
string start = "";
dynamic word;
UniqueCollection<int> arrayList = new UniqueCollection<int>();
Console.WriteLine(arrayList.GetItemsTypeName());
string type = arrayList.GetItemsTypeName();


while (start != "q")
{
    Console.WriteLine(@"choosh an option from the folliwing list:
                            a - Add
                            d - Remove
                            e - Enumerate
                            b - Contains
                            c - Clear
                            q - Quit
Your Option?");
    start = Console.ReadLine().ToLower();
    switch (start)
    {
        case "a":
            {


                Console.WriteLine("Enter a element you went to add ");
                if (type == "Int32")
                {
                    word = int.Parse(Console.ReadLine());
                }
                else
                {
                    word = Console.ReadLine();
                }
                arrayList.Add(word);
                break;


            }
            break;


        case "b":
            {
                Console.Write("Enter What Element You Looking For: ");
                if (type == "Int32")
                {
                    word = int.Parse(Console.ReadLine());
                }
                else
                {
                    word = Console.ReadLine();
                }
                Console.WriteLine(arrayList.Contains(word) ? ("the element is found") : ("the element is not found"));
                break;
            }
            break;
        case "d":
            {
                Console.Write("Enter What Element You Want To Remove: ");
                if (type == "Int32")
                {
                    word = int.Parse(Console.ReadLine());
                }
                else
                {
                    word = Console.ReadLine();
                }
                arrayList.Remove(word);
                Console.WriteLine("the element " + word + " was remove");
                break;
            }
            break;
        case "e":
            {
                Console.Write("List: ");

                foreach (var item in arrayList)
                {

                    Console.Write(item + ",");
                }
                Console.WriteLine();
                break;
            }
            break;
        case "c":
            {
                arrayList.Clear();
                Console.WriteLine("The array was cleared");
                break;
            }
        case "q":
            {
                Console.WriteLine("goodbye!");
                break;
            }
            break;
        default:
            {
                Console.WriteLine("Try Again");
            }
            break;
    }
}


class UniqueCollection<T> : ICollection<T>
{
    ArrayList list = new ArrayList();

    public int Count { get; }
    public bool IsReadOnly { get; }

    public void Add(T item)
    {
        if (!(list.Contains(item)))
        {
            list.Add(item);
        }
        else
        {
            Console.WriteLine("the element already in the list");
        }
    }

    public void Clear()
    {
        list.Clear();
    }

    public bool Contains(T item)
    {
        return list.Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in list)
        {
            yield return (T)item;
        }
    }

    public bool Remove(T item)
    {
        if (list.Contains(item))
        {
            list.Remove(item);
            return true;
        }
        return false;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
    public string GetItemsTypeName()
    {
        //return Value.GetType().Name;

        return typeof(T).Name;


    }
}


