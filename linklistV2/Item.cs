using System;

namespace linklist;

class Item<T>
{

    public Item<T>? previos;

    public Item<T>? next;

    public T value;

    public Item(T value)
    {

        this.previos = null;
        this.next = null;
        this.value = value;

    }

}