using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    const int DefaultCount = 3;

    public GameObject BlackHolePrefab;
    int count = DefaultCount;
    void Update()//���N���b�N�Ńu���b�N�z�[������
    {
        if (Input.GetMouseButtonDown(0))

            Shot();
    }
    public void Shot()
    {
        if (count < 1) return;

        float PZ = this.transform.position.z;
        PZ += 2;
        GameObject light = (GameObject)Instantiate(BlackHolePrefab, new Vector3(0, 5, PZ),
        Quaternion.Euler(0, 0, 0));//�u���b�N�z�[���o�������

        count -= 1;
    }
    public int BlackHoleCount()
    {
        return count;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlackHoleHeal")
        {
            count += 1;
            Destroy(other.gameObject);
        }
    }
}
