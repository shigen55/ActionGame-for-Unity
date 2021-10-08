using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemControll : MonoBehaviour
{
    private int select;
    public gun gun;
    public bool Getgun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Alpha1) && Getgun)
        {
            gun.gameObject.SetActive(true);
            gun.start();
            select = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            select = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gun.end();
            select = 3;
        }
    }
}
