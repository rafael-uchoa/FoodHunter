using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject[] objetos;
    public float tempo = 0;

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + 1 * Time.deltaTime;
        if (tempo > 0.5f)
        {
            Instantiate(objetos[Random.Range(0,9)], new Vector2(Random.Range(-10f,10),10), transform.rotation);
            tempo = 0;
        }
    }
}
