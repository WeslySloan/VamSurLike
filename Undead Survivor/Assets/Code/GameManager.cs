using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static으로 선언한 변수는 인스펙터에 표시되지 않음
    public static GameManager instance;
    public Player player;

    private void Awake()
    {
        instance = this;
    }
}
