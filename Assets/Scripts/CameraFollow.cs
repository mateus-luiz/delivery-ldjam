using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;

    [SerializeField] private float followSpeed;
    [SerializeField] private float rotationSpeed;

    void FixedUpdate() 
    {
        var targetPosition = target.TransformPoint(offset);
        var direction = target.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);


    }
}
