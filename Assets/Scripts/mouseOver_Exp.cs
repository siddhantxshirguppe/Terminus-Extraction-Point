using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;

public class mouseOver_Exp : MonoBehaviour
{
    public GameObject N, S, LL, LU, RL, RU;
    public GameObject joyBg;
    public int sector = -1;

    AudioSource src;
    public AudioClip choose;
    bool[] taglist = new bool[6];

    press_release pr;


    // Start is called before the first frame update
    void Start()
    {
        setFalse();
        src = gameObject.GetComponent<AudioSource>();
        pr = joyBg.GetComponent<press_release>();
        for (int i = 0; i < 6; i++)
        {
                taglist[i] = true;
        }

    }

    void resetBool(int exc)
    {
        for(int i =0; i<6;i++)
        {
            if(i !=exc)
            taglist[i] = true;
        }
    }

// Update is called once per frame
    void Update()
    {
    var dir = Input.mousePosition - (transform.position);
    var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg+0;   
    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
     
        if(0 <= angle && angle <60)
        {
            
            setFalse();
            RU.SetActive(true);
            sector = 0;
            resetBool(sector);
            if (taglist[sector] && joyBg.active && !pr.inside)
            {
                src.PlayOneShot(choose, 0.5f);
                taglist[sector] = false;
            }
            
        }

        if (60 <= angle && angle < 120)
        {
        
            setFalse();
            N.SetActive(true);
            sector = 1;
            resetBool(sector);
            if (taglist[sector] && joyBg.active && !pr.inside)
            {
                src.PlayOneShot(choose, 0.5f);
                taglist[sector] = false;
            }
        }
        if (120 <= angle && angle < 180)
        {
            
            setFalse();
            LU.SetActive(true);
            sector = 2;
            resetBool(sector);
            if (taglist[sector] && joyBg.active && !pr.inside)
            {
                src.PlayOneShot(choose, 0.5f);
                taglist[sector] = false;
            }
        }

        if (-60 <= angle && angle < 0)
        {
            
            setFalse();
            RL.SetActive(true);
            sector = 3;
            resetBool(sector);
            if (taglist[sector] && joyBg.active && !pr.inside)
            {
                src.PlayOneShot(choose, 0.5f);
                taglist[sector] = false;
            }
        }

        if (-120 <= angle && angle < -60)
        {
            
            setFalse();
            S.SetActive(true);
            sector = 4;
            resetBool(sector);
            if (taglist[sector] && joyBg.active && !pr.inside)
            {
                src.PlayOneShot(choose, 0.5f);
                taglist[sector] = false;
            }
        }
        if (-180 <= angle && angle < -120)
        {
            
            setFalse();
            LL.SetActive(true);
            sector = 5;
            resetBool(sector);
            if (taglist[sector] && joyBg.active && !pr.inside)
            {
                src.PlayOneShot(choose, 0.5f);
                taglist[sector] = false;
            }
        }

    }

    public void setFalse()
    {
        sector = -1;
        N.SetActive(false);
        S.SetActive(false);
        LL.SetActive(false);
        LU.SetActive(false);
        RL.SetActive(false);
        RU.SetActive(false);
    }
}
