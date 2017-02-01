using UnityEngine;
using System;

public enum ItemCategory
{
    weapon
}

[Serializable]
public class Item
{
    #region

    public string name;

    [HideInInspector]
    public ItemCategory category;

    [HideInInspector]
    public int max;

    [HideInInspector]
    public bool disposable;

    [HideInInspector]
    public int damage;
    
    #endregion

    public int amount;
    public bool equiped;

    public Item(string name,  int max, bool disposable, int damage)
    {
        this.category = ItemCategory.weapon;
        this.name = name;
        this.max = max;
        this.disposable = disposable;
        this.damage = damage;
    }

    public void ToConfigure()
    {
        Item item = Database.instance.items.Find(x => x.name == name);

        category = item.category;
        max = item.max;
        disposable = item.disposable;
        damage = item.damage;
    }
}
