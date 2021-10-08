﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detection_wave : MonoBehaviour
{
    [SerializeField] private tutorial_Controller tutorial;
    [SerializeField] private stage1_controller Stage1;
    [SerializeField, Range(1, 20)] public int Stagelevel = 1;
    [SerializeField, Range(1, 20)] public int movelevel = 1;
    public Image Qtext;
    private float time;
    public bool eyes;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tutorial.st.movelevel == 5) eyes = true;

        if (eyes) 
        { 
            Qtext.enabled = true;
            time += Time.deltaTime;
            if (time >= 0.3) eyes = false;
        } 
        else 
        {
            Qtext.enabled = false;
            time = 0;
        }
    }

}