using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public bool left, right;

    private IEnumerator coroutine;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        left = true;

        //coroutine = WaitAndPrint(2.0f);
        //StartCoroutine(coroutine);

        //print("Before WaitAndPrint Finishes " + Time.time);
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

    //private IEnumerator WaitAndPrint(float waitTime)
    //{
    //    right = true;
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(waitTime);
    //        print("WaitAndPrint " + Time.time);
    //    }
    //}

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
