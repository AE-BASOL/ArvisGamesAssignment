using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUp : MonoBehaviour
{
    float currentTimer = 0f;
    bool StartTimer=false;

    public void BuildUpProcess()
    {
        var gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        Sprite selectedSprite = gameManager.selectedSprite;

        if (gameManager.GemRes >= gameManager.selectedGemCost && gameManager.GoldRes >= gameManager.selectedGoldCost)
        {
            if (selectedSprite != null)
            {
                //success
                if (PlayerPrefs.GetInt(this.gameObject.name) == 0)
                {
                    Image selectedObject = Instantiate(gameManager.building, this.gameObject.transform);
                    this.gameObject.GetComponent<Image>().sprite = selectedSprite;   // selectedObject.GetComponent<Image>().sprite = selectedSprite;
                    PlayerPrefs.SetInt(this.gameObject.name, 1);

                    gameManager.GemRes -= gameManager.selectedGemCost;
                    gameManager.GoldRes -= gameManager.selectedGoldCost;
                    StartTimer = true;
                }
                else
                {
                    Debug.Log("YOU HAVE ALREADY BUILTY");
                }
            }
            else
            {
                Debug.Log("INEFFICENT GEM AND GOLD");
            }

            
        }
        else
            Debug.LogError("YOU HAVE TO SELECT AN INVENTORY FIRST");
    }

  /*  void Update()
    {
        var gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    

        if (StartTimer)
        {
            currentTimer += Time.deltaTime;
            if (currentTimer > gameManager.selectedTimeGen)
            {
                currentTimer = 0f;
                gameManager.GemRes += gameManager.selectedGemGen;
                gameManager.GoldRes += gameManager.selectedGoldGen;
            }
        }
    }*/
}
