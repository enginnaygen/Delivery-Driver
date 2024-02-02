using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 0.1f;
    [SerializeField]float moveSpeed = 0.1f;
    [SerializeField] float boostSpeed = 20;
    [SerializeField] float bumpSpeed = 5;



    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float steerAmount = Input.GetAxis("Horizontal")*steerSpeed* Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Boost")
        {
            moveSpeed = boostSpeed;
        }
        if(collision.tag=="Slow")
        {
            moveSpeed = bumpSpeed;
        }
    }
}
