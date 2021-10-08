using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking_camera : MonoBehaviour
{
    [SerializeField] private GameObject child;
    [SerializeField] private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            child.transform.LookAt(Player.transform);
        }
    }
}
