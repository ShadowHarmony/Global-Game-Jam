using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Axisx = Input.GetAxisRaw("Horizontal");


        float Axisy = Input.GetAxisRaw("Vertical");



        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            moveSpeed = 5f;

            transform.Translate(new Vector3(Axisx * moveSpeed * Time.deltaTime, 0f));
        }
        else
        if (Axisx > 0.5f || Axisx < -0.5f)

            moveSpeed = 2f;
        transform.Translate(new Vector3(Axisx * moveSpeed * Time.deltaTime, 0f));




        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            moveSpeed = 5f;

            transform.Translate(new Vector3(0f, Axisy * moveSpeed * Time.deltaTime));
        }
        else
        if (Axisy > 0.5f || Axisy < -0.5f)
        {
            moveSpeed = 2f;
            transform.Translate(new Vector3(0f, Axisy * moveSpeed * Time.deltaTime));

        }

    }
}
