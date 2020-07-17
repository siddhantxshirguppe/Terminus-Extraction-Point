using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystal : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject crysmtr0, crysmtr1, crysmtr2;
    public GameObject crys0, crys1, crys2;
    public GameObject poofbody;
    AudioSource src;
    public AudioClip blast;
    ParticleSystem poof;
    Color32  purple = new Color32(106, 11, 92, 255);
    travel trvl;
    public bool allCrys = false;
   
    void Start()
    {
        poof = poofbody.GetComponent<ParticleSystem>();
        src = gameObject.GetComponent<AudioSource>();
        trvl = this.GetComponent<travel>();
        poof.startColor = purple;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerStay2D(Collider2D other)
    {
      

        if (other.tag == "crystal0" && !trvl.start_lerp)
        {
            
            
                crysmtr0.SetActive(true);
                GameObject.Destroy(crys0);
                poof.Play();
                src.PlayOneShot(blast, 1f);
               
            if(crysmtr0.active && crysmtr1.active && crysmtr2.active)
            {
                allCrys = true;
            }
         
        }
        else if (other.tag == "crystal1" && !trvl.start_lerp)
        {


            crysmtr1.SetActive(true);
            GameObject.Destroy(crys1);
            poof.Play();
            src.PlayOneShot(blast, 1f);

            if (crysmtr0.active && crysmtr1.active && crysmtr2.active)
            {
                allCrys = true;
            }


        }
        else if (other.tag == "crystal2" && !trvl.start_lerp)
        {


            crysmtr2.SetActive(true);
            GameObject.Destroy(crys2);
            poof.Play();
            src.PlayOneShot(blast, 1f);

            if (crysmtr0.active && crysmtr1.active && crysmtr2.active)
            {
                allCrys = true;
            }


        }

    }
}
