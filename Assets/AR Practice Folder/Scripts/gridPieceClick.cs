using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPieceClick : MonoBehaviour {
    
    GameObject brickSpawner;

    [SerializeField]
    GameObject platform;
    GameObject newPlatform;

    public List<int> thisPosition = new List<int>();
    // Use this for initialization
	void Start () {
        brickSpawner = GameObject.Find("brickSpawner");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnMouseDown ()
    {
        if (brickSpawner.GetComponent<GridWorks>().buildablePlatforms[thisPosition[0]][thisPosition[1]] == 0)//still needs a menu to pop up
        {
            newPlatform = Instantiate(platform, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            brickSpawner.GetComponent<GridWorks>().buildablePlatforms[thisPosition[0]][thisPosition[1]] = 1;
            Debug.Log("You lifted the ground!!!");
            Destroy(this.gameObject);
        }
    }
}
