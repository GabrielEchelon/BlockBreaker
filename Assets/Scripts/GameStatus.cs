using UnityEngine;
using TMPro;
using System;

public class GameStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    [Range(0.1f, 10f)] [SerializeField] private float gameSpeed = 1f;
    [SerializeField] private int currentScore = 0;
    [SerializeField] private int pointsPerBlock = 100;
    [SerializeField] private bool isAutoPlayEnabled = false;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }

    void Update()
    {
        Time.timeScale = gameSpeed;
        scoreText.text = currentScore.ToString();
    }

    public void AddScore()
    {
        currentScore += pointsPerBlock;
    }

    public void ResetScore()
    {
        currentScore = 0;
    }

}
