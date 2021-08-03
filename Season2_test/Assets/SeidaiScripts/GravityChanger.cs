using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour
{

    //�d�͉����x
    const float Gravity = 9.81f;

    //�d�͂̓K�p�
    public float gravityScale = 1.0f;

    void Update()
    {
        Vector3 vector = new Vector3();
        if (Input.GetKey("z"))
        {
            vector.y = 1.0f;
        }
        //�V�[���̏d�͂���̓x�N�g���̕����ɍ��킹�ĕω�������
        Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}
