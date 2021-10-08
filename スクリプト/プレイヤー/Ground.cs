using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{ 
    public bool ground = false;
    [SerializeField]private GameObject Player;
    
    void OnTriggerStay(Collider other)
    {
        ground = true;
    }
    void OnTriggerExit(Collider other)
    {
        ground = false;
    }
}
