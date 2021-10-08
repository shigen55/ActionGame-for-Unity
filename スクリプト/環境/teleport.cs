using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    private GameObject player;
    [SerializeField] GameObject Savepoint;
    [SerializeField] Detection_wave Detection_wave;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = Savepoint.transform.position;
            Detection_wave.eyes = true;
        }

        if(other.gameObject.tag == "OBJ")
        {
            Destroy(other.gameObject);
        }
    }
}
