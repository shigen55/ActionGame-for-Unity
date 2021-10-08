using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class dead : MonoBehaviour
{
    [SerializeField] Transform[] points;
    [SerializeField] BOX BOX;
    [SerializeField] Detection_wave st;
    [SerializeField] GameObject player;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BOX.hit)
        {
            if (st.movelevel == 2) player.transform.position = points[0].transform.position;
            if (st.movelevel == 3) player.transform.position = points[1].transform.position;
            if (st.movelevel == 4) player.transform.position = points[2].transform.position;
        }
        if (st.movelevel == 2 && count == 0)
        {
            BOX.transform.DOMoveY(-35f, 3f);
            count = 1;
        }
        if (st.movelevel == 3 && count == 1)
        {
            BOX.transform.DOMoveY(-1f, 3f);
            count = 2;
        }
        if (st.movelevel == 4 && count == 2)
        {
            BOX.transform.DOMoveY(12f, 3f);
            count = 0;
        }
    }
}
