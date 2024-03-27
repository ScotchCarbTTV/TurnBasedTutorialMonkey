using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateAround : MonoBehaviour
{
    [SerializeField] Transform rotObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(rotObject.position, Vector3.up, 20 * Time.deltaTime);

        transform.LookAt(rotObject.position);
    }
}
