using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float spinSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
    }
}
