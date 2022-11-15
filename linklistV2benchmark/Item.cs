using System;

namespace linklist;

class Item<T>
{

    public Item<T> previos;

    public Item<T> next;

    public int value;

    public Item(int value){

        this.previos = null;
        this.next = null;
        this.value = value;
    
    }

}