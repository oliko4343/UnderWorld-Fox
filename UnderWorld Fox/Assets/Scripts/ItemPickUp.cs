using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{

    public GameObject[] weapons;
    public GameObject weaponHere;
    public GameObject explosion;


    // Start is called before the first frame update
    void Start()
    {
        weaponHere = weapons[Random.Range(0, weapons.Length)];
        GetComponent<SpriteRenderer>().sprite = weaponHere.GetComponent<SpriteRenderer>().sprite;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(true);

            Instantiate(explosion, transform.position, transform.rotation);

            

            AudioManager.instance.PlaySFX(3);
        }
    }

}
