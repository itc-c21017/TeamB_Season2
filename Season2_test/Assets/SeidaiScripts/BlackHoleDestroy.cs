using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleDestroy : MonoBehaviour
{
    /*public GameObject effectPrefab;
    public Vector3 effectRotation;*/
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gomi")//���̃^�O(wall)�����m���A���g�����ł����X�R�A���Z�B�X�R�A��Unity��Őݒ�\�B
        {
            //scoreManager.AddScore(score);
            Destroy(this.gameObject);
        }
        //�G�t�F�N�g�̏o��(�G�t�F�N�g��SE���d���߂Ή��点�܂�)
        //�W�I�ɂ���ăG�t�F�N�g�ς�����������Ⴄ�v���t�@�u��p�ӂ��邱�ƁB
        /*if (effectPrefab != null)
        {
            Instantiate(
            effectPrefab,
            this.transform.position,
            Quaternion.Euler(effectRotation));
        }*/
    }
}
