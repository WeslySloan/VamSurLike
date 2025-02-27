using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static으로 선언한 변수는 인스펙터에 표시되지 않음
    public static GameManager instance;

    public float gameTime;
    public float maxGameTime = 2 * 10f;

    public Player player;
    public PoolManager pool;
    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime)
            gameTime = maxGameTime;

    }
}
