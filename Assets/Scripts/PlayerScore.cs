using UnityEngine;
using System.Collections.Generic;

public class PlayerScore : MonoBehaviour
{
    public int score;
    public List<int> coins = new List<int>();

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Welkom bij het spel! Verzamel de munten!");
        }
    }

    void Update()
    {
        if (score >= 50)
        {
            Debug.Log("Gefeliciteerd! Je hebt gewonnen!");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int coinValue = Random.Range(5, 16);
            AddCoin(coinValue);
        }
    }

    void AddCoin(int coinValue)
    {
        coins.Add(coinValue);
        score += coinValue;
        Debug.Log("Je hebt een munt gepakt van waarde: " + coinValue + ". Totale score: " + score);
        Debug.Log("Aantal munten: " + coins.Count);
    }
}
