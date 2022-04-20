using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCreator : MonoBehaviour
{
    [SerializeField] private GameObject buildingPreFab;
    [SerializeField] private Transform buildingContainer;
    [SerializeField] private Sprite buildingImage;

    private void Start()
    {
        StartCoroutine(CreateBuilding());
    }

    IEnumerator CreateBuilding() //just make sure that everything else in the game has had enough time to be created
    {
        yield return new WaitForEndOfFrame(); //Don't happen until frame pass

        foreach (Building building in BuildingManager.Instance.Buildings) //iterate all of the buildings {A,B,C,D,E,F}
        {
            GameObject instance = Instantiate(buildingPreFab, buildingContainer);
            instance.name = building.name;
            BuildManager buildManager = instance.GetComponent<BuildManager>(); //will get the script assigned to top most game object
            buildManager.Building = building;

            buildManager.Renderer.sprite = building.Icon;
        }
    }


}
