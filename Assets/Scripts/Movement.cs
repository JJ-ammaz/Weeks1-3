using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public bool Flipped = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rotation
        Vector3 newRotation = transform.eulerAngles;
        transform.eulerAngles = newRotation;


        //movement
        Vector3 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        //movement if's
        if (screenPos.x < 0)
        {
            speed = speed * -1;
            Flipped = true;
        }

        if (screenPos.x > Screen.width)
        {
            speed = speed * -1;
            Flipped = false;
        }

        //rotation/flips if's

        if (Flipped == true)
        {
            print("hello world");
        }


    }
}
