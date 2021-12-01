using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item
{
    [Header("card Info")]
    public int id;
    public string name;
    public int cost;
    public float damage;
    public Sprite CardImage;
    public float Persent;
    public int CardLevel;
}

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Object/ItemSO")]
public class ItemSO : ScriptableObject
{
    public Item[] items;
}

 