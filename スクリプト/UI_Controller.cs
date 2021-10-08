using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    [SerializeField] private GameObject Point;
    [SerializeField] private Text frontOjName;
    [SerializeField] private Raypoint raypoint;
    [SerializeField] private string[] SwitchName;
    [SerializeField] private string[] ItemName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (raypoint.ItemID != 0 || raypoint.SwichID != 0)
        {
            Point.SetActive(true);
            if (raypoint.SwichID != 0) frontOjName.text = SwitchName[raypoint.SwichID];
            if (raypoint.ItemID != 0) frontOjName.text = ItemName[raypoint.ItemID];
        }
        else
        {
            Point.SetActive(false);
        }
    }
}
