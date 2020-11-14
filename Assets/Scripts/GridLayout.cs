using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridLayout : MonoBehaviour
{

    public GameObject tile;

    void Start()
    {
        GameManager.grid = this;
        GameObject clone;
        for (int i = 0; i < 64; i++)
        {
           clone =  Instantiate(tile, new Vector3(0, 0, 0), Quaternion.identity);
           clone.transform.SetParent(this.gameObject.transform, false);
        }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
