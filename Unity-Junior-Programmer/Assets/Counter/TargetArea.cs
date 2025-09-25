using UnityEngine;

public class TargetArea : MonoBehaviour
{
    [SerializeField] private int value;
    private Counter counter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        counter = GameObject.Find("Counter").GetComponent<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        counter.AddCount(value);
    }
}
