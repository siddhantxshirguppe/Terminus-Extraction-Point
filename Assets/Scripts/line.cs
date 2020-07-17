using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
	public bool locked = false;
	private Vector2 initP;
	private Vector2 finalP;

	//public GameObject lr;
	private LineRenderer lr2;
	// Use this for initialization
	void Start()
	{
		lr2 = GetComponent<LineRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			if (!locked)
			{
				initP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				lr2.SetPosition(0, new Vector3(initP.x, initP.y, 1));
				print(initP);
				locked = true;

			}
			else
			{
				finalP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				lr2.SetPosition(1, new Vector3(finalP.x, finalP.y, 1));
				print("Final: " + finalP);
			}

		}
		else
		{
			locked = false;
		}
	}

}