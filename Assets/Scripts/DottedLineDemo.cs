using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DottedLineDemo : MonoBehaviour
{
    [Header("Points for line 1")]
    public GameObject center, joy_bg;
    change_object co;
    Vector2 direction;
    mouseOver_Exp moexp;
    travel tr;
    float deg;
    int power;

    void Start()
    {
        moexp = center.GetComponent<mouseOver_Exp>();
        co = this.GetComponent<change_object>();
        tr = this.GetComponent<travel>();
    }

    // Update is called once per frame
    void Update()
    {

        switch(moexp.sector)
        {
            case 0: deg = 30; break;
            case 1: deg = 90; break;
            case 2: deg = 150; break;
            case 3: deg = -30; break;
            case 4: deg = -90; break;
            case 5: deg = -150; break;

        }

        int power = ckpower();
        float rad = deg * Mathf.Deg2Rad;
        direction = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
        //Creating a dotted line
        if(joy_bg.active)
        {
            DottedLine.DottedLine.Instance.DrawDottedLine(this.transform.position, (Vector2)this.transform.position + direction.normalized*0.5f*power);
        }
        
    }


    int ckpower()
    {
        if (co.t0.isOn)
        {
            return 1;
        }
        else if (co.t1.isOn)
        {
            return 2;
        }
        else if (co.t2.isOn)
        {
            return 3;
        }
        else
        {
            return -1;
        }
    }
}
