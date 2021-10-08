using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eleveter : MonoBehaviour
{
    public bool Elebeter_on;
    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;
    public float present_Location;
    private float distance_two;
    private float time;
    [SerializeField] Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        Elebeter_on = false;
        distance_two = Vector3.Distance(startMarker.position, endMarker.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Elebeter_on)
        {
            time += Time.deltaTime * speed;
            
            present_Location = time / distance_two;
            transform.position = Vector3.Lerp(startMarker.position, endMarker.position, present_Location);
            if (present_Location > 1) Elebeter_on = false;
        }
        else
        {
            Player.parent = null;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Elebeter_on)
        {
            Player.parent = this.gameObject.transform;
        }
        
    }
    }
