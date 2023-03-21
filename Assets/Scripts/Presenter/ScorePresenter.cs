using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SnakeClean{
    public class ScorePresenter : MonoBehaviour
    {
        public static ScorePresenter instance;

        public TextMeshProUGUI scoreText;
        public TextMeshProUGUI highscoreText;
        int highscore = 0;

        private void Awake(){
            instance = this;
        }

        private void Update() {
            highscore = PlayerPrefs.GetInt("highscore", 0);
            scoreText.text = "SCORE: " + ScoreUsecase.cScore.ToString();
            highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        }
    }
}