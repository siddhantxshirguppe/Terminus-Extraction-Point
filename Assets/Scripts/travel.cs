using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class travel: MonoBehaviour
{
    AudioSource src;
    public AudioClip jet,empty;

    public float deg, transitionSpeed;
    Vector2 direction;
    public bool start_lerp=false;
    Vector2 start, stop;
    public int power;
    change_object co;
    public GameObject low_cnto, mid_cnto, high_cnto;
    public GameObject controls;
    public int low_cnt, mid_cnt, high_cnt;
    public GameObject thruster;
    ParticleSystem thrustSys;
    Color dark_red;



    // Movement speed in units per second.
    public float speed = 1.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    public void setangle()
    {
        float rad = deg * Mathf.Deg2Rad;
        direction = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));

    }

    public void setpower()
    {
        if(co.t0.isOn)
        {
            power = 1;
        }
        else if(co.t1.isOn)
        {
            power = 2;
        }
        else if(co.t2.isOn)
        {
            power = 3;
        }

    }
    public void north()
    {
        deg = 90;
        thrust();
    }
    public void south()
    {
        deg = -90;
        thrust();
    }
    public void right_upper()
    {
        deg = 30;
        thrust();
    }
    public void right_lower()
    {
        deg = -30;
        thrust();
    }
    public void left_upper()
    {
        deg = 150;
        thrust();
    }
    public void left_lower()
    {
        deg = -150;
        thrust();
    }

    void reduce_cnt(int x)
    {
        if(x == 1)
        {
            low_cnt--;
            if(low_cnt == 0 )
            {
                low_cnto.GetComponent<Text>().color = dark_red;
            }
        }
        else if(x == 2)
        {
            mid_cnt--;
            if (mid_cnt == 0)
            {
                mid_cnto.GetComponent<Text>().color = dark_red;
            }
        }
        else if(x == 3)
        {
            high_cnt--;
            if (high_cnt == 0)
            {
                high_cnto.GetComponent<Text>().color = dark_red;
            }
        }
    }

    void update_count()
    {
        low_cnto.GetComponent<Text>().text = "x" + low_cnt;
        mid_cnto.GetComponent<Text>().text = "x" + mid_cnt;
        high_cnto.GetComponent<Text>().text = "x" + high_cnt;
    }

    bool validate_power()
    {
        if((power == 1 && low_cnt == 0) || (power == 2 && mid_cnt == 0) || (power == 3 && high_cnt == 0))
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }
    public void thrust()
    {
        
        setpower();
        setangle();
        if(validate_power())
        {
            src.PlayOneShot(jet, 0.5f);
            Debug.Log("calling move func");
            start = this.transform.position;
            stop = (Vector2)transform.position + direction.normalized * 0.5f * power;
            Debug.Log("dis between start astop :" + Vector3.Distance(transform.position, (Vector2)transform.position + direction.normalized));
            start_lerp = true;
            thrustSys = thruster.GetComponent<ParticleSystem>();
            thruster.transform.rotation = Quaternion.LookRotation(-direction);
            thrustSys.GetComponent<ParticleSystem>().Play();
            thrustSys.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(StopParticleSystem(thrustSys, 1));

            reduce_cnt(power);
            update_count();
        }
        else
        {
            src.PlayOneShot(empty, 1f);
        }
     

    }

    IEnumerator StopParticleSystem(ParticleSystem particleSystem, float time)
    {
        yield return new WaitForSeconds(time);
        particleSystem.Stop();
    }
    // Update is called once per frame
    void Update()
    {

       
        if (start_lerp)
        {
            controls.SetActive(false);
            transform.position = Vector3.Lerp(transform.position, stop, Time.deltaTime*10f);
            if((Vector2)transform.position == stop)
            {
                controls.SetActive(true);
                start_lerp = false;
             
            }

        }
        

    }

    void Start()
    {
        dark_red = new Color32(173,16,16,255);
        src = gameObject.GetComponent<AudioSource>();
        co = this.GetComponent<change_object>();
        low_cnto.GetComponent<Text>().text = "x" + low_cnt;
        mid_cnto.GetComponent<Text>().text = "x" + mid_cnt;
        high_cnto.GetComponent<Text>().text = "x" + high_cnt;




    }
}
