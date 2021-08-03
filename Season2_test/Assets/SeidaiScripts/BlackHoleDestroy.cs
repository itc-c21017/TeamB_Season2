using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleDestroy : MonoBehaviour
{
    /*public GameObject effectPrefab;
    public Vector3 effectRotation;*/
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gomi")//床のタグ(wall)を検知し、自身を消滅させスコア加算。スコアはUnity上で設定可能。
        {
            //scoreManager.AddScore(score);
            Destroy(this.gameObject);
        }
        //エフェクトの出現(エフェクト内SEも仕込めば音鳴らせます)
        //標的によってエフェクト変えたかったら違うプレファブを用意すること。
        /*if (effectPrefab != null)
        {
            Instantiate(
            effectPrefab,
            this.transform.position,
            Quaternion.Euler(effectRotation));
        }*/
    }
}
