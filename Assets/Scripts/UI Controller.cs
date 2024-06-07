using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private Health healths;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private ScoreManager currentScore;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private TextMeshProUGUI GameOverScore;

    // Start is called before the first frame update
    void Start()
    {
        healths.OnHealthChaged.AddListener(Updatehealthtext);
        currentScore.OnScoreChaged.AddListener(UpdateScoreText);
        healths.OnDie.AddListener(ShowGameOverScreen);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Updatehealthtext(int healthValue)
    {
        healthText.text = "Health: " + healthValue.ToString();
    }

    private void UpdateScoreText(int ScoreValue)
    {
        scoreText.text = "Score: " + ScoreValue.ToString();
    }

    private void ShowGameOverScreen()
    {
        GameOverScreen.SetActive(true);
        GameOverScore.text = "Score: " + scoreText.text;
    }
}
