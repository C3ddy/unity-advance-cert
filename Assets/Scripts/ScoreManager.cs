using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static int coins;

    private static HealthComponent playerHealthComponent;

    void Start()
    {
        // resets the score to 0 at the start of the game
        score = 0;
        coins = 0;
        playerHealthComponent = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthComponent>();
    }

    public static void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        coins += 1;
        if (coins >= 10)
        {
            coins = 0;
            playerHealthComponent.AddHealth(10.0f);
        }
    }
}