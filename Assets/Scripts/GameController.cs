using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static GameController control;
    public int maxHealth;
    public int techCollected;
    public int playerSpeed;
    public Text techShow;
    public GameObject upgradePanel;
    bool panelCheck = false;
    



    void Awake()
    {
        
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this; //this becomes the one object referenced by this variable
        } else if (control != this)
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
        techShow.text = "Tech Collected: " + techCollected;

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

    public void HealthClick()
    {
        maxHealth++;
        print("lol");
    }


    public void SpeedClick()
    {
        playerSpeed += 2;
        print("lol");
    }


}
