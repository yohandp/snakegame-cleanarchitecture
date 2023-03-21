using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SnakeClean{

    public class GameController : MonoBehaviour
    {
        System.Random randomColor = new System.Random();
        int[] randColor = new int[3];
        private void Start()
        {
            PauseGame();
        }

        // Update is called once per frame
        private void Update()
        {

            randColor[0] = randomColor.Next(0, 255);
            randColor[1] = randomColor.Next(0, 255);
            randColor[2] = randomColor.Next(0, 255);

            if(Input.GetKeyDown("p")&&MoveUsecase.isPaused==false){
                PauseGame();
                MoveUsecase.isPaused=true;
            }else if(Input.GetKeyDown("p")&&MoveUsecase.isPaused==true){
                ResumeGame();
                MoveUsecase.isPaused=false;
            }

            

            if(Input.GetKeyDown("t")){
                ChangeColorUsecase.changeColor(randColor[0], randColor[1], randColor[2]);
            }

        }
        private void PauseGame ()
        {
            Time.timeScale = 0;
        }

        private void ResumeGame ()
        {
            Time.timeScale = 1;
        }    
    }

}