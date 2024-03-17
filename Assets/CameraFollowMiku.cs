using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMiku : MonoBehaviour
{
    [SerializeField] GameObject followObject;

    [SerializeField] Vector3 offset;

    [SerializeField] float camSpeed;

    [SerializeField] float camZoomSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = followObject.transform.position + offset;

        transform.position = newPosition;

        offset += Vector3.forward * camZoomSpeed * Time.deltaTime;
        offset += Vector3.right * camZoomSpeed * 1.2f  * Time.deltaTime;

        transform.LookAt(followObject.transform.position + new Vector3(0, 20, 0));
    }
}
