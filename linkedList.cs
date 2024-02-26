
public class SinglyLinkedList{
    public class Node{
        public string data;
        public Node next;
        
    }

    Node head;
    
    public void AddToListLast(string data){
        if(head==null){
            Node toAdd = new Node;

            head = toAdd;
            head.data = data;
            head.next = null;
        }
        else{
            Node toAdd = new Node;
            toAdd.data = data

            Node current = head;
            while(current.next != null){
                current = current.next;
            }
            current.next = toAdd;
        }
         
        
    }

    
}