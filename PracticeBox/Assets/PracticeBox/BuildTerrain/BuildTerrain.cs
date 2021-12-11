using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTerrain : MonoBehaviour
{
    //private Material[] _material;

    // Use this for initialization
    void Start()
    {
        Terrain();
    }


    private void Terrain()
    {
        GameObject gameObject = (GameObject)Resources.Load("Terrain");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if(Random.Range(0, 10) < 2)
                {
                    Instantiate(gameObject, new Vector3Int(i, 1, j), Quaternion.identity);
                }
                Instantiate(gameObject, new Vector3Int(i, 1, j), Quaternion.identity);
            }
        }
        Debug.Log("ok");
        return;
    }
}
