using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGenerator : MonoBehaviour
{
    private int numOwned = 0;

    private int baseCost = 10;

    public ScoreManager manager;

    public Button buyButton;

    public Image progressBar;

    public Text buyButtonText;

    private float currentProgress = 0f;
    private float progressNeeded = 5f;

    public Text generatorText;

    // Start is called before the first frame update
    void Start()
    {
        buyButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        currentProgress += Time.deltaTime * numOwned;

        generatorText.text = "Generators: " + numOwned;
        
        int currentCost = GetCurrentCost();
        buyButtonText.text = $"Buy Generator\nCost: {currentCost}";

        // buyButton.interactable = manager.Score >= currentCost;
        
        if (manager.Score < currentCost)
        {
            buyButton.interactable = false;
        }
        else
        {
            buyButton.interactable = true;
        }
        
        if (currentProgress > progressNeeded)
        {
            manager.AddScore(numOwned);
            currentProgress = 0f;
        }

        progressBar.fillAmount = currentProgress / progressNeeded;
    }

    private void OnButtonClick()
    {
        int currentCost = GetCurrentCost();
        if (manager.Score >= currentCost)
        {
            manager.SpendScore(currentCost);
            numOwned++;
        }
    }

    private int GetCurrentCost()
    {
        return baseCost + (int)Mathf.Pow(numOwned, 2);
    }
}
