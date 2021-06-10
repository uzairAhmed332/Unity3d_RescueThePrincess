using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCQuest : MonoBehaviour
{
	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ThePlayer;
	public GameObject TextBox;
	public GameObject NPCName;
	public GameObject NPCText;


	void Update()
	{
		TheDistance = PrinceCasting.DistanceFromTarget;
		print("check00");
	}

	void OnMouseOver()
	{
		print("check0");
		if (TheDistance <= 3)
		{
			print("check1");
			//ToDo
			//	AttackBlocker.BlockSword = 1;  
			ActionText.GetComponent<Text>().text = "Press [ v ] to Talk";
			ActionDisplay.SetActive(true);
			ActionText.SetActive(true);
		}

		if (Input.GetButtonDown("Action"))
		{
			if (TheDistance <= 5)
			{    //ToDo
				 //AttackBlocker.BlockSword = 2;
				Screen.lockCursor = false;
				Cursor.visible = true;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				//ThePlayer.SetActive (false);
				StartCoroutine(NPC01Active());
			}
		}
	}



	void OnMouseExit()
	{
		//Todo
		//AttackBlocker.BlockSword = 0;
		ActionDisplay.SetActive(false);
		ActionText.SetActive(false);
	}

	IEnumerator NPC01Active()
	{
		TextBox.SetActive(true);
		NPCName.GetComponent<Text>().text = "NPC";
		NPCName.SetActive(true);
		NPCText.GetComponent<Text>().text = "Hello friend, you must find sword to rescue to princess";
		NPCText.SetActive(true);
		yield return new WaitForSeconds(5.5f);
		NPCName.SetActive(false);
		NPCText.SetActive(false);
		TextBox.SetActive(false);
		ActionDisplay.SetActive(true);
		ActionText.SetActive(true);

	}

}