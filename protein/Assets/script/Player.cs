using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform CameraArm;
    public Transform CharacterBody;
    public Animator animator;
    public float Speed;
    private void Update()
    {
        LookAround();
        Move();
    }
    private void Move()
    {
        Vector2 MoveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));      
        bool isMove = MoveInput.magnitude != 0;
        animator.SetBool("isMove", isMove);
        bool isRun = Input.GetKey(KeyCode.LeftShift);
        if (isMove)
        {
            Vector3 lookForward = new Vector3(CameraArm.forward.x, 0f, CameraArm.forward.z).normalized;
            Vector3 lookRight = new Vector3(CameraArm.right.x, 0f, CameraArm.right.z).normalized;
            Vector3 moveDir = lookForward * MoveInput.y + lookRight * MoveInput.x;
            if (isRun)
            {
                Speed = 15;
                animator.SetBool("isRun", true);
            }
            else
            {
                Speed = 10;
                animator.SetBool("isRun", false);
            }
            CharacterBody.forward = Vector3.Slerp(CharacterBody.forward, moveDir, Time.deltaTime * 7);
            transform.position += moveDir * Time.deltaTime * Speed;
        }
    }
    private void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 camAngle = CameraArm.rotation.eulerAngles;
        float x = camAngle.x - mouseDelta.y * 10;

        if (x < 180f)
        {
            x = Mathf.Clamp(x, -1f, 70f);
        }
        else
        {
            x = Mathf.Clamp(x, 335f, 361f);
        }

        CameraArm.rotation = Quaternion.Euler(x, camAngle.y + mouseDelta.x * 10, camAngle.z);

        //HPBar.fillAmount = Health / MaxHealth;
    }
}
