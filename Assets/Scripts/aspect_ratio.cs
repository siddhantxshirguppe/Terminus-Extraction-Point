using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aspect_ratio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.orthographicSize = (20.0f / Screen.width * Screen.height / 2.0f);

    }
}
