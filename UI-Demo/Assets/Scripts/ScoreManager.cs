using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score;

    public int Score => score;

    public Text scoreDisplay;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = $"Score\n{Score}";
    }

    public void AddScore(int amount)
    {
        score += amount;
    }

    public void SpendScore(int amount)
    {
        score -= amount;
    }
}
