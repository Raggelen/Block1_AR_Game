using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPieceClick : MonoBehaviour {
    
    GameObject brickSpawner;

    public GameObject platform;
    GameObject newPlatform;
    public GameObject crematory;
    public List<BuildingClass> placedBuildings = new List<BuildingClass>();
   

    public List<int> thisPosition = new List<int>();
    // Use this for initialization
	void Start () {
        brickSpawner = GameObject.Find("brickSpawner");
    }

    void OnMouseDown()
    {
        if (brickSpawner.GetComponent<GridWorks>().buildablePlatforms[this.thisPosition[1]][this.thisPosition[0]] == 0) {
            newPlatform = Instantiate(platform, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            newPlatform.transform.parent = this.transform.parent;
            newPlatform.AddComponent<GridPieceClick>();
            newPlatform.GetComponent<GridPieceClick>().thisPosition = this.thisPosition;
            newPlatform.GetComponent<GridPieceClick>().crematory = this.crematory;
            newPlatform.GetComponent<GridPieceClick>().platform = this.platform;
            newPlatform.AddComponent<BoxCollider>();
            newPlatform.GetComponent<BoxCollider>().enabled = true;
            brickSpawner.GetComponent<GridWorks>().buildablePlatforms[this.thisPosition[1]][this.thisPosition[0]] = 1;
            Debug.Log("You lifted the ground!!!");
            Destroy(this.gameObject);
        }
        else if (brickSpawner.GetComponent<GridWorks>().buildablePlatforms[this.thisPosition[1]][this.thisPosition[0]] == 1) {
            //spawn building
            GameObject newBuilding;
            newBuilding = Instantiate(crematory, new Vector3(this.transform.position.x, this.transform.position.y + 0.1f, this.transform.position.z), Quaternion.identity);
            newBuilding.transform.parent = this.transform.parent;
            brickSpawner.GetComponent<GridWorks>().buildablePlatforms[this.thisPosition[1]][this.thisPosition[0]] = 3;
            //placedBuildings.Add(new BuildingClass("crematory", 1, 2, new int[]{ 5, 6 }, new int[] { 0, 0, -10, 0, 0, 5, -1, 6 }, "Burial", new int[] { 1, 2 }));
            Debug.Log("You placed a crematory! You must expect quite a lot of dead people!");
        }
        else
        {
            Debug.Log("Sorry, can't let you do that.");
        }
    }
}
