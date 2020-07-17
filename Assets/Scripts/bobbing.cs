using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bobbing : MonoBehaviour
{
    [SerializeField]
    float frequency = 20f;

    [SerializeField]
    float magnitude = 0.5f;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.localPosition;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}
