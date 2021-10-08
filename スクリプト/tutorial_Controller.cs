using UnityEngine;

public class tutorial_Controller : MonoBehaviour
{
    [SerializeField] public Detection_wave st;
    [SerializeField] player player;
    [SerializeField] Ground ground;
    [SerializeField] sizecontroll playerBOX;
    [SerializeField] GameObject NextStage;
    [SerializeField] Liner frontwall;
    [SerializeField] Liner Buckwall;
    [SerializeField] Liner leftwall;
    [SerializeField] Liner rightwall;
    [SerializeField] Liner monitor;
    [SerializeField] Liner[] Objects;

    Vector3 spead = new Vector3(2f, 2f, 2);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (st.movelevel == 2)
        {
            frontwall.endPosition = new Vector3(-255.3f, -28.6f, 82.9f);
            monitor.endPosition = new Vector3(-255.3f, -23.5f, 104.9f);
            Buckwall.endPosition = new Vector3(-254, -28.6f, 128.1f);
            frontwall.enabled = true;
            Buckwall.enabled = true;
            monitor.enabled = true;
        }
        if (st.movelevel == 3)
        {
            Objects[0].enabled = true;
            Objects[1].enabled = true;
        }
        if (st.movelevel == 4)
        {
            Objects[1].endPosition = new Vector3(-254.2f, -52.0f, 117.9f);
            Objects[2].enabled = true;
            Objects[3].enabled = true;
            Objects[4].enabled = true;
            Objects[1].enabled = true;
        }
        if (st.movelevel == 5)
        {
           
                st.Stagelevel = 2;
                st.movelevel = 1;
                NextStage.SetActive(true);
                this.gameObject.SetActive(false);
                ground.ground = false;  
                
        }
    }
    
}