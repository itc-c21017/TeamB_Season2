using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDown : MonoBehaviour
{
    public ScoreManager scoreManager;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Down")//床のタグ(wall)を検知し、自身を消滅させスコア加算。スコアはUnity上で設定可能。
        {
            scoreManager.DownScore();
        }
    }
}
