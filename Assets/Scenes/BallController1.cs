using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField]
    private Transform [] ball;

    private float [] ballSpeed;

    private Vector3 [] originalPosition;
    private Quaternion [] originalRotation;

    // Start is called before the first frame update
    void Start()
    {

        originalPosition = new Vector3[ball.Length];
        originalRotation = new Quaternion[ball.Length];
        ballSpeed = new float[ball.Length];



        for (int i = 0; i < 10; i++)
        {
            originalPosition[i] = ball[i].localPosition;
            //i++ = i + i + 1

        }

 


    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")
        float vertical = Input.GetAxis("vertical")

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        direction = direction * Time.deltaTime * ballSpeed;

        ball.localPosition = ball.localPosition + direction;

        Input.GetButtonDown("Jump")

    }
}
