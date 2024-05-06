
public class LinkedList{

    private Node head;

    public void printAllElements(){
        Node current = head;
        while(current != null){
            Console.WriteLine(current.data);
            current = current.next;
        }
    }

    public void AddFirst(object data){
        Node toBeAdded = new Node();

        toBeAdded.data = data;
        toBeAdded.next = head;

        head = toBeAdded;
    }



    
}