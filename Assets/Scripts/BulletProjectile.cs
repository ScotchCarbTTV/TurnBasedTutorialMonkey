using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{

    [SerializeField] private TrailRenderer trailRenderer;
    [SerializeField] private Transform bulletHitVFXPrefab;

    [SerializeField] private Vector3 targetPosition;
    [SerializeField] private Vector3 targetPosition2;
    public void Setup(Vector3 _targetPosition)
    {
        //Debug.Log("target position parameter is " + _targetPosition);
        targetPosition2 = _targetPosition;
        this.targetPosition = _targetPosition;
        //Debug.Log("Target position is " + this.targetPosition);
    }

    private void Update()
    {
        targetPosition = targetPosition2;

        //Debug.Log(targetPosition);
        Vector3 moveDir = (targetPosition - transform.position).normalized;

        float distanceBeforeMoving = Vector3.Distance(transform.position, targetPosition);

        float moveSpeed = 200f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        float distanceAfterMoving = Vector3.Distance(transform.position, targetPosition);

        //distanceBeforeMoving < distanceAfterMoving

        if (distanceBeforeMoving < distanceAfterMoving)
        {
            transform.position = targetPosition;

            trailRenderer.transform.parent = null;
            Destroy(gameObject);

            Instantiate(bulletHitVFXPrefab, targetPosition, Quaternion.identity);
        }
    }

}
