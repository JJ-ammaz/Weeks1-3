using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public bool Flipped = true;
    // public float startl = topr.x * 1.5;
    //public float startr;
    Vector2 bottoml;
    Vector2 topr;
   // Vector2 startr;
   // float Screenr = Screen.width * 1.5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = UnityEngine.Random.Range(4,6);
            //range so that it isnt always the same
        topr = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width + 150, Screen.height));
        bottoml = Camera.main.ScreenToWorldPoint(new Vector2(-150, 0));
        // startl = new Vector2(-2, -2);
        // startr = new Vector2(Screen.width *1.5,Screen.height);
        
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
        if (screenPos.x < Screen.width * -1.5)
        {
            newPosition.x = bottoml.x;
            speed = speed * -1;
            Flipped = true;
        }

        if (screenPos.x > Screen.width * 1.5)
        {
            newPosition.x = topr.x;
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
