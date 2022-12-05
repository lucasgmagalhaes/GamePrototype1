using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public Vector3 offset = new(0, 5.99f, -7.94f);
    public short camIndex = 1;

    public Quaternion defaultAngle;

    private readonly Dictionary<short, Vector3> offsets = new()
    {
        { 1, new(0, 5.99f, -7.94f) }, // Up vision
        { -1, new(0, 4.41f, -0.2f) }, // Driver vision
    };

    public Camera otherCamera;

    void Start()
    {
        defaultAngle = transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            camIndex *= -1;
            offset = offsets[camIndex];
        }

        if (camIndex == -1)
        {
            transform.rotation = player.transform.rotation;
        }
        else
        {
            transform.rotation = defaultAngle;
        }

        transform.position = player.transform.position + offset;
    }
}
