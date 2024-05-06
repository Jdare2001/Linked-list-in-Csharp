// See https://aka.ms/new-console-template for more information

bool quit = false;
Console.WriteLine("Hello welcome to A linked list");
LinkedList theList = new LinkedList();
while (!quit)
{
    Console.WriteLine("Enter an element to add it to the list or type quit to quit");
    String? element;
    element = Console.ReadLine();
    if (element != null){
    if (element.ToUpper() == "QUIT")
    {

        quit = true;
    }
    else
    {
        theList.AddFirst(element);
        theList.printAllElements();
    }
    }
}
