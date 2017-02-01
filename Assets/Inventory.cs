using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    protected List<Item> items;
    
	void Start ()
    {
        items.ForEach(x => x.ToConfigure());
    }
}
