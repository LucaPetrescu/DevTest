using System.Collections;

public interface IBox
{
    public ArrayList itemList { get; }
    public string Name
    {
        get; set;
    }

    public int MaxCapacity
    { get; set; }

    public int MaxWeight
    { get; set; }

    public void addItem(IItem item);
}