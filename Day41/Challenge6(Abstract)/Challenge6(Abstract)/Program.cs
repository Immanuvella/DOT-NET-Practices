using System;
abstract class Book

{

    protected string title;

    public abstract void SetTitle(string s);

    public string GetTitle()

    {

        return title;

    }

}

class MyBook : Book

{

    public override void SetTitle(string s)

    {

        title = s;

    }

}

class MainClass

{

    public static void Main(string[] args)

    {
        string str=Console.ReadLine();  
        MyBook myBook = new MyBook();

        myBook.SetTitle(str);

        Console.WriteLine("The title is: " + myBook.GetTitle());

    }

}


