using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class measure : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject tape0 , tape1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(tape0.transform.position, tape1.transform.position));
    }
}
