
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;   
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(1, 3, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("f"))
        {
            rb.AddForce(0, 500 * Time.deltaTime, 0);
           
        }
        if (Input.GetKey("l"))
        {
            rb.AddForce(0, 2000 * Time.deltaTime, 0);
        }
    }
}
