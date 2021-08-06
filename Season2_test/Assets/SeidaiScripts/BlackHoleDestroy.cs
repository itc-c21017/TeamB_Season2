using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleDestroy : MonoBehaviour
{
    public UI ui;
    int score;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlackHole")
        {
            /*score = UI.Shinchoku();
            score += 5;*/
            Destroy(this.gameObject);//タグ判定してオブジェクト消すっす
        }
    }
}
