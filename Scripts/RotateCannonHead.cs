using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCannonHead : MonoBehaviour
{
    Vector3 edge;

    // Start is called before the first frame update
    void Start()
    {
        edge = new Vector3(transform.position.x, transform.position.y, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.RotateAround(edge, Vector3.forward, 1);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.RotateAround(edge, Vector3.forward, -1);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(new Vector3(0, 1, 0), -1);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(new Vector3(0, 1, 0), 1);

    }
}
