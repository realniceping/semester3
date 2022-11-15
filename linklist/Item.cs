using System;

namespace linklist;

class Item
{

    public Item? previos;

    public Item? next;

    public int value;

    public Item(int value){

        this.previos = null;
        this.next = null;
        this.value = value;
    
    }

}