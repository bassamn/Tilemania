using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerLives = 3;
    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Image heartImage;
    [SerializeField] Image skullImage;

    void Awake()
    {
        int numberGameSessions = FindObjectsByType<GameSession>().Length;
        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        livesText.text = playerLives.ToString();
        scoreText.text = "0";
    }

    void UpdateLivesUI()
    {
        if (playerLives <= 0)
        {
            // Turn off the heart image and turn on the skull image
            livesText.text = "0";
            heartImage.enabled = false;
            skullImage.enabled = true;
            livesText.enabled = false;
        }
        else
        {
            livesText.text = playerLives.ToString();
        }
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 0)
        {
            TakeLife();
        }
        else
        {
            ResetGameSession();
        }
    }

    void TakeLife()
    {
        playerLives--;
        UpdateLivesUI();
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        livesText.text = playerLives.ToString();
    }

    void ResetGameSession()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
        scoreText.text = "0";
    }

    public void AddToScore(int pointsToAdd)
    {
        int currentScore = int.Parse(scoreText.text);
        currentScore += pointsToAdd;
        scoreText.text = currentScore.ToString();
    }
}
