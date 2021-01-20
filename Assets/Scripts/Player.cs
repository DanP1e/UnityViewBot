using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public Rigidbody Rigidbody;
    void Update()
    {
        Rigidbody.velocity = new Vector3();
        Vector3 movePose = new Vector3(Input.GetAxis("Horizontal"), Rigidbody.velocity.y, Input.GetAxis("Vertical")) * Speed;
        Rigidbody.velocity = movePose; 
    }
}
