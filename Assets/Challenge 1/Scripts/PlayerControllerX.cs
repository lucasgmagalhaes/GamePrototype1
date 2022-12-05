using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    public GameObject propeller;

    private float SPINS_PER_SECOND = 40;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        // 
        propeller.transform.Rotate(0, 0, 360 * SPINS_PER_SECOND * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(rotationSpeed * Time.deltaTime * verticalInput * Vector3.right);
    }
}
