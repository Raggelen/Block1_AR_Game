using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    bool mainMenuActive = false;
    public bool wantsToBuild = false;
    string currentPanel = "Buildings";
    public string currentlyBuilding = "";
    public string currentLaw = "";

    [SerializeField]
    GameObject buildingMenu;
    [SerializeField]
    GameObject lawMenu;

    List<string> buildings = new List<string>();
    List<string> laws = new List<string>();

    private void Start()
    {

        if (this.tag == "Menu")
        {
            //resize and reposition
        }
    }

    public void ActivateMenu()
    {
        if(mainMenuActive == false)
        {
            mainMenuActive = true;
            if(currentPanel == "Buildings")
            {
                buildingMenu.SetActive(true);
            }
            else
            {
                lawMenu.SetActive(true);
            }
        }
        else
        {
            mainMenuActive = false;
            buildingMenu.SetActive(false);
            lawMenu.SetActive(false);
        }
    }

    public void ChangePanel()
    {
        if(currentPanel == "Buildings")
        {
            currentPanel = "Laws";
            buildingMenu.SetActive(false);
            lawMenu.SetActive(true);
        }
        else
        {
            currentPanel = "Buildings";
            lawMenu.SetActive(false);
            buildingMenu.SetActive(true);
        }
    }

    public void SelectBuilding()
    {
        //check resources, then await touch on the grid.
        wantsToBuild = true;
        ActivateMenu();
    }

    public void SelectLaw()
    {
        //follow the law rules.
    }
}
