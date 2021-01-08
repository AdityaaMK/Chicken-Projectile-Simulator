using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHinge : MonoBehaviour
{
    Vector3 edge;
    float pivotAxis;

    // Start is called before the first frame update
    void Start()
    {
        pivotAxis = (float)(transform.position.y - .5 * transform.localScale.y);
        edge = new Vector3(transform.position.x, pivotAxis, transform.position.z);
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
            transform.Rotate(edge, -1);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(edge, 1);

    }
}