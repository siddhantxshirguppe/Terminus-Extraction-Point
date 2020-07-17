using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class press_release: MonoBehaviour
{

    AudioSource src;
    public AudioClip press;

    public GameObject arrows,center,astro;
    public bool pressed = false;
    public bool inside = false;
    mouseOver_Exp mex;
    travel tr;
    void Start()
    {
        src = gameObject.GetComponent<AudioSource>();
        mex = center.GetComponent<mouseOver_Exp>();
        tr = astro.GetComponent<travel>();
        this.gameObject.SetActive(false);
        arrows.SetActive(false);
    }

    public void OnPressed()
    {
        Debug.Log("press");
        
        this.gameObject.SetActive(true);
        pressed = true;
        src.PlayOneShot(press, 0.5f);
    }
    public void outBounds()
    {
        inside = false;
        if(pressed)
        {
            arrows.SetActive(true);
        }
    }

    public void inBounds()
    {
         inside = true;
        if (pressed)
        {
            arrows.SetActive(false);
        }
    }

    public void OnReleased()
    {
        if(!inside)
        {
            switch(mex.sector)
            {
                case 0: tr.right_upper(); break;
                case 1: tr.north(); break;
                case 2: tr.left_upper(); break;
                case 3: tr.right_lower(); break;
                case 4: tr.south(); break;
                case 5: tr.left_lower(); break;
                default: Debug.Log("no direction found"); break;

            }
        }
        mex.setFalse();
        this.gameObject.SetActive(false);
        arrows.SetActive(false);
        pressed = false;
    }

}
