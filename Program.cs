// using BoxesProblem.Models;

using DevTest.BoxesProblem.Models;

class Program
{
    static void Main()
    {
        //----------------------------------------------------

        //Test for boxes
/*
        IBox newBox = new RecyblableBox("A Box", 20, 30);
        IItem newItem = new RecyclableItem("An item", 2, 3);
        IItem newItem2 = new RecyclableItem("An item", 30, 3);
        newBox.addItem(newItem);
        newBox.addItem(newItem2);*/

        //----------------------------------------------------

        //Test for Fibonacci

        FibonacciCalculator.GenerateFibonacciSequence(50);

        //----------------------------------------------------

        //Test for counter

        /*Counter.count();
        Counter.countUsingASCII();*/
    }
}