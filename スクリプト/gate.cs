using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
{
    public bool Elebeter_on;
    public bool Elebeter_off;
    private bool stack;
    private Vector3 startMarker;
    private Vector3 endMarker;
    public float speed = 1.0F;
    public int upwidth;
    private float distance_two;
    private float time;
    private float present_Location;
    // Start is called before the first frame update
    void Start()
    {
       
        startMarker = transform.position;
        endMarker = startMarker + new Vector3(0, upwidth, 0); 
        distance_two = Vector3.Distance(startMarker, endMarker);
    }

    // Update is called once per frame
    void Update()
    {
        if (Elebeter_on)
        {
            time += Time.deltaTime * speed;

            present_Location = time / distance_two;
            transform.position = Vector3.Lerp(startMarker, endMarker, present_Location);
            if (present_Location > 1) Elebeter_on = false;
        }
        if (Elebeter_off)
        {
            time += Time.deltaTime * speed;

            present_Location = time / distance_two;
            transform.position = Vector3.Lerp(startMarker, endMarker, present_Location);
        }
        if(present_Location > 1 && !stack)
        {
            startMarker = transform.position;
            endMarker = startMarker + new Vector3(0, -upwidth, 0);
            distance_two = Vector3.Distance(startMarker, endMarker);
            time = 0;
            stack = true;
        }
    }
}
