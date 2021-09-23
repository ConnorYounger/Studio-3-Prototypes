using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory")]
public class InvItem : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public int value;
    public enum itemType { Material, Head, Chest, Legs, Arms};
    public itemType type;
    private bool stackable;

    private void Start()
    {
        if(type == itemType.Material)
        {
            stackable = true;
        }
    }
}
