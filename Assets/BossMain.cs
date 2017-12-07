using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMain : MonoBehaviour {

    public int bossHealth;

    private void Start()
    {
        bossHealth = GameController.control.bossFinalHealth;
    }

    void Update()
    {
        bossHealth = GameController.control.bossFinalHealth;

        if (bossHealth == 0)
        {
            Destroy(gameObject);
        }
    }

}
