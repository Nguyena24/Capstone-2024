using UnityEngine;

public class FrisbeeController : MonoBehaviour
{
    public float initialSpeed = 5.0f;  // Initial speed of the frisbee
    public float windSpeed = 2.0f;     // Wind speed affecting the frisbee
    public float initialAngle = 45.0f; // Angle at which the frisbee begins tilted at (in degrees)
    private float targetTiltAngle = 0.0f; // The angle which the frisbee will always be slowly tilting toward.
    private Vector3 velocity;          // Current velocity of the frisbee
    private float maxHeight = 30.0f; // Maximum height the frisbee can reach
    bool maxedOut = false;




    void Start()
    {
        // Set the initial velocity based on the launch angle
        float launchAngle = 20f;  // Adjust this angle as needed
        float launchAngleRad = launchAngle * Mathf.Deg2Rad;

        // Calculate initial velocity components with tilt adjustment
        float tiltAngleRad = initialAngle * Mathf.Deg2Rad;
        float initialSpeedAdjusted = initialSpeed * Mathf.Cos(tiltAngleRad);
        float vx = initialSpeedAdjusted * Mathf.Cos(launchAngleRad);
        float vy = initialSpeed * Mathf.Sin(tiltAngleRad);
        velocity = new Vector3(initialSpeedAdjusted, vy, 0);
    }

    void Update()
    { 
        // Update the frisbee's position based on the velocity
        transform.position += velocity * Time.deltaTime;

        // Apply wind resistance
        velocity.x -= windSpeed * Mathf.Sign(velocity.x) * Time.deltaTime;

        // Simulate lift force due to wind
        float liftForce = Mathf.Pow(initialSpeed,2)*0.01f/2*windSpeed/2 * Time.deltaTime;
        if (maxedOut == false)
        {
            velocity.y += liftForce;
        }

        // Apply gravity to the frisbee
        velocity.y -= 9.8f * Time.deltaTime;  // Adjust gravity as needed

        //Check if frisbee exceeds a certain height and limit it
        //float maxHeight = initialSpeed / 1.5f;  // Adjust this value as needed
        //if (transform.position.y > maxHeight)
        //{
        //    transform.position = new Vector3(transform.position.x, maxHeight, transform.position.z);
        //    velocity.y = -velocity.y;
        //}

        // Smoothly interpolate the tilt angle towards the target angle
        initialAngle = Mathf.Lerp(initialAngle, targetTiltAngle, 0.15f * Time.deltaTime);

        // Update the frisbee's rotation in the z-direction based on the tilt angle
        transform.rotation = Quaternion.Euler(0, 0, initialAngle);

        // Adjust the sign of liftForce based on the direction of the frisbee
        if (velocity.x < 0)
        {
            liftForce = -liftForce;
        }

        // Check if frisbee exceeds a certain height and limit it
        if (transform.position.y > maxHeight)
        {
            maxedOut = true;
            transform.position = new Vector3(transform.position.x, maxHeight, transform.position.z);
            velocity.y = -velocity.y * 0.01f; // Reverse the vertical velocity and reduce it
        }


        // If the tilt angle is above 45 degrees, gradually increase the target tilt angle towards 90 degrees.
        if (initialAngle > 45)
        {
            targetTiltAngle = 90.0f;
        }

        if (transform.position.y < 0)
        {
            if (velocity.x < 40)
            {
                velocity.x = 0;
                velocity.y = 0;
                velocity.z = 0;
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else
            {
                velocity.x = velocity.x / 3;
                velocity.y = 5;
                transform.rotation = Quaternion.Euler(0, 0, 45.0f);
            }
        }
    }
}