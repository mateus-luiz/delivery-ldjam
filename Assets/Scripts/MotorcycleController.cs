using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorcycleController : MonoBehaviour
{
    private MotorcycleActions actions;

    [Header("Components")]
    [SerializeField] private Rigidbody motorcycleRigidbody;

    [Header("Movement Settings")]
    private Vector3 direction;

    [SerializeField] private float motorForce;

    public float maxVeloctiy;
    [SerializeField] private float currentVelocity; 

    private float currentSteerAngle;
    [SerializeField] private float maxSteerAngle;

    private bool isBreaking = false;
    [SerializeField] private float brakeForce;
    private float currentBrakeForce = 0f;

    [Header("Wheel Objects")]
    [SerializeField] private Transform fWheelTransform;
    [SerializeField] private Transform rWheelTransform;

    [SerializeField] private WheelCollider fWheelCollider;
    [SerializeField] private WheelCollider rWheelCollider;

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
        direction = actions.MotorcycleInputs.Direction.ReadValue<Vector2>();


    }

    void FixedUpdate() {
        HandleMotor();
        HandleSteering();
    }

    void HandleMotor()
    {
        rWheelCollider.motorTorque = direction.y * motorForce;

        if (isBreaking)
        {
            fWheelCollider.brakeTorque = currentBrakeForce;
            rWheelCollider.brakeTorque = currentBrakeForce;
        }
        else
        {
            fWheelCollider.brakeTorque = 0f;
            rWheelCollider.brakeTorque = 0f;

        }
    }

    void HandleSteering()
    {
        currentSteerAngle = maxSteerAngle * direction.x;

        fWheelCollider.steerAngle = currentSteerAngle;
    }
}
