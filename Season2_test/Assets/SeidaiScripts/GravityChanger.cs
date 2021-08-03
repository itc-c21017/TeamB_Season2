using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour
{

    //重力加速度
    const float Gravity = 9.81f;

    //重力の適用具合
    public float gravityScale = 1.0f;

    void Update()
    {
        Vector3 vector = new Vector3();
        if (Input.GetKey("z"))
        {
            vector.y = 1.0f;
        }
        //シーンの重力を入力ベクトルの方向に合わせて変化させる
        Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}
