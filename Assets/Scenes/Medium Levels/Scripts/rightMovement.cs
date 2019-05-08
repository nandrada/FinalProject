using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool left, right;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        right = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (right && !left)
        {
            transform.Translate(Vector3.right * Time.fixedDeltaTime * speed);
        }
        else if (left && !right)
        {
            transform.Translate(Vector3.left * Time.fixedDeltaTime * speed);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "left wall")
        {
            right = true;
            left = false;
        }
        if (collision.gameObject.tag == "right wall")
        {
            left = true;
            right = false;
        }
    }
}
