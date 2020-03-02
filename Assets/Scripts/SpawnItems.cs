using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject[] objects;
    public float time = 0;

    // Update is called once per frame
    void Update()
    {
        time = time + 1 * Time.deltaTime;
        if (time > 0.5f)
        {
            Instantiate(objects[Random.Range(0,9)], new Vector2(Random.Range(-10f,10),10), transform.rotation);
            time = 0;
        }
    }
}
