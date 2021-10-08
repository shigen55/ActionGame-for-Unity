using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raypoint : MonoBehaviour
{
    [SerializeField] private float maxDistance;//Rayの長さ
    [SerializeField] private PlayerItemControll controll;
    public int SwichID;
    public int ItemID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red);
        if (Physics.SphereCast(ray,0.1f, out hit, maxDistance , LayerMask.GetMask("Target")))
        {
            if(hit.collider.tag == "Swich")
            {
                SwichID = hit.collider.GetComponent<SwichID>().ID;
            }
            else
            {
                SwichID = 0;
            }
            if (hit.collider.tag == "Item")
            {
                ItemID = hit.collider.GetComponent<ItemID>().ID;
            }
            else
            {
                ItemID = 0;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (SwichID == 1 )
                {            
                                hit.collider.GetComponentInParent<Eleveter>().Elebeter_on = true;
                                hit.collider.GetComponent<SwichID>().ID = 0;
                }
                if (SwichID == 2)
                {
                    hit.collider.GetComponentInParent<gate>().Elebeter_on = true;
                    hit.collider.GetComponent<SwichID>().ID = 0;
                }

                if (ItemID == 1)
                {
                    Destroy(hit.collider.gameObject);
                    controll.Getgun = true;
                    ItemID = 0;
                }
            }
            
        }
        else
        {
            SwichID = 0;
            ItemID = 0;
        }

    }
}
