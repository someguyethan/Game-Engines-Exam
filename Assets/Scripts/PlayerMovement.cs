using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            controller.Move(new Vector3(0, moveSpeed * Time.deltaTime, 0));
        if (Input.GetKey(KeyCode.A))
            controller.Move(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
        if (Input.GetKey(KeyCode.S))
            controller.Move(new Vector3(0, -moveSpeed * Time.deltaTime, 0));
        if (Input.GetKey(KeyCode.D))
            controller.Move(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
    }
}
