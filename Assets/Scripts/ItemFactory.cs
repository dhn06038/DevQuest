using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemFactory<T> : MonoBehaviour
{
    public Item Spawn(T _type, Transform _parent)
    {
        Item item = this.Create(_type);
        item.transform.SetParent(_parent, false);
        item.transform.localPosition = new Vector3(Random.Range(-50f, 50f),1.5f, Random.Range(-50f, 50f));
        return item;
    }
    protected abstract Item Create(T _type);
}