using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowChange : MonoBehaviour {

    public Material shadowObject;
    public Color newCol;


    void Start()
    {
        shadowObject.color = Color.white;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (shadowObject.color == Color.white)
            {
                shadowObject.color = Color.black;
            }

            else
            {
                shadowObject.color = Color.white;
            }
        }
    }
}
