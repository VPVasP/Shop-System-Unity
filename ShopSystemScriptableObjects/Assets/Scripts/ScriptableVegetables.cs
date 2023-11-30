using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScriptableVegetables", menuName = "Vegetable")]
public class ScriptableVegetables : ScriptableObject
{
    public string itemName;
    public int price;
    public Sprite spriteImage;
    public int id;
    public int quantity;
}
