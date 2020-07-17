using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    public GameObject dot;
    public GameObject menuButt;
    void Start()
    {
        menuButt.SetActive(false);
        StartCoroutine(ScaleOverTime(60));
        StartCoroutine(showButt());
        GameObject.Destroy(GameObject.FindGameObjectWithTag("bgm"));
        PlayerPrefs.SetInt("levelat", 25);

    }

    // Update is called once per frame
    void Update()
    {
        
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

    IEnumerator showButt()
    {
     

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(18);
        menuButt.SetActive(true);

    }
}
