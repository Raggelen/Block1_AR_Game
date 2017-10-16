using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour {

    List<List<GameObject>> grid;

	// Use this for initialization
	void Start () {
        grid = GetComponent < GridWorks >().gridBlocks;
        foreach(List<GameObject> xSection in grid)
        {
            foreach(GameObject zSection in xSection)
            {

            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
