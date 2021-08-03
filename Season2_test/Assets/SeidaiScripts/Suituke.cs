using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suituke : MonoBehaviour
{
    public string targetTag;
    bool isHolding;

    //ボールが入っているかを返す
    public bool IsHolding()
    {
        return isHolding;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == targetTag)
        {
            isHolding = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == targetTag)

        {
            isHolding = false;
        }
    }
    void OnTriggerStay(Collider other)
    {
        //コライダに触れているオブジェクトのRigidbodyコンポーネントを取得
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        //ボールがどの方向にあるかを計算 自分を0とした時の相手の位置が分かるんよ
        Vector3 direction = other.gameObject.transform.position - transform.position;
        direction.Normalize();

        //タグに応じてボールに力を加える
        if (other.gameObject.tag == targetTag)
        {
            //中心地点でボールを止めるため速度を減速させる
            r.velocity *= 1.3f;
            r.AddForce(direction * -30.0f, ForceMode.Acceleration);

            Destroy(other.gameObject, 0.7f);
        }
    }
}
