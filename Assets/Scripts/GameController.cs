using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController control;
    public int maxHealth;
    public int techParts;
    public Text techShow;
    public GameObject upgradePanel;  
    bool panelCheck = false;
    public Button healthButton;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this; //this becomes the one object referenced by this variable
        } else if (control != null)
        {
            Destroy(gameObject);
            //if already exists, destroy this - singleton design pattern i.e. there can
            //only be one of these.
        }
        
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        //will persist from scene to scene
    }

    void OnGUI()
    {
        /*
        if (//healthbutton)
        {
            maxHealth += 1;
        }

       // GUI.Label(new Rect(10, 70, 100, 30), "techParts: " + techParts);
       */
    }

    
	
	void Update ()
    {
        techShow.text = "Tech parts: " + techParts;
    
        if (panelCheck == false)
        {
            upgradePanel.SetActive(false);
        }

        if (panelCheck == true)
        {
            upgradePanel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            panelCheck = !panelCheck;

        }

    }

}
