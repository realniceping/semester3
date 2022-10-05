using System;

namespace linklist;
 class LinkList<T>{

    public Item<T> Previos;
    public Item<T> First;

    public LinkList(int value){
        this.First = null;
        this.Previos = null;
        Initilize(value);
    }



    public void Initilize(int value){
    
        Item<T> temp = new Item<T>(value);
        this.First = temp;
        this.Previos = temp;

    }

    public void Add(int value){
        
        Item<T> temp = new Item<T>(value);
        this.Previos.next = temp;
        temp.previos = this.Previos; 
        temp.next = null;
        this.Previos = temp;
    }

    public void Print(){

        Item<T> temp = this.First;

        while(temp.next != null){
            Console.WriteLine(temp.value);
            temp = temp.next;
        }

        Console.WriteLine(temp.value);

    }


}
