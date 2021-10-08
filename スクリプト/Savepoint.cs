using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savepoint : MonoBehaviour
{
    public GameObject[] points;
    public int nowpoint;
    public Vector3 Saveposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nowpoint != points.Length) points[nowpoint].SetActive(true);
        for (int j = 0; j < points.Length; ++j)
        {
            if (j == nowpoint)
            {
                continue;
            }
            points[j].SetActive(false);
        }
    }


}
