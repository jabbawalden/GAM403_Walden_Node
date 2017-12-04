using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMenu : MonoBehaviour
{
    
    public GameObject menuPanel;
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

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            panelCheck = !panelCheck;

        }
    }
    

}
