using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public GameObject BlackHolePrefab;
    void Update()//左クリックでブラックホール発射
    {
        if (Input.GetMouseButtonDown(0))

            Shot();
    }
    public void Shot()
    {
        float PZ = this.transform.position.z;
        PZ += 2;
        GameObject light = (GameObject)Instantiate(BlackHolePrefab, new Vector3(0, 5, PZ),
        Quaternion.Euler(0, 0, 0));
    }
}
