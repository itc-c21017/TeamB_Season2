using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleDestroy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gomi")
        {
            //scoreManager.AddScore(score);
            Destroy(this.gameObject);//タグ判定してオブジェクト消すっす
        }
    }
}
