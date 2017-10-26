using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingClass : MonoBehaviour {

    public string buildingType;
    public int width;
    public int length;
    public int[] buildCosts;
    public int[] hasEffectOn;
    public string law;
    public int[] repairCosts;
	
    public BuildingClass(string newBuildingType, int newWidth, int newLength, int[] newBuildCosts, int[] newHasEffectOn, string newLaw, int[] newRepairCosts)
    {
        buildingType = newBuildingType;
        width = newWidth;
        length = newLength;
        buildCosts = newBuildCosts;
        hasEffectOn = newHasEffectOn;
        law = newLaw;
        repairCosts = newRepairCosts;
    }
    // "CREMATORY"           placedBuildings.Add(new BuildingClass("crematory", 1, 2, new int[]{ 5, 6 }, new int[] { 0, 0, -10, 0, 0, 5, -1, 6 }, "Burial", new int[] { 1, 2 }));
    // "PUMP"                placedBuildings.Add(new BuildingClass("pump", 2, 2, new int[]{ 8, 8 }, new int[] { 0, 0, -20, 0, 0, 10, 5, -5 }, "null", new int[] { 3, 3 }));
    // "WIND TURBINE"        placedBuildings.Add(new BuildingClass("wind turbine", 1, 1, new int[]{ 4, 3 }, new int[] { 0, 0, 4, 0, 0, 5, 1, -1 }, "Clean Energy", new int[] { 2, 2 }));
    // "GAS TURBINE"         placedBuildings.Add(new BuildingClass("gas turbine", 1, 2, new int[]{ 3, 2 }, new int[] { 0, 0, 5, -5, 0, 15, -3, 3 }, "Gas", new int[] { 1, 1 }));
    // "GAS DRILL"           placedBuildings.Add(new BuildingClass("gas drill", 1, 1, new int[]{ 1, 1 }, new int[] { 0, 0, 0, 10, 0, 10, -2, 2 }, "Gas", new int[] { 1, 0 }));
    // "HOUSE"               placedBuildings.Add(new BuildingClass("house", 1, 2, new int[]{ 2, 2 }, new int[] { 0, 0, -2, 0, 10, 0, 2, -2 }, "null", new int[] { 1, 1 }));
    // "GREEN HOUSE"         placedBuildings.Add(new BuildingClass("green house", 2, 2, new int[]{ 3, 3 }, new int[] { 5, 0, -2, 0, 0, 10, 1, 0 }, "null", new int[] { 1, 1 }));
    // "FACTORY"             placedBuildings.Add(new BuildingClass("factory", 3, 2, new int[]{ 4, 4 }, new int[] { 0, 10, -10, 0, 0, 30, 1, -3 }, "null", new int[] { 2, 3 }));
    // "SCHOOL"              placedBuildings.Add(new BuildingClass("school", 2, 2, new int[]{ 3, 3 }, new int[] { 0, 0, 0, 0, 0, 30, 3, -6 }, "null", new int[] { 1, 0 }));
    // "GOVERNMENT"          placedBuildings.Add(new BuildingClass("government", 2, 2, new int[]{ 0, 0 }, new int[] { 2, 2, 25, 0, 60, 5, 0, 0 }, "null", new int[] { 0, 0 }));
    // "CEMETARY"            placedBuildings.Add(new BuildingClass("cemetary", 3, 2, new int[]{ 5, 3 }, new int[] { 0, 0, 0, 0, 0, 10, 3, 2 }, "Burial", new int[] { 1, 0 }));
    // "PARK"                placedBuildings.Add(new BuildingClass("park", 1, 2, new int[]{ 3, 2 }, new int[] { 0, 0, 0, 0, 0, 5, 3, -3 }, "null", new int[] { 2, 0 }));
    // "DOCK"                placedBuildings.Add(new BuildingClass("dock", 1, 2, new int[]{ 5, 6 }, new int[] { 10, 10, -10, 0, 0, 10, 5, -5 }, "null", new int[] { 2, 2 }));

}
