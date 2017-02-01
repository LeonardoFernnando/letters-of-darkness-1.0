using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{ 
    public static Database instance;

    [HideInInspector]
    public List<Item> items = new List<Item>()
    {
        new Item("Handgun A", 6, false, 20)
    };

    void Awake()
    {
        instance = this;
    }
}
