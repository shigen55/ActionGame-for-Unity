using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class move : MonoBehaviour
{
    [SerializeField, Range(-20, 40)] float MoveRange;
    [SerializeField, Range(-20, 40)] float MoveHeight;
    [SerializeField, Range(0, 20)] float MoveTime;
    [SerializeField] bool loopoff;
    // Start is called before the first frame update
    void Start()
    {
        var sequence = DOTween.Sequence();

        //Appendで動作を追加していく
        sequence.Append(this.transform.DOMove(this.transform.position + new Vector3(0f, MoveHeight, MoveRange), MoveTime));
        if(!loopoff)sequence.SetLoops(-1, LoopType.Yoyo);
        
        //Playで実行
        sequence.Play();
    }

 
}
