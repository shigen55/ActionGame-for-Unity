using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class piston : MonoBehaviour
{
    [SerializeField, Range(-20, 20)] float MoveRange;
    [SerializeField, Range(-20, 20)] float MoveHeight;
    [SerializeField, Range(0, 20)] float MoveTime;
    [SerializeField, Range(-0.1f, 20)] float time;
    // Start is called before the first frame update
    void Start()
    {
        var sequence = DOTween.Sequence();
        //Appendで動作を追加していく
        if (time < 0) sequence.AppendInterval(Random.Range(0.1f, 2f)); else sequence.AppendInterval(time);
        sequence.Append(this.transform.DOMove(this.transform.position + new Vector3(0f, MoveHeight, MoveRange), MoveTime));
        sequence.SetLoops(-1, LoopType.Yoyo);
        sequence.Play();
    }
}
