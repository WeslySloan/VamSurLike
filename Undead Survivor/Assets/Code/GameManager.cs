using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static���� ������ ������ �ν����Ϳ� ǥ�õ��� ����
    public static GameManager instance;
    public Player player;

    private void Awake()
    {
        instance = this;
    }
}
