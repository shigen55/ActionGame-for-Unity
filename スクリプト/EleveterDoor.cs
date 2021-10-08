using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleveterDoor : MonoBehaviour
{
    [SerializeField] private Eleveter eleveter;
    [SerializeField] private Animation anim;
    private bool stac;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(eleveter.present_Location >= 1 && !stac)
        {
           PlayAnimation(anim);

        }
    }
    void PlayAnimation(Animation anim)
    {
        anim.Play();
        stac = true;
    }
}
