using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorcycleController : MonoBehaviour
{
    private MotorcycleActions actions;

    [Header("Components")]
    [SerializeField] private Rigidbody motorcycleRigidbody;
    [SerializeField] private Camera cam;

    [Header("Movement Settings")]
    private Vector3 direction;
    private float turnTime = 0.1f;
    private float smoothVelocity;

    [Header("Velocity Settings")]
    [SerializeField] private float maxVelocity;
    private float currentVelocity = 0f;
    
    private bool isBreaking = false;
    [SerializeField] private float brakeForce;

    void Awake()
    {
        actions = new MotorcycleActions();
    }

    void OnEnable() 
    {
        actions.Enable();
    }

    void OnDisable()
    {
        actions.Disable();
    }

    void Start() 
    {
        motorcycleRigidbody = GetComponent<Rigidbody>();
    }

    void Update() 
    {
        isBreaking = actions.MotorcycleInputs.Brake.IsPressed() ? true : false;

        if(currentVelocity > maxVelocity) currentVelocity = maxVelocity;
        if(isBreaking && currentVelocity >= 0.1f)
        {
            currentVelocity -= brakeForce * Time.deltaTime;
        }

        Vector2 inputs = actions.MotorcycleInputs.Direction.ReadValue<Vector2>();

        direction.x = inputs.x * maxVelocity;
        direction.z = inputs.y * maxVelocity;
    }

    void FixedUpdate() {

        float directionAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
        float smoothAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, directionAngle, ref smoothVelocity, turnTime);
        
        if(direction.magnitude >= 0.1f)
        {
            transform.rotation = Quaternion.Euler(0f, smoothAngle, 0f);
            currentVelocity += 1f * Time.deltaTime;
        }

        Vector3 moveDirection = transform.forward * currentVelocity;
        motorcycleRigidbody.MovePosition(transform.position + moveDirection * Time.deltaTime);
    }
}
