using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridWorks : MonoBehaviour {
    
    int lengthGrid = 18;
    int widthGrid = 18;
    [SerializeField]
    GameObject gridPrefab;
    GameObject parentObject;
    [SerializeField]
    GameObject buildable;
    GameObject currentInstance;
    [SerializeField]
    GameObject crematory;
    GameObject martiniTower;

    public List<List<int>> buildablePlatforms = new List<List<int>>();

    private void Update()
    {
        martiniTower.transform.Rotate(0,30 * Time.deltaTime, 0 , Space.Self);
    }

    void Start () {

        martiniTower = GameObject.Find("Plane.001");
        parentObject = GameObject.Find("ImageTarget");
        float zeroPointX = (-widthGrid * 0.5f + 0.5f);
        float zeroPointZ = (-lengthGrid * 0.5f + 0.5f);

        for (int x = 0; x < widthGrid; x++)
        {

            List<int> xCoordinate = new List<int>();

            for (int z = 0; z < lengthGrid; z++)
            {

                if (z > 5 && z < 12 && x > 5 && x < 12)
                {
                    currentInstance = Instantiate(buildable, parentObject.transform);
                    currentInstance.tag = "Floor";
                    currentInstance.AddComponent<GridPieceClick>();
                    currentInstance.GetComponent<GridPieceClick>().thisPosition.Add(x);
                    currentInstance.GetComponent<GridPieceClick>().thisPosition.Add(z);
                    currentInstance.GetComponent<GridPieceClick>().crematory = this.crematory;
                    currentInstance.GetComponent<GridPieceClick>().platform = this.buildable;
                    currentInstance.AddComponent<BoxCollider>();
                    currentInstance.GetComponent<BoxCollider>().enabled = true;
                    if ((z == 9 || z == 10 ) && (x == 9 || x == 10))
                    {
                        xCoordinate.Add(2);
                        currentInstance.GetComponent<GridPieceClick>().buildablePlace = 2;
                    }
                    else {
                        xCoordinate.Add(1);
                        currentInstance.GetComponent<GridPieceClick>().buildablePlace = 1;
                    }
                    currentInstance.gameObject.transform.SetPositionAndRotation(new Vector3((zeroPointX + x)/10, 0, (zeroPointZ + z)/10), Quaternion.identity);
                    currentInstance.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

                }
                else
                {
                    currentInstance = Instantiate(gridPrefab, parentObject.transform);
                    currentInstance.GetComponent<GridPieceClick>().thisPosition.Add(x);
                    currentInstance.GetComponent<GridPieceClick>().thisPosition.Add(z);
                    xCoordinate.Add(0);
                    currentInstance.gameObject.transform.SetPositionAndRotation(new Vector3((zeroPointX + x)/10, 0, (zeroPointZ + z)/10), Quaternion.identity);
                    currentInstance.transform.localScale = new Vector3(0.1f,0.1f,0.1f);
                }


            }

            buildablePlatforms.Add(xCoordinate);
        }
    }
       
    
}
