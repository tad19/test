using UnityEngine;

public class VehicleController : MonoBehaviour
{
public float speed = 100.0f;
public float turnSpeed = 100.0f;

private void FixedUpdate()
{
float move = Input.GetAxis("Vertical") * speed;
float turn = Input.GetAxis("Horizontal") * turnSpeed;

GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * move);
GetComponent<Rigidbody>().AddRelativeTorque(Vector3.up * turn);
}
}