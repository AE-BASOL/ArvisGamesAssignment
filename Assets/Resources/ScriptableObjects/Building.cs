using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewBuilding", menuName = "ScriptableObject/Building")] //For designer team (check if work right?)

public class Building : ScriptableObject
{
    public string Name;
    public string Id;
    public Sprite Icon;
    public int GoldCost;
    public int GemCost;
    public int TimeGen;  //X
    public int GoldGen; //Y
    public int GemGen; //Z

    public bool FitGrid = false; //We assume every place false, unless place is correct shape of emptyness

    //will add grid shape char[][] ?

}
