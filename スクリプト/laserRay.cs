using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserRay : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletHolePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       

    }

    public void shot()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 500f, Color.red);
        if (Physics.SphereCast(ray, 0.1f, out hit, 500f))
        {
            if (hit.collider.gameObject.tag == "OBJ") ;
            var decalPos = hit.point + hit.normal * 0.01f;
            var decalRot = Quaternion.FromToRotation(-bulletHolePrefab.transform.forward, hit.normal);
            Instantiate(bulletHolePrefab, decalPos, decalRot);
        }
    }
}
