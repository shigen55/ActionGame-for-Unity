using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1_controller : MonoBehaviour
{
    [SerializeField] private Detection_wave st;
    [SerializeField] Ground ground;
    [SerializeField] GameObject NextStage;
    [SerializeField] GameObject player;
    [SerializeField] Liner[] Objects;
    [SerializeField] GameObject[] tele;
   
    private float time = 8;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (st.movelevel == 2)
        {           
            if (st.eyes)player.transform.position = tele[0].transform.position;
        }
        if (st.movelevel == 3)
        {
            
                st.Stagelevel = 2;
                st.movelevel = 1;
                NextStage.SetActive(true);
                this.gameObject.SetActive(false);
                ground.ground = false;
        }
    }
}