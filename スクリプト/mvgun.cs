using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class mvgun : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        var sequence = DOTween.Sequence();

        //Appendで動作を追加していく
        sequence.Append(this.transform.DOMove(this.transform.position + new Vector3(0f, 0.1f, 0f), 1));
        sequence.SetLoops(-1, LoopType.Yoyo);
        //Playで実行
        sequence.Play()
        .OnStart(() =>
        {
            this.transform.DOLocalRotate(new Vector3(0, 180, 0), 2f).SetLoops(-1, LoopType.Incremental); ;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
