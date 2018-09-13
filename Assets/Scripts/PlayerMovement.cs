using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Call Rigidbody component 
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Call FixedUpdate instead of Update
    // We dont want to mess with physics
    void FixedUpdate ()
    {
        //Add a forward force that can be changed in Unity IDE
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
