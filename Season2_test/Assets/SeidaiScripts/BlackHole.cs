using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public GameObject BlackHolePrefab;
    public float shotForceLight;
    public float shotTorque;
    void Update()//���N���b�N�Ōy���e����
    {
        if (Input.GetMouseButtonDown(0))

            Shot();
    }
    public void Shot()
    {
        //if (costManager.GetCostAmount() < 10) return; //�R�X�g�s���Ȃ甭�˕s��,�����̃R�X�g�͒e���Ƃł����ƈ�v�����邱��
        float PZ = this.transform.position.z;
        PZ += 2;
        GameObject light = (GameObject)Instantiate(BlackHolePrefab, new Vector3(0, 5, PZ),
        Quaternion.Euler(0, 0, 0));
        /*Rigidbody blackRigidBody = light.GetComponent<Rigidbody>();
        blackRigidBody.AddForce(transform.forward * shotForceLight * 100);
        blackRigidBody.AddTorque(new Vector3(0, shotTorque, 0));*/
    }
}
