using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRun : MonoBehaviour
{
    //自動走行、壁面、天井移動全部を司るっす
    const int MinLaneX = -3;
    const int MaxLaneX = 3;
    const float LaneWidthX = 1.5f;

    CharacterController controller;

    Vector3 moveDirection = Vector3.zero;
    int targetLaneX;

    public GameObject Stage;
    public float gravity;
    public float speedZ;
    public float speedY;
    public float speedX;
    public float speedJump;
    public float accelerationZ;
    bool coroutineBool = false;

    public UI ui;
    public int score;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        if (Input.GetKeyDown("left")) MoveToLeft();
        if (Input.GetKeyDown("right")) MoveToRight();
        if (Input.GetKeyDown("space")) Jump();
        { 
            float acceleratedZ = moveDirection.z + (accelerationZ * Time.deltaTime);
            moveDirection.z = Mathf.Clamp(acceleratedZ, 0, speedZ);

            float ratioX = (targetLaneX * LaneWidthX - transform.position.x) / LaneWidthX;
            moveDirection.x = ratioX * speedX;

            score = UI.Ascore();//性能低下
            if (score >= 5)
            {
                moveDirection.x *= 0.6f;
            }
        }
        Vector3 globalDirection = transform.TransformDirection(moveDirection);
        controller.Move(globalDirection * Time.deltaTime);

        moveDirection.y -= gravity * Time.deltaTime;

        if (controller.isGrounded) moveDirection.y = 0;
    }

    public void MoveToLeft()
    {
        if (targetLaneX > MinLaneX)            
            targetLaneX--;
        else
        { 
          if (!coroutineBool)
            {
               coroutineBool = true;
               StartCoroutine("LeftRotation");
            }
            targetLaneX = MaxLaneX;
        }
    }
    public void MoveToRight()
    {
        if (targetLaneX < MaxLaneX)            
            targetLaneX++;
        else
        {
            if (!coroutineBool)
            {
                coroutineBool = true;
                StartCoroutine("RightRotation");
            }
            targetLaneX = MinLaneX;
        }
    }
    public void Jump()
    {
        moveDirection.y = speedJump;
        targetLaneX = -targetLaneX;
        if (!coroutineBool)
        {
            coroutineBool = true;
            StartCoroutine("JumpRotation");
        }
    }
    IEnumerator JumpRotation()
    {
        for (int turn = 0; turn < 30; turn++)
        {
            Stage.transform.Rotate(0, 0, 6);
            yield return new WaitForSeconds(0.01f);
        }
        coroutineBool = false;
    }
    IEnumerator LeftRotation()
    {
        moveDirection.y = speedJump * -3.0f;
        for (int turn = 0; turn < 15; turn++)
        {
            Stage.transform.Rotate(0, 0, 6);
            yield return new WaitForSeconds(0.01f);
        }
        coroutineBool = false;
    }
    IEnumerator RightRotation()
    {
        moveDirection.y = speedJump * -3.0f;
        for (int turn = 0; turn < 15; turn++)
        {
            Stage.transform.Rotate(0, 0, -6);
            yield return new WaitForSeconds(0.01f);
        }
        coroutineBool = false;
    }
}