using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour {


    public void MainMenu ()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
    /*
    public FadeLevel fadeLevel;

    public void MainMenu()
    {
        StartCoroutine(StartMainMenuFade(3));
    }

    public IEnumerator StartMainMenuFade(float fadeTimeEachWay)
    {
        fadeLevel.FadeToOpaque(fadeTimeEachWay);
        float currentTime = Time.time;
        while (Time.time < currentTime + fadeTimeEachWay)
        {
            yield return null;
        }

        //SceneManager.LoadScene("Main Menu", LoadSceneMode.Additive);
        fadeLevel.FadeToTransparent(fadeTimeEachWay);
    } 
    */

}
