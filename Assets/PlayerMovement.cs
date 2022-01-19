using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to that one rigid body component called rb
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // FixedUpdate becauseu physics LOL
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
