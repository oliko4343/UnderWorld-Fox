using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SecretWay : MonoBehaviour
{
    private Tilemap theTilemap;

    // Start is called before the first frame update
    void Start()
    {
        theTilemap = gameObject.GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            theTilemap.color = new Color(theTilemap.color.r, theTilemap.color.g, theTilemap.color.b, 0.5f);

             //0.5 to make it transparent or 0 to make it dissapear 

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            theTilemap.color = new Color(theTilemap.color.r, theTilemap.color.g, theTilemap.color.b, 1f);

        }
    }
}
