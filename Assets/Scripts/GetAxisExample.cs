using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxisExample : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical"); // * speed * Time.deltaTime;
        Vector3 movement;
        movement.x = x;
        movement.y = 0.0f;
        movement.z = y;

        gameObject.transform.Translate(movement * speed * Time.deltaTime);
    }
}
