using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySelect : MonoBehaviour
{
    public GameObject TheSword;
    public GameObject InventoryPanel;
    public GameObject ItemEquipped;

    public void ItemTake() {
        TheSword.SetActive(true);
        ItemEquipped.SetActive(true);
    }


    public void ItemCancel()
    {
        InventoryPanel.SetActive(false);
    }
}
