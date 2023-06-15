using DevTest.BoxesProblem.Models;
using System.Collections;

public class StandardBox : IBox
{
    public string Name { get; set; }

    public ArrayList itemList { get; } = new ArrayList();
    public int MaxCapacity
    { get; set; }
    public int MaxWeight { get; set; }

    public int CurrentCapacity;

    public int CurrentWeight;
    
    public StandardBox(string Name, int MaxCapacity, int MaxWeight)
    {
        this.Name = Name;
        this.MaxCapacity = MaxCapacity;
        this.MaxWeight = MaxWeight;
        itemList = new ArrayList();
    }

    public void addItem(IItem item)
    {
        if (CurrentCapacity + item.Size > MaxCapacity || CurrentWeight + item.Weight > MaxWeight)
        {
            throw new BoxFullException("Box reached maximum capacity");
        }
        
        if(item.GetType() == typeof(RecyclableItem))
        {
            throw new WrongMaterialException("Material is recyclable");
        }


    }
}