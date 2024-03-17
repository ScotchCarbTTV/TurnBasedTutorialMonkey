using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeExplode : MonoBehaviour
{
    // Start is called before the first frame update

    bool exploded = false;

    Rigidbody rbody;

    void Start()
    {
        exploded = false;

        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && exploded == false)
        {
            exploded = true;

            Vector3 dir = (collision.transform.position - transform.position).normalized;

            rbody.AddExplosionForce(50f, collision.transform.position, 10f);
        }

        if(collision.gameObject.tag == "Respawn" && exploded == true)
        {
            Vector3 dir = (collision.transform.position - transform.position).normalized;
            rbody.AddForce(dir * 10, ForceMode.Force);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Respawn" && exploded == true)
        {
            Vector3 dir = (collision.transform.position - transform.position).normalized;
            rbody.AddForce(dir * 10, ForceMode.Force);
        }
    }


}
