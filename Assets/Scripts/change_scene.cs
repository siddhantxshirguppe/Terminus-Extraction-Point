using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class change_scene : MonoBehaviour
{

    public float fadeTime = 5f;
    public Color bgColor = Color.white;
    AudioSource src,bgm;
    public AudioClip sel;
    public GameObject level_txt;

    

    // Start is called before the first frame update
    void Start()
    {
        if(level_txt != null)
        {
            level_txt.GetComponent<Text>().text = SceneManager.GetActiveScene().buildIndex + "";
        }
       
        GameObject bg = GameObject.FindGameObjectWithTag("bgm");
        if(bgm != null)
        {
            bgm = bg.GetComponent<AudioSource>();
        }
     
        src = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gotoTutorial()
    {

        src.PlayOneShot(sel,1f);
        Initiate.Fade("tutorial", bgColor, fadeTime);
    }

    public void quit()
    {

        src.PlayOneShot(sel, 1f);
        Application.Quit();
    }
    public void gotoLevels()
    {
        if (PlayerPrefs.GetInt("tutdone") == 0)
        {
            PlayerPrefs.SetInt("tutdone", 1);
            src.PlayOneShot(sel, 1f);
            Initiate.Fade("tutorial", bgColor, fadeTime);

        }
        else
        {
            PlayerPrefs.SetInt("tutdone", 1);
            src.PlayOneShot(sel, 1f);
            Initiate.Fade("level_list", bgColor, fadeTime);

        }

    
    }

    public void gotoMenu()
    {
        src.PlayOneShot(sel, 1f);
        Initiate.Fade("menu", bgColor, fadeTime);
    }

    public void gotoAbout()
    {
        src.PlayOneShot(sel, 1f);
        Initiate.Fade("about", bgColor, fadeTime);
    }

  

    public void reload()
    {
        src.PlayOneShot(sel, 1f);
        Scene scene = SceneManager.GetActiveScene();
        Initiate.Fade(scene.name, bgColor, fadeTime);
    }

    public void gotoLvl01()
    {
        src.PlayOneShot(sel, 1f);
        Initiate.Fade("1", bgColor, fadeTime);

    }

    public void gotoLvl02()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("2", bgColor, fadeTime);
    }
    public void gotoLvl03()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("3", bgColor, fadeTime);
    }
    public void gotoLvl04()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("4", bgColor, fadeTime);
    }
    public void gotoLvl05()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("5", bgColor, fadeTime);
    }
    public void gotoLvl06()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("6", bgColor, fadeTime);
    }
    public void gotoLvl07()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("7", bgColor, fadeTime);
    }
    public void gotoLvl08()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("8", bgColor, fadeTime);
    }
    public void gotoLvl09()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("9", bgColor, fadeTime);

    }
    public void gotoLvl10()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("10", bgColor, fadeTime);

    }
    public void gotoLvl11()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("11", bgColor, fadeTime);

    }

    public void gotoLvl12()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("21", bgColor, fadeTime);

    }
    public void gotoLvl13()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("13", bgColor, fadeTime);

    }
    public void gotoLvl14()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("14", bgColor, fadeTime);

    }

    public void gotoLvl15()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("15", bgColor, fadeTime);

    }

    public void gotoLvl16()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("16", bgColor, fadeTime);

    }
    public void gotoLvl17()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("17", bgColor, fadeTime);

    }
    public void gotoLvl18()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("18", bgColor, fadeTime);

    }
    public void gotoLvl19()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("19", bgColor, fadeTime);

    }
    public void gotoLvl20()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("20", bgColor, fadeTime);

    }
    public void gotoLvl21()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("21", bgColor, fadeTime);

    }
    public void gotoLvl22()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("22", bgColor, fadeTime);

    }
    public void gotoLvl23()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("23", bgColor, fadeTime);

    }
    public void gotoLvl24()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("24", bgColor, fadeTime);

    }
    public void gotoLvl25()
    {

        src.PlayOneShot(sel, 1f);
        Initiate.Fade("25", bgColor, fadeTime);

    }
}
