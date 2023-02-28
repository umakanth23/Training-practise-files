using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class dict
{
    public int key;
    public string name;
    public int setKey
    {
        set
        {
            this.key = value;
        }
        get { return this.key; }
    }
    public string setName
    {
        set
        { name = value; }
        get { return this.name; }
    }
}
public class Class_dict
{
    public static void Main()
    {
        dict d1 = new dict();
        d1.setKey = 10;
        Console.WriteLine(d1.setKey);
        d1.setName = "John";
        Console.WriteLine(d1.setName);
        dict d2 = new dict();
        d1.setKey = 20;
        Console.WriteLine(d2.setKey);
        d1.setName = "Seth";
        Console.WriteLine(d2.setName);
        Dictionary<int, dict> dd = new Dictionary<int, dict>();
        dd.Add(201, d1);
        dd.Add(205, d2);
        
        foreach(var x in dd)
        {
            Console.WriteLine("Key:{0} && Value:{1}", x.Key, x.Value);
        }


    }
}

