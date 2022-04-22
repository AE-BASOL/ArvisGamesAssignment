using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject gameManager;
    
    public Sprite image;
    public int GoldCost;
    public int GemCost;
    public float timeGen;
    public int GoldGen;
    public int GemGen;

    public void SendInfo()
    {
        gameManager.GetComponent<GameManager>().selectedSprite = image;
        gameManager.GetComponent<GameManager>().selectedGoldCost = GoldCost;
        gameManager.GetComponent<GameManager>().selectedGemCost = GemCost;
        gameManager.GetComponent<GameManager>().selectedTimeGen = timeGen;
        gameManager.GetComponent<GameManager>().selectedGoldGen = GoldGen;
        gameManager.GetComponent<GameManager>().selectedGemGen = GemGen;
    }

}
