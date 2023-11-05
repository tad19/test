using System;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public WheelCollider frontLeftWheel;
    public WheelCollider frontRightWheel;
    public WheelCollider rearLeftWheel;
    public WheelCollider rearRightWheel;

    
    
public float moveSpeed = 10.0f;        // Adjust the speed as needed
    public float rotationSpeed = 100.0f;   // Adjust the rotation speed as needed
    private Rigidbody rb;
    private float gasInput = 0.0f;        // Gas input value (0 to 1)
    private float steeringInput = 0.0f;   // Steering input value (-1 to 1)

    
    public Button gasButton;
    public Button brakeButton;
    public Button leftButton;
    public Button rightButton;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Add listeners to the buttons
        gasButton.onClick.AddListener(OnGasButtonClicked);
        brakeButton.onClick.AddListener(OnBrakeButtonClicked);
        leftButton.onClick.AddListener(OnLeftButtonClicked);
        rightButton.onClick.AddListener(OnRightButtonClicked);
    }

    

    public void OnGasButtonClicked()
    {
        if( gasInput==-1.0f){
            gasInput= 0.0f;
        }
        else{
            gasInput=1.0f;
        }
    }

    public void OnBrakeButtonClicked()
    {
        if( gasInput==1.0f){
            gasInput= 0.0f;
        }
        else{
            gasInput=-1.0f;
        }
    }

    public void OnLeftButtonClicked()
    {
        if(steeringInput == 1.0f){
            steeringInput=0.0f;
        }
        else{
            steeringInput=-1.0f;
        }
    }

    public void OnRightButtonClicked()
    {
        if(steeringInput == -1.0f){
            steeringInput=0.0f;
        }
        else{
            steeringInput=1.0f;
        }
    }

    private void Update()
    {
        
        // Calculate the forward and backward movement
        float moveDirection = Mathf.Sign(gasInput);
        float moveAmount = Mathf.Abs(gasInput) * moveSpeed * moveDirection;

        // Calculate the rotation
        float rotationAmount = steeringInput * rotationSpeed * Time.deltaTime;

        // Apply the movement and rotation
        Vector3 movement = transform.forward * moveAmount;
        rb.velocity = movement;
        transform.Rotate(Vector3.up * rotationAmount);

    
    }
}
   
