using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGet : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int score;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")//���̃^�O(wall)�����m���A���g�����ł����X�R�A���Z�B�X�R�A��Unity��Őݒ�\�B
        {
            scoreManager.AddScore(score);
        }
    }
}
