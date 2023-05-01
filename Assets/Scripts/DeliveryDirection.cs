using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryDirection : MonoBehaviour
{
    [Header("Target Settings")]
    [SerializeField] private Transform target;
    [SerializeField] private float aimSpeed;

    void FixedUpdate()
    {
        if(target != null)
        {
            var direction = transform.position - target.position;
            var rotation = Quaternion.LookRotation(direction, Vector3.up);

            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, aimSpeed * Time.deltaTime);
        }
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
