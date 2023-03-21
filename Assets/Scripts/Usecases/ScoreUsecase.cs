using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SnakeClean{
    public class ScoreUsecase : MonoBehaviour
    {
        int highscore;
        public static int cScore = Snake.score;

        private void Start(){
            highscore = PlayerPrefs.GetInt("highscore", 0);
        }

        private void Update() {
            if(highscore<Snake.score){
                PlayerPrefs.SetInt("highscore", Snake.score);
            }
            cScore = Snake.score;
        }
    }
}