using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class gun : MonoBehaviour
{
    [SerializeField] GameObject top;
    [SerializeField] GameObject handgard;
    [SerializeField] GameObject magazine;
    [SerializeField] GameObject trigger;
    [SerializeField] laserRay laserRay;
    private int ammo = 5;
    private bool endbool = true;
    private bool re = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!endbool)
        {
            if (Input.GetMouseButtonDown(0) && ammo != 0)
            {

                shot();
                ammo--;
            }
            if (Input.GetMouseButtonDown(0) && ammo == 0)
            {
                noshot();
            }
            if (ammo == 0)
            {
                noammo();


            }
            if (Input.GetKeyDown(KeyCode.R) && !re)
            {
                reload();
                ammo = 0;
            }
        }

    }

    void shot()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(trigger.transform.DOLocalRotate(new Vector3(-37.07f, 0, 0), 0.3f));
        sequence.Append(top.transform.DOLocalMove(new Vector3(-0.05f, 1.87f, 1.05f), 0.12f)).OnStart(() =>{ laserRay.shot(); });
        sequence.Join(this.transform.DOLocalRotate(new Vector3(11.5f, 0, 0), 0.12f));
        sequence.Append(top.transform.DOLocalMove(new Vector3(-0.05f, 1.87f, -1.05f), 0.12f));
        sequence.Join(trigger.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
        sequence.Join(this.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.2f));
        sequence.Play();
    }

    void noshot()
    {
        var a = DOTween.Sequence();
        a.Append(trigger.transform.DOLocalRotate(new Vector3(-37.07f, 0, 0), 0.3f));
        a.Append(trigger.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f));
    }

    void noammo()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(top.transform.DOLocalMove(new Vector3(-0.05f, 1.87f, 1.05f), 0.12f));
    }
    void reload()
    {
        re = true;
        var b = DOTween.Sequence();
        b.Append(this.transform.DOLocalRotate(new Vector3(-11.76f, 18.65f, -46.9f), 0.1f));
        b.Join(magazine.transform.DOLocalMove(new Vector3(-0.065f, -11.23f, 3.62f), 0.3f));
        b.AppendInterval(0.25f);
        b.Append(this.transform.DOLocalRotate(new Vector3(29.93f, 29.839f, 31.854f), 0.4f));
        b.Append(magazine.transform.DOLocalMove(new Vector3(-0.065f, -0.651f, 1.097f), 0.9f));
        b.Append(this.transform.DOLocalRotate(new Vector3(0f, 0f, 0f), 0.3f));
        b.Play()
            .OnComplete(() =>
            {
                //開始時に呼ばれる
                ammo = 5;
                top.transform.DOLocalMove(new Vector3(-0.05f, 1.87f, -1.05f), 0.12f);
                re = false;
            });
    }

    public void end()
    {
        endbool = true;
        var b = DOTween.Sequence();
        b.Append(this.transform.DOLocalMove(new Vector3(-0.005f, -0.541f, 0.823f), 0.4f));
        b.Play()
            .OnComplete(() =>
            {
                this.gameObject.SetActive(false);
            });
    }

    public void start()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(this.transform.DOLocalMove(new Vector3(-0.15f, -0.15f, -0.23f), 1f));
        sequence.Append(top.transform.DOLocalMove(new Vector3(-0.05f, 1.87f, 1.05f), 0.3f));
        sequence.Append(top.transform.DOLocalMove(new Vector3(-0.05f, 1.87f, -1.05f), 0.12f));
        sequence.Play()
            .OnComplete(() =>
            {
                endbool = false;
            });
    }
}
