using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPieceClick : MonoBehaviour {

    [SerializeField]
    GameObject platform;
    GameObject newPlatform;

    List<int> thisPosition = new List<int>();
    // Use this for initialization
	void Start () {/*Trying to make reusable lines for updating the grid in the double array*/
        GameObject brickSpawner = GameObject.Find("brickSpawner");
        //brickSpawner.GetComponent<GridWorks>().buildablePlatforms.IndexOf(this.gameObject);
        //thisPosition.Add();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnMouseDown ()
    {

        newPlatform = Instantiate(platform, new Vector3(this.transform.position.x, this.transform.position.y,this.transform.position.z),Quaternion.identity);
        Destroy(this.gameObject);
    }
}
