using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] player ps;
    [SerializeField] Detection_wave Detection_wave;
    [SerializeField] GameObject spark;
    [SerializeField] GameObject Butterfly;

    private float time;
    private float distance;
    private bool tr = false;
    [SerializeField] private bool Notbrain;
    // Start is called before the first frame update
    void Start()
    {
        ps = player.GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, player.transform.position);
        if (distance <= 3 && !tr)
        {
            Detection_wave.movelevel += 1;
            if(!Notbrain) Detection_wave.eyes = true;
            tr = true;
            spark.SetActive(true);
            Butterfly.SetActive(false);
        }
        if (tr) time += Time.deltaTime;
        if (time >= 3) this.gameObject.SetActive(false);
    }
}
