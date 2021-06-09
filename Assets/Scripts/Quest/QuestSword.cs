using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSword : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	//public GameObject ActionText;
	public GameObject UIQuest;
	public GameObject ThePlayer;
	public GameObject NoticeCam;

	void Update()
	{
		TheDistance = PrinceCasting.DistanceFromTarget;
	}

	void OnMouseOver()
	{
		if (TheDistance <= 3)
		{
			ActionDisplay.SetActive(true);
			//ActionText.SetActive(true);
		}

		if (Input.GetButtonDown("View"))
		{
			if (TheDistance <= 5)
			{
				ActionDisplay.SetActive(false);
				//ActionText.SetActive(false);
				UIQuest.SetActive(true);
				NoticeCam.SetActive(true);
				ThePlayer.SetActive(false);

				DoDelayAction((float)3);
			}
		}
	}

	void OnMouseExit()
	{
		ActionDisplay.SetActive(false);
		//ActionText.SetActive(false);
	}

	void DoDelayAction(float delayTime)
	{
		StartCoroutine(DelayAction(delayTime));
	}

	IEnumerator DelayAction(float delayTime)
	{
		//Wait for the specified delay time before continuing.
		yield return new WaitForSeconds(delayTime);

		//Do the action after the delay time has finished.

		ThePlayer.SetActive(true);
		NoticeCam.SetActive(false);
		UIQuest.SetActive(false);
	}

}
