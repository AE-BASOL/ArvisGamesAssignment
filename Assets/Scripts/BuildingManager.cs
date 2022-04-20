using UnityEngine;
using System.Linq;

public class BuildingManager : MonoBehaviour
{
    public static BuildingManager Instance;
    public Building[] Buildings;

    private void Awake()
    {
        Instance = this; //reference to the current script

        Buildings = Utils.GetAllInstances<Building>();
        Buildings = Buildings.OrderBy(p => p.Id).ToArray();
        foreach (Building building in Buildings)
        {
            Debug.Log(building.Name);
        }
    }
}
