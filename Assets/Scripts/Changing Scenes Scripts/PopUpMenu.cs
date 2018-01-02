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
            Time.timeScale = 1f;
        }

        if (panelCheck == true)
        {
            menuPanel.SetActive(true);
            Time.timeScale = 0.0f;

        }
        //uses bool check to set menuPanel

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelCheck = !panelCheck;

        }
        //if press 1, turns panel on and off upon each press
    }
    

}
