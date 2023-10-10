using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class Quiz1codingchallenge : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        IncreseScore();
        PrintPlayerName();
        DecreaseHealth(20);
    }

    // Declaring Variables
    public int score = 0;
    public string PlayerName = "Lennon";
    public int Health = 100;



    // Update is called once per frame
    void Update()
    {

    }

    private void IncreseScore()
    {
        score = score + 10;
        score += 10;
    }

    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreaseHealth(int amount)
    {
        Health -= amount;
    }
    
}
