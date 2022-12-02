using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    
    public float horizontalInput = 0;
    private float verticalInput = 0;

    public float rotateDelta = 40;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(speed * Time.deltaTime * verticalInput * Vector3.forward);
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
        // Not good but works
        transform.Rotate(Vector3.forward, CalcMaxInclination());
    }

    private float CalcMaxInclination()
    {
        var inclination = horizontalInput * Time.deltaTime * rotateDelta;
        if (inclination > 5) return 5;
        if (inclination < -6) return -6;
        return inclination;
    }
}
