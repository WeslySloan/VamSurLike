using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // static���� ������ ������ �ν����Ϳ� ǥ�õ��� ����
    public static GameManager instance;
    [Header("# Game Control")]
    public bool isLive;
    public float gameTime;
    public float maxGameTime = 2 * 10f;
    [Header("# Player Info")]
    public int health;
    public int maxHealth;
    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = { 10, 30, 60, 100, 150, 210, 280, 360, 450, 600 };
    [Header("# Game Object")]
    public Player player;
    public PoolManager pool;
    public LevelUp uiLevelUp;

    void Awake()
    {
        instance = this;
    }

    public void GameStart()
    {
        health = maxHealth;
        uiLevelUp.Select(0);  // �ӽ� ��ũ��Ʈ (ù���� ĳ���� ����)
        isLive = true;
    }

    void Update()
    {
        if (!isLive)
            return;

        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime)
            gameTime = maxGameTime;

    }

    public void GetExp()
    {
        exp++;

        if (exp == nextExp[Mathf.Min(level, nextExp.Length - 1)])
        {
            level++;
            exp = 0;
            uiLevelUp.Show();
        }
    }


    public void Stop()
    {
        isLive = false;
        Time.timeScale = 0; // 0���
    }

    public void Resume()
    {
        isLive = true;
        Time.timeScale = 1; // 1���
    }
}
