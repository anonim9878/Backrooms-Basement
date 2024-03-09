using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] float sensity;
    Vector2 turn;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void FixedUpdate()
    {
        move();
        mouseRotation();
    }

    void move()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void mouseRotation()
    {
        turn.x += Input.GetAxis("Mouse X") * sensity;
        turn.y += Input.GetAxis("Mouse Y") * sensity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
