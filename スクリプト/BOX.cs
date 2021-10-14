using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOX : MonoBehaviour
{
    public bool hit; //当たり判定のフラグ
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        //プレイヤーに当たった処理
        if(other.tag == "Player")
        {
            hit = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //プレイヤーから離れた処理
        if (other.tag == "Player")
        {
            hit = false;
        }
    }
}
