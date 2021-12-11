using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour
{
    private Collider coll;
    float distance = 100;
    float duration = 3;

    // Use this for initialization
    void Start()
    {
        coll = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.red, duration, false);
            RaycastHit hit;
            if (coll.Raycast(ray, out hit, 100.0F))
            {
                Debug.Log("ok");
            }
            else
            {
                Debug.Log("あたってない");
            }
        }
    }
}

