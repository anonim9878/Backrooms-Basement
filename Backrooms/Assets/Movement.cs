using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] int speedZ;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speedZ * Time.deltaTime);
        transform.position = new Vector3(transform.position.x + speedZ * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
