using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenRotate : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.AddRelativeForce(new Vector3(0, 0, 20), ForceMode.Impulse);
        float rand = Random.Range(-3, 3);
        float rand2 = Random.Range(-3, 3);
        float rand3 = Random.Range(-3, 3);
        rb.AddTorque(rand, rand2, rand3, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

    }
}
