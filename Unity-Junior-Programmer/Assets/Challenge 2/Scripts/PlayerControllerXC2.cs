using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerXC2 : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnDelay = 2;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer > spawnDelay)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnDelay = 0;
        }
    }
}
