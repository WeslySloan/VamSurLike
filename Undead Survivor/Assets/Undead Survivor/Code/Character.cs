using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public static float Speed // 속성값 
    {
        get { return GameManager.instance.playerId == 0 ? 1.1f : 1f; }
    }

    public static float WeaponSpeed 
    {
        get { return GameManager.instance.playerId == 1 ? 1.1f : 1f; }
    }

    public static float WeaponRate
    {
        get { return GameManager.instance.playerId == 1 ? 0.9f : 1f; }
    }

    public static float Damage
    { 
        get { return GameManager.instance.playerId == 2 ? 1.2f : 1f; }   // 2번캐릭터 20% 뎀증
    }

    public static int Count
    {
        get { return GameManager.instance.playerId == 3 ? 1 : 0; } // 3번캐릭터 count추가
    }
}
