using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMenu : MonoBehaviour
{
    
    public GameObject menuPanel;
    //panel reference
    bool panelCheck = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (panelCheck == false)
        {
            menuPanel.SetActive(false);
        }

        if (panelCheck == true)
        {
            menuPanel.SetActive(true);

        }
        //uses bool check to set menuPanel

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            panelCheck = !panelCheck;

        }
        //if press 1, turns panel on and off upon each press
    }
    

}
