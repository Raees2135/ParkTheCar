using UnityEngine;

public class FreeLookCamera : MonoBehaviour
{
    public Transform target; // Reference to the car's transform
    public float distance = 6.0f; // Distance from the car
    public float height = 2.0f; // Height of the camera
    public float rotationDamping = 3.0f; // Damping for camera rotation
    public float heightDamping = 2.0f; // Damping for camera height
    public float rotationSpeed = 3.0f; // Speed of camera rotation with mouse

    private float mouseX; // Mouse input for horizontal rotation

    private void Start()
    {
        
    }

    private void LateUpdate()
    {
        if (!target)
            return;

        // Calculate the current rotation angle based on the car's rotation
        var wantedRotationAngle = target.eulerAngles.y + mouseX;
        var wantedHeight = target.position.y + height;

        var currentRotationAngle = transform.eulerAngles.y;
        var currentHeight = transform.position.y;

        // Damp the rotation and height
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        // Convert the angle into a rotation
        var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        // Set the position of the camera
        transform.position = target.position;
        transform.position -= currentRotation * Vector3.forward * distance;

        // Set the height of the camera
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        // Look at the car
        transform.LookAt(target);
    }

    private void Update()
    {
        // Get mouse input for horizontal rotation
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}

