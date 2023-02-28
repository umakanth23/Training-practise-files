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
        d2.setKey = 20;
        Console.WriteLine(d2.setKey);
        d2.setName = "Seth";
        Console.WriteLine(d2.setName);
        Dictionary<int, dict> dd = new Dictionary<int, dict>();
        dd.Add(201, d1);
        dd.Add(205, d2);    

        foreach (var x in dd)
        {
            dict obj = x.Value;
            Console.WriteLine("Key:{0} && Value:{1}", x.Key, obj.name);
        }
        dict db = new dict();
        if(dd.TryGetValue(40,out db))
        {
            Console.WriteLine("Key 40 is preset , it's values are :{0}:{1}", db.key, db.name);
        }
        else
        {
            Console.WriteLine("Key 40 is not present");
        }
        dict dn = new dict();
        if (dd.TryGetValue(201, out dn))
        {
            Console.WriteLine("Key 201 is present ,it's values are :{0}:{1}", dn.key, dn.name);
        }
        else
        {
            Console.WriteLine("Key 201 is not present");
        }
    }
}

