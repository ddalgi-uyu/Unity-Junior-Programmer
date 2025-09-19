using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizentalInput;
    private float fowardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizentalInput = Input.GetAxis("Horizental");
        fowardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizentalInput);
    }
}
