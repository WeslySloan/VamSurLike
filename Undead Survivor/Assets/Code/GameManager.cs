using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static���� ������ ������ �ν����Ϳ� ǥ�õ��� ����
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
