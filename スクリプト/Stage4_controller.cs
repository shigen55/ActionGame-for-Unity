using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4_controller : MonoBehaviour
{
    [SerializeField] private Detection_wave st;
    [SerializeField] Ground ground;
    [SerializeField] GameObject NextStage;
    [SerializeField] GameObject player;
    [SerializeField] GameObject tele;
    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = tele.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (st.movelevel == 5)
        {
            st.Stagelevel = 5;
            st.movelevel = 1;
            NextStage.SetActive(true);
            this.gameObject.SetActive(false);
            ground.ground = false;
        }
    }
}
