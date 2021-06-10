using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryOnOff : MonoBehaviour
{
    public GameObject OurInventory;
    public int InvStatus;
  //  public FirstPersonController fpc;
    public GameObject ThePlayer;

    private void Awake()
    {


    }


    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            Debug.Log(Cursor.lockState);
            if (InvStatus == 0)
            {
                InvStatus = 1;

                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                OurInventory.SetActive(true);
            }
            else
            {
                InvStatus = 0;
                ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                OurInventory.SetActive(false);
            }
        }
    }
}
