using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    [SerializeField] private GameObject Cube;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(Cube, new Vector3Int(0, 0, i * 10), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
