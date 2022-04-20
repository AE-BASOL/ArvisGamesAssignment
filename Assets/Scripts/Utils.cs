using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils //which means (static) we can acces anywhere
{
   public static T[] GetAllInstances<T>() where T : ScriptableObject
    {
        return Resources.LoadAll<T>("ScriptableObjects/Buildings");
    }
}
