using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public int slotId;          //���� ��ȣ
    public int itemId;          //������ ��ȣ

    // Start is called before the first frame update
    public void InitDummy(int slotId, int itemId)
    {
        this.slotId = slotId;
        this.itemId = itemId;
    }
}
