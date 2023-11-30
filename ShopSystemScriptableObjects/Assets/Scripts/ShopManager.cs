using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public List<ScriptableVegetables> veggiesScriptable;
    public int coins = 100;
    public GameObject[] ShopPanels;
    public GameObject veggiesShopPanel;
    public static ShopManager instance;
    public TextMeshProUGUI currencyText;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        currencyText.text = "Coins " + coins.ToString();
        foreach (GameObject panelPrefab in ShopPanels)
        {
            GameObject newPanel = Instantiate(panelPrefab, veggiesShopPanel.transform);
            newPanel.transform.localPosition = Vector3.zero;
        }
        
    }
   



    public void UpdateTheUi()
    {
        currencyText.text = "Coins " + coins.ToString();
    }
  


   
}



