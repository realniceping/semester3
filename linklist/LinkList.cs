using System;

namespace linklist;
 class LinkList{

    public Item Previos;
    public Item First;

    public LinkList(int value){
        this.First = null;
        this.Previos = null;
        Initilize(value);
    }



    public void Initilize(int value){
    
        Item temp = new Item(value);
        this.First = temp;
        this.Previos = temp;

    }

    public void Add(int value){
        
        Item temp = new Item(value);
        this.Previos.next = temp;
        temp.previos = this.Previos; 
        temp.next = null;
        this.Previos = temp;
    }

    public void Print(){

        Item temp = this.First;

        while(temp.next != null){
            Console.WriteLine(temp.value);
            temp = temp.next;
        }

        Console.WriteLine(temp.value);

    }


}
