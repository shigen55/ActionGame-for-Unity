using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_controller : MonoBehaviour
{
    [SerializeField] private Detection_wave st;
    [SerializeField] Ground ground;
    [SerializeField] GameObject NextStage;
    [SerializeField] Liner[] Objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (st.movelevel == 2)
        {

            st.Stagelevel = 3;
            st.movelevel = 1;
            NextStage.SetActive(true);
            this.gameObject.SetActive(false);
            ground.ground = false;
        }
    }
}
