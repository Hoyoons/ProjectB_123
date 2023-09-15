using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainer<T>    
{
    private T[] items;
    private int currentIndex = 0;

    public GenericContainer(int capacity)   //class���� class�̸��� ���� �Լ��� ���� ������
    {
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if (currentIndex < items.Length)
        {
            items[currentIndex] = item;
            currentIndex++;
        }
    }
    public T[] GetItems()
    {
        return items;
    }
}