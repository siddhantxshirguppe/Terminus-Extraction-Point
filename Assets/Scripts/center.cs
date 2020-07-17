using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class center : MonoBehaviour
{
    public GameObject buttons;
    public GameObject E,W,N,S;
    public GameObject astronaut;
    private enum DirectionTypes : int
    {
        N = 1 << 0,
        S = 1 << 1,
        E = 1 << 2,
        W = 1 << 3,
        /*Shorts = 1 << 4,
        PantSuit = 1 << 5,
        Dress = 1 << 6,
        Sunglasses = 1 << 7,
        Earings = 1 << 8,
        Socks = 1 << 9 // Bitshifting :)*/
    }

    private DirectionTypes currentDirection;
    void Start()
    {
        buttons.SetActive(false);

    }

    public void enable_buttons()
    {
        buttons.SetActive(true);
    }

    public void disable_buttons()
    {
        buttons.SetActive(false);
    }

    public void disable_sel()
    {
        currentDirection = 0;
        E.GetComponent<Image>().color = Color.grey;
        W.GetComponent<Image>().color = Color.grey;
        N.GetComponent<Image>().color = Color.grey;
        S.GetComponent<Image>().color = Color.grey;
    }
    public void highlight_E()
    {
        E.GetComponent<Image>().color = Color.red;
        currentDirection = DirectionTypes.E;
    }

    public void highlight_W()
    {
        W.GetComponent<Image>().color = Color.red;
        currentDirection = DirectionTypes.W;
    }
    public void highlight_N()
    {
        N.GetComponent<Image>().color = Color.red;
        currentDirection = DirectionTypes.N;
    }
    public void highlight_S()
    {
        S.GetComponent<Image>().color = Color.red;
        currentDirection = DirectionTypes.S;
    }

    public void action()
    {
        if(currentDirection == DirectionTypes.S)
        {
            Debug.Log("going south");
        }
        else if (currentDirection == DirectionTypes.N)
        {
            Debug.Log("going north");
        }
        else if (currentDirection == DirectionTypes.E)
        {
            Debug.Log("going east");
        }
        else if (currentDirection == DirectionTypes.W)
        {
            Debug.Log("going west");
        }
        else
        {
            Debug.Log("no direction selected");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private bool HasFlag(DirectionTypes flags)
    {
        return (currentDirection & flags) != 0;
    }

    private void SetFlag(DirectionTypes flags, bool val)
    {
        if (val == true)
        {
            currentDirection |= flags;
        }
    }

}
