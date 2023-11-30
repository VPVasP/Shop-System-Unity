using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    public ScriptableVegetables scriptableVegs;
    public TextMeshProUGUI itemName;
    public Image image;
    public TextMeshProUGUI price;
    [SerializeField] Button button;
    private void Start()
    {
        button = GetComponentInChildren<Button>();
        itemName.text = scriptableVegs.name;
        image.sprite = scriptableVegs.spriteImage;
        price.text = scriptableVegs.price.ToString();
        button.onClick.AddListener(BuyItem);

    }
    public void BuyItem()
    {

        if (ShopManager.instance.coins >= scriptableVegs.price)
        {
            ShopManager.instance.coins -= scriptableVegs.price;
            ShopManager.instance.UpdateTheUi();
            ShopManager.instance.veggiesScriptable.Add(scriptableVegs);
            Debug.Log("Bought item" + scriptableVegs.name);
          
        }
    }

}

