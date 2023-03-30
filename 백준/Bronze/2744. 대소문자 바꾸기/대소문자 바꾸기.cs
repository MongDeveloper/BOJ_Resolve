string str = Console.ReadLine();
Queue<string> queue = new Queue<string>();

foreach(var c in str.ToCharArray())
{
    if(c >= 'A' && c <= 'Z')
    {
        queue.Enqueue(c.ToString().ToLower());
    }
    else
    {
        queue.Enqueue(c.ToString().ToUpper());
    }
}

foreach(var q in queue)
{
    Console.Write(q);
}