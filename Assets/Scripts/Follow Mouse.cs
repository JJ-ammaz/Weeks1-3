using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseP = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mouseP.z = 0;
        transform.position = mouseP;
    }
}
