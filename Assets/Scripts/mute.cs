using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mute : MonoBehaviour
{

    public Toggle mutebutt;
    public AudioSource asrc;
    // Start is called before the first frame update
    void Start()
    {
        

        mutebutt.onValueChanged.AddListener(delegate {
            ToggleValueChanged(mutebutt);
        });
            
    }

    void ToggleValueChanged(Toggle change)
    {
        asrc = GameObject.FindGameObjectWithTag("bgm").GetComponent<AudioSource>();

        if (mutebutt.isOn)
        {
            asrc.Play();
        }
        else
        {
            asrc.Pause();
        }
    }


}
