using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MikuFly : MonoBehaviour
{
    [SerializeField] Rigidbody rbody;

    private void Start()
    {
        rbody = GetComponent<Rigidbody>();
        //rbody.useGravity = false;


    }

    void Update()
    {
        
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hhit");
        rbody.AddExplosionForce(500, collision.transform.position, 50);
    }*/
}
