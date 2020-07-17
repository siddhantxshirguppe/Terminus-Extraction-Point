using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "clockwise")
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * 25);
        }
        else if(gameObject.tag == "aclockwise")
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * 25*-1);
        }
    }
}
