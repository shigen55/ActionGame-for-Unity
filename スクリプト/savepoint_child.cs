using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savepoint_child : MonoBehaviour
{
    public Savepoint savepoint;
    // Start is called before the first frame update
    void Start()
    {
        savepoint = GameObject.Find("SavePoint").GetComponent<Savepoint>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            savepoint.nowpoint += 1;
            savepoint.Saveposition = transform.position;
            gameObject.SetActive(false);
        }

    }
}
