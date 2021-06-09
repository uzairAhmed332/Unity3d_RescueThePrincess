using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardMonitor : MonoBehaviour
{
	public static int RewardValue;
	public int InternalReward;
	//public GameObject Reward1;
	public TMPro.TextMeshProUGUI rewardText;


	void Start()
	{
		RewardValue = 0;
	}


	void Update()
	{
		InternalReward = RewardValue;
        rewardText.text = InternalReward.ToString();
		//if (HealthValue == 1)
		//Heart1.SetActive(true);



	}
}
