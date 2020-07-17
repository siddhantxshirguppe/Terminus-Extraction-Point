using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class more_button : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pause_panel;
    public GameObject control_pad;
    public GameObject change_scn;
    AudioSource asrc,bgm;
    
    bool isPause;
    void Start()
    {

        isPause = false;
        pause_panel.SetActive(false);
        control_pad.SetActive(false);
        asrc = change_scn.GetComponent<AudioSource>();
    }

  
    public void press_pause()
    {
        asrc.Play();
       
        if(!isPause)
        {
            pause_panel.SetActive(true);
            control_pad.SetActive(true);
            isPause = true;
            
        }
        else
        {
            pause_panel.SetActive(false);
            control_pad.SetActive(false);
            isPause = false;
          
        }
        
    }

   


}
