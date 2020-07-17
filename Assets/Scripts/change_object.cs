using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_object : MonoBehaviour
{

public GameObject spannertog;
public GameObject foodtog;
public GameObject cylindertog;
public Toggle t0, t1, t2;
    AudioSource src;
    public AudioClip sel;


    // Start is called before the first frame update
    void Start()
    {
        src = gameObject.GetComponent<AudioSource>();

        t0 = spannertog.GetComponent<Toggle>();
        t1 = foodtog.GetComponent<Toggle>();
        t2 = cylindertog.GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, to take action
        t0.onValueChanged.AddListener(delegate {
            Debug.Log("t0 ->" + t0.isOn);
            if(t0.isOn)
            {
                src.PlayOneShot(sel, 1f);
            }
            
        });
        t1.onValueChanged.AddListener(delegate {
            Debug.Log("t1 ->" + t1.isOn);
            if (t1.isOn)
            {
                src.PlayOneShot(sel, 1f);
            }
        });
        t2.onValueChanged.AddListener(delegate {
            Debug.Log("t2 ->" + t2.isOn);
            if (t2.isOn)
            {
                src.PlayOneShot(sel, 1f);
            }
        });

        

    }

    // Update is called once per frame
    void Update()
    {
    }
}
