using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDown : MonoBehaviour
{
    public ScoreManager scoreManager;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Down")//���̃^�O(wall)�����m���A���g�����ł����X�R�A���Z�B�X�R�A��Unity��Őݒ�\�B
        {
            scoreManager.DownScore();
        }
    }
}
