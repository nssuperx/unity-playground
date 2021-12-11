using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [SerializeField] private new Rigidbody rigidbody;
    [SerializeField] private int dragpower = 10;
    [SerializeField] private int jumppower = 10;
    public Vector3 moveforce;
    public bool drag;
    public bool jump;
    

    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (drag)
        {
            rigidbody.drag = dragpower;
        }
        else
        {
            rigidbody.drag = 0;
        }

        if (jump)
        {
            rigidbody.AddForce(0, jumppower, 0, ForceMode.Impulse);
        }
        rigidbody.AddForce(moveforce, ForceMode.Force);
    }

}
