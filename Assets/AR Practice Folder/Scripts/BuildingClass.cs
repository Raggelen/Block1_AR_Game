using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingClass : MonoBehaviour {

    public string buildingType;
    public int width;
    public int length;
    public int[] buildCosts;
    public int[] repairCosts;
    public int damage;

    public BuildingClass(string newBuildingType, int newWidth, int newLength, int[] newBuildCosts, int[] newRepairCosts, int newDamage)
    {
        buildingType = newBuildingType;
        width = newWidth;
        length = newLength;
        buildCosts = newBuildCosts;
        repairCosts = newRepairCosts;
        damage = newDamage;
    }
   
}
