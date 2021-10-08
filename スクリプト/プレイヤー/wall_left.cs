﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_left : MonoBehaviour
{
    [SerializeField] private player player;
    [SerializeField] private Ground Ground;
    [SerializeField] private In_flont In_Flont;
    [SerializeField] private Wall_Right wall_Right;
    private float maxDistance = 0.45f;//Rayの長さ
    public Vector3 Wall_angle;//向く角度
    public bool Left_Walls;//壁走りON
    public GameObject OBJ2;//法線参照用クローンOBJ
    public bool Access_left;//一定時間のアクセス権禁止
    private float Access_time; //カウント  
    // Start is called before the first frame update
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red);
        if (Physics.SphereCast(ray, 0.1f, out hit, maxDistance))
        {
            if (hit.collider.gameObject.tag == "Junp_wall" && !Ground.ground && Input.GetKey(KeyCode.LeftShift) && hit.collider.gameObject.GetInstanceID() != player.BlockID_Run && !wall_Right.Right_Walls && In_Flont.front_Walls == 0)
            {
                /////////////////////////角度変更////////////////////////////////
                Quaternion rot = Quaternion.FromToRotation(transform.forward, hit.normal);

                GameObject cloneBox = Instantiate(OBJ2, hit.point, rot, hit.transform);

                cloneBox.transform.rotation = rot * transform.rotation;

                Wall_angle = cloneBox.GetComponent<Rigidbody>().transform.eulerAngles;
                Wall_angle.y -= 90;
                Wall_angle.z = 0;
                Wall_angle.x = 0;
                /////////////////////////角度変更////////////////////////////////
                Left_Walls = true;

                player.BlockID_Retention = hit.collider.gameObject.GetInstanceID();//壁のID保持
            }
            if (player.sp == 0 || Ground.ground || hit.collider.gameObject.tag != "Junp_wall" || player.Jump_wall)
            {
                player.Cameraroteto = player.Rot.eulerAngles.y;
                Left_Walls = false;
                player.BlockID_Run = player.BlockID_Retention;
            }

        }
        else
        {
            Left_Walls = false;
            player.BlockID_Run = player.BlockID_Retention;
        }

        if (!Access_left)
        {
            if (Access_time >= 0)
            {
                Access_time -= Time.deltaTime;
            }
            else
            {
                Access_left = true;
            }
        }
    }
}
