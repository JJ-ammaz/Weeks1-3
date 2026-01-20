using System;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public bool Flipped = true;
    Vector2 bottomleft;
    Vector2 topright;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bottomleft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topright = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        //rotation
 


        //movement
        Vector3 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        //movement if's
        if (screenPos.x < 10)
        {
            newPosition.x = bottomleft.x;
            speed = speed * -1;
            Flipped = true;
        }

        if (screenPos.x > Screen.width)
        {
            newPosition.x = topright.x;
            speed = speed * -1;
            Flipped = true;
        }

        //rotation/flips if's

        if (Flipped == true)
        {
            Flipped = false;
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += 180;
            newRotation.x += 180;
            transform.eulerAngles = newRotation;
            print("hello world");
        }

        transform.position = newPosition;

    }
}
