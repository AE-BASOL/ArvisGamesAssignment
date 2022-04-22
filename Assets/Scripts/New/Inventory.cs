using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject gameManager;
    
    public Sprite image;
    public int GoldCost;
    public int GemCost;

    public void SendInfo()
    {
        gameManager.GetComponent<GameManager>().selectedSprite = image;
        gameManager.GetComponent<GameManager>().selectedGoldCost = GoldCost;
        gameManager.GetComponent<GameManager>().selectedGemCost = GemCost;
    }

    public void CanBuild()
    {
        var gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //if (gameManager.GemRes < gameManager.selectedGemCost && gameManager.GoldRes < gameManager.selectedGoldCost)
        

        
    }
}
