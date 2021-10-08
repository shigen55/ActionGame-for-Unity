using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage_level : MonoBehaviour
{
    public int level;
    [SerializeField] private GameObject player;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       distance =  Vector3.Distance(this.transform.position,player.transform.position);
        if(distance <= 1)
        {

        }
    }
}
