using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Declaring Variblers
    // Public Member/Global Variables
    public float MoveSpeed = 10f;
    public int PlayerScore = 0;
    public string PlayerName = "John Doe";
    public bool IsPlayerActive = true;

    // Private Member/Global Varibles
    private float _maxSpeed = 100f;
    private int _totalScore = 0;
        private string _usernamwe = "John007";
    private bool _isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Declaring local varibles 
        float horizontalInput = Input.GetAxis("Horizontal");
    }

    private void UpdateScore(int amount)
    {
        // using a local variable to update the total score
        _totalScore += amount;
    }
}
