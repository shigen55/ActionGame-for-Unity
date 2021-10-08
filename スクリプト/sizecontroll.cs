using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizecontroll : MonoBehaviour
{
    float size = 10;

    [SerializeField] private bool start;
    [SerializeField] GameObject box;
    private float time = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            box.gameObject.SetActive(true);

            StartCoroutine("Smaller");

            if (size <= 1)
            {
                time -= Time.deltaTime; 
                if(time <= 0)
                {
                    time = 5;
                    start = false;
                }
                
                
            }
        }
        else
        {
            StartCoroutine("Biger");
            if (size >= 10)
            {
                box.gameObject.SetActive(false);
            }
        }


    }

    private IEnumerator Smaller()
    {
        while (size > 1)
        {

            size -= 1 * Time.deltaTime;
            yield return new WaitForSeconds(0.2f);
            box.transform.localScale = new Vector3(size, size, size);
        }
    }

    private IEnumerator Biger()
    {
        while (size < 10)
        {

            size += 1 * Time.deltaTime;
            yield return new WaitForSeconds(0.2f);
            box.transform.localScale = new Vector3(size, size, size);
        }
    }
}
