using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridWorks : MonoBehaviour {
    
    int lengthGrid = 18;
    int widthGrid = 18;
    [SerializeField]
    GameObject gridPrefab;
    [SerializeField]
    GameObject parentObject;
    [SerializeField]
    GameObject buildable;
    GameObject currentInstance;
    
    public List<List<int>> buildablePlatforms = new List<List<int>>();

    //Initialization
    void Start () {

        float zeroPointX = (-widthGrid * 0.5f);
        float zeroPointZ = (-lengthGrid * 0.5f);

        if (buildablePlatforms.Count == 0)//Checks if the map has been loaded before
        {
            for (int x = 0; x < widthGrid; x++)
            {

                List<int> xCoordinate = new List<int>();

                for (int z = 0; z < lengthGrid; z++)
                {

                    if (z > 6 && z < 13 && x > 6 && x < 13)
                    {
                        currentInstance = Instantiate(buildable, parentObject.transform);
                        xCoordinate.Add(1);
                    }
                    else
                    {
                        currentInstance = Instantiate(gridPrefab, parentObject.transform);
                        xCoordinate.Add(0);
                    }

                    currentInstance.gameObject.transform.SetPositionAndRotation(new Vector3((zeroPointX + (x + 1)), 1.01f, (zeroPointZ + (z + 1))), Quaternion.identity);

                }

                buildablePlatforms.Add(xCoordinate);
            }
        }
        else
        {
            int currentX = 0;

            foreach(List<int> x in buildablePlatforms)
            {
                currentX += 1;

                foreach(int z in x)
                {
                    if(z == 0)//check for platform, mud or building. Each building has another number
                    {
                        currentInstance = Instantiate(gridPrefab, parentObject.transform);
                    }
                    else if(z == 1)
                    {
                        currentInstance = Instantiate(buildable, parentObject.transform);
                    }

                    currentInstance.gameObject.transform.SetPositionAndRotation(new Vector3((zeroPointX + (currentX + 1)), 1.01f, (zeroPointZ + (z + 1))), Quaternion.identity);
                }
            }
        }
    }
}
