using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_over : MonoBehaviour
{
    public GameObject Canvas,hexmap;
    public GameObject dot;
    public GameObject astro_body;
    public GameObject crys_container;
    AudioSource src;
    public AudioClip sel;
    public AudioClip cry_alarm;
    travel trvl;
    crystal cry;

    bool isScaling = false;
    public bool once = false;

    // Start is called before the first frame update
    void Start()
    {
        src = gameObject.GetComponent<AudioSource>();
       trvl = astro_body.GetComponent<travel>();
        cry = astro_body.GetComponent<crystal>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator blink()
    {
        for(int i =0;i<3;i++)
        {
            if(crys_container!=null)
            {
                crys_container.GetComponent<Image>().color = new Color32(172, 16, 16, 255);
                yield return new WaitForSeconds(0.1f);
                crys_container.GetComponent<Image>().color = Color.white;
                yield return new WaitForSeconds(0.1f);
            }
           
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        
        if (astro_body.tag == "Player" && !trvl.start_lerp)
        {
            if(!once)
            {
                if(cry!=null)
                {

                    if (cry.allCrys)
                    {

                        int y = SceneManager.GetActiveScene().buildIndex;
                        if (y + 1 >= PlayerPrefs.GetInt("levelat"))
                        {
                            PlayerPrefs.SetInt("levelat", y + 1);
                        }

                        once = true;
                        src.PlayOneShot(sel, 1f);
                        Debug.Log("collided with astronaut");
                        Canvas.SetActive(false);
                        hexmap.SetActive(false);


                        StartCoroutine(ScaleOverTime(5));

                        Debug.Log("scene number is" + y);
                        Color colr;
                        switch (y)
                        {
                            case 3: colr = new Color(255f, 255f, 255f, 255f); break;
                            case 4: colr = new Color(231f, 38f, 38f, 255f); break;
                            case 5: colr = new Color(235f, 52f, 232f, 255f); break;
                            case 6: colr = new Color(95f, 156f, 52f, 255f); break;

                            default: colr = new Color(255f, 255f, 255f, 255f); break;
                        }
                        Initiate.Fade(y + 1 + "", colr, 0.3f);
                    }
                    else
                    {
                        Debug.Log("get all crystal first!");
                        once = true;

                        src.PlayOneShot(cry_alarm, 1f);
                        StartCoroutine("blink");

                    }

                }
                else
                {
                    int y = SceneManager.GetActiveScene().buildIndex;
                    if (y + 1 >= PlayerPrefs.GetInt("levelat"))
                    {
                        PlayerPrefs.SetInt("levelat", y + 1);
                    }

                    once = true;
                    src.PlayOneShot(sel, 1f);
                    Debug.Log("collided with astronaut");
                    Canvas.SetActive(false);
                    hexmap.SetActive(false);


                    StartCoroutine(ScaleOverTime(5));

                    Debug.Log("scene number is" + y);
                    Color colr;
                    switch (y)
                    {
                        case 3: colr = new Color(255f, 255f, 255f, 255f); break;
                        case 4: colr = new Color(231f, 38f, 38f, 255f); break;
                        case 5: colr = new Color(235f, 52f, 232f, 255f); break;
                        case 6: colr = new Color(95f, 156f, 52f, 255f); break;

                        default: colr = new Color(255f, 255f, 255f, 255f); break;
                    }
                    Initiate.Fade(y + 1 + "", colr, 0.3f);


                }
                
               

            }
            
        }
            
    }

    void OnTriggerExit2D(Collider2D other)
    {
        once = false;
    }

        IEnumerator ScaleOverTime(float time)
    {
        Vector2 originalScale = dot.transform.localScale;
        Vector2 destinationScale = new Vector3(20.0f, 20.0f);

        float currentTime = 0.0f;

        do
        {
            dot.transform.localScale = Vector2.Lerp(originalScale, destinationScale, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;
        } while (currentTime <= time);

        Destroy(gameObject);
    }



}
