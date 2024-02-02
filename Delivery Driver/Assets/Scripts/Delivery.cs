using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Transform deliveryLocation;
    bool _hasPackage;
    SpriteRenderer _sprRen;


    private void Start()
    {
        _sprRen = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit!!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       

        if (collision.tag=="Package"&& !_hasPackage)
        {
            Debug.Log("Package Picked up");
            Debug.Log("Delivery Location" + deliveryLocation.transform.position);
            _hasPackage = true;
            collision.gameObject.SetActive(false);
            _sprRen.color = Color.green;
        }
        if (collision.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Package delivered");
            _hasPackage = false;
            _sprRen.color = Color.white;


        }
    }


}
