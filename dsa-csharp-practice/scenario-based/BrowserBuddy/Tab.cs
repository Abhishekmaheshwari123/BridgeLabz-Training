using System;
internal class Tab
{
    public string url;
    public Tab prev;
    public Tab next;

    public Tab(string url)
    {
        this.url = url;
        prev = null;
        next = null; 
    }

    public override string ToString()
    {
        return url;
    }
}