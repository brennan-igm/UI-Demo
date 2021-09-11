using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public ScoreManager manager;

    public void OnScoreButtonClicked()
    {
        manager.AddScore(1);
    }
}
