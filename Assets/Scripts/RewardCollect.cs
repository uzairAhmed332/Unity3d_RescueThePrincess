using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardCollect : MonoBehaviour
{
	public int RotateSpeed;
	public AudioSource CollectSound;
	public GameObject ThisHeart;


	void Update()
	{
		RotateSpeed = 2;
		transform.Rotate(0, RotateSpeed, 0, Space.World);
	}

	//When we collide with heart
	void OnTriggerEnter()
	{
		//Temp
		//CollectSound.Play();

		RewardMonitor.RewardValue += 1;

		// Same as below line: ThisHeart.SetActive(false);
		this.gameObject.SetActive(false);
	}
}
