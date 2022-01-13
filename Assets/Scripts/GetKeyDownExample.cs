using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyDownExample : MonoBehaviour
{
    public int speed = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward * speed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * speed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * speed);
        }
    }
}
