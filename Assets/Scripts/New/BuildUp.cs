using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUp : MonoBehaviour
{
    public void BuildUpProcess()
    {
        Sprite selectedSprite = GameObject.Find("GameManager").GetComponent<GameManager>().selectedSprite;
        Image selectedObject = Instantiate(GameObject.Find("GameManager").GetComponent<GameManager>().building, this.gameObject.transform);

        if (selectedSprite != null)
            this.gameObject.GetComponent<Image>().sprite = selectedSprite;   // selectedObject.GetComponent<Image>().sprite = selectedSprite;
        else
            Debug.LogError("YOU HAVE TO SELECT AN INVENTORY FIRST");
    }
}
