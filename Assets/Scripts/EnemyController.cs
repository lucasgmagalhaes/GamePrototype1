using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float speed = 40f;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
