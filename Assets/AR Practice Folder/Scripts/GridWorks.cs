using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridWorks : MonoBehaviour {

    //AR starting plane size where the grid will be placed upon
    [SerializeField]
    float planeWidth = 1;
    [SerializeField]
    float planeLength = 1;
    [SerializeField]
    float planeHeight = 1;

    //Amount of cubes in the grid, length x width
    [SerializeField]
    int lengthGrid = 1;
    [SerializeField]
    int widthGrid = 1;
    [SerializeField]
    GameObject gridPrefab;
    [SerializeField]
    GameObject parentObject;

    public List<List<GameObject>> gridBlocks = new List<List<GameObject>>();

    //Initialization
    void Start () {
        gameObject.transform.localScale = new Vector3(planeWidth, planeHeight, planeLength);
        float zeroPointX = (-planeWidth * 0.5f);
        float zeroPointY = (planeHeight * 0.5f)+1.01f;
        float zeroPointZ = (-planeLength * 0.5f);
        float widthGridBlock = planeWidth/(widthGrid + 1);//small margin
        float lengthGridBlock = planeLength/(lengthGrid + 1);//small margin
        for (int x = 0; x < widthGrid; x++)
        {
            List<GameObject> xCoordinate = new List<GameObject>();
            for(int z = 0; z < lengthGrid; z++)
            {
                GameObject currentInstance = Instantiate(gridPrefab, parentObject.transform);
                xCoordinate.Add(currentInstance);
                currentInstance.gameObject.transform.localScale = new Vector3(widthGridBlock, planeHeight, lengthGridBlock);
                currentInstance.gameObject.transform.SetPositionAndRotation(new Vector3((zeroPointX + ((x+ 1) * widthGridBlock)),zeroPointY,(zeroPointZ + ((z + 1) * lengthGridBlock))),Quaternion.identity);
            }
            gridBlocks.Add(xCoordinate);
        }
    }
}
