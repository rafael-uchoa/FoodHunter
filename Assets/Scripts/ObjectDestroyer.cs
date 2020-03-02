using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Destrói itens quando chegam fora do mapa
    private void OnTriggerEnter2D(Collider2D collision2d)
    {
        switch (collision2d.tag)
        {
            case "Point":
                DestroyObject(collision2d.gameObject);
                break;
            case "Damage":
                DestroyObject(collision2d.gameObject);
                break;
            case "Life":
                DestroyObject(collision2d.gameObject);
                break;
        }
    }
}
