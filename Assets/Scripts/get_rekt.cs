using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class get_rekt : MonoBehaviour
{
    public GameObject boombody,astro_body;
    ParticleSystem boom;
    AudioSource src;
    public AudioClip blast;


    // Start is called before the first frame update
    void Start()
    {
        
        boom = boombody.GetComponent<ParticleSystem>();
        src = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("boundary hit!");
        
        if (other.tag == "boundary")
        {
            
            boom.Play();
            Destroy(astro_body);
            src.PlayOneShot(blast, 1f);
            Scene scene = SceneManager.GetActiveScene();
            Initiate.Fade(scene.name, Color.black, 1f);



        }
            
        }
        
            
    }


  




