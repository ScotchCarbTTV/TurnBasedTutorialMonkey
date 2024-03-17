using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikuFly : MonoBehaviour
{
    [SerializeField] Rigidbody rbody;

    [SerializeField] float accelForce;

    [SerializeField] float rotSpeed;

    bool accel = true;

    private void Start()
    {
        rbody = GetComponent<Rigidbody>();
        //rbody.useGravity = false;


    }

    void Update()
    {
        if (accel)
        {
            rbody.AddForce(Vector3.left * accelForce, ForceMode.Acceleration);

            Quaternion finalRot = Quaternion.Euler(-34, 0, 114);

            transform.rotation = Quaternion.Lerp(transform.rotation, finalRot, rotSpeed * Time.deltaTime);
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Respawn")
        {
            accel = false;
            rbody.useGravity = true;
        }
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hhit");
        rbody.AddExplosionForce(500, collision.transform.position, 50);
    }*/
}
