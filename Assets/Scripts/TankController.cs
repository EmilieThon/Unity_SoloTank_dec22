using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class TankController : BaseController
{

    [SerializeField] private float speed = 20f;
    [SerializeField] private float rotateSpeed = 100f;

    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        Moove();

    }

    private void Moove()

    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, rotateSpeed * horizontalInput * Time.deltaTime);
    }




}
