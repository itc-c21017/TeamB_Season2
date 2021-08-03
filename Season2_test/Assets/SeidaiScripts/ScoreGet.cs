using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGet : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int score;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")//床のタグ(wall)を検知し、自身を消滅させスコア加算。スコアはUnity上で設定可能。
        {
            scoreManager.AddScore(score);
        }
    }
}
