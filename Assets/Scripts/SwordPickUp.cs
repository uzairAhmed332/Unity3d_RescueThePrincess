using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordPickUp : MonoBehaviour
{
    public float TheDistance;
	public GameObject ActionText;
	public GameObject FakeSword;
	public GameObject RealSword;

	void Update()
	{
		TheDistance = PrinceCasting.DistanceFromTarget;
	}

	void OnMouseOver()
	{
	
		if (TheDistance <= 5)
		{
			ActionText.GetComponent<Text>().text= "Press [P] to pick the Sword!";
			ActionText.SetActive(true);
		}

		if (Input.GetButtonDown("Pick"))
		{
			if (TheDistance <= 5)
			{   
				transform.position = new Vector3(0f, 0f, 0f);
				RealSword.SetActive(true);
				FakeSword.SetActive(false);

				ActionText.SetActive(false);
			}
		}
	}

 //   private void OnMouseExit()
 //   {
 //       ActionText.GetComponent<Text>().text = "";
	//	//ActionDisplay.SetActive(false);
	//	ActionText.SetActive(false);
	//}

    //   private void OnMouseDown()
    //   {
    //	if (TheDistance <= 5)
    //	{
    //		transform.position = new Vector3(0f, 0f, 0f);
    //		RealSword.SetActive(true);
    //		FakeSword.SetActive(false);

    //	}
    //}

}
