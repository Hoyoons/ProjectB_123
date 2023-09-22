using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public int slotId;          //슬롯 번호
    public int itemId;          //아이템 번호

    // Start is called before the first frame update
    public void InitDummy(int slotId, int itemId)
    {
        this.slotId = slotId;
        this.itemId = itemId;
    }
}
