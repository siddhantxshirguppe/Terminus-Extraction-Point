using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levels : MonoBehaviour
{
    // Start is called before the first frame update
    public int limit_lvl;
    public Button[] lvlbuttons;
    void Start()
    {
        int lvlAt = PlayerPrefs.GetInt("levelat", limit_lvl);

        for(int i =1;i<=lvlbuttons.Length;i++)
        {
            if(i>lvlAt)
            {
                lvlbuttons[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
