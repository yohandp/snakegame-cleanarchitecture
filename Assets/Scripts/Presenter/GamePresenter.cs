using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SnakeClean{
    
    public class GamePresenter : MonoBehaviour
    {
        public TextMeshProUGUI pauseText;
        private void Update(){
            if(MoveUsecase.isPaused == true){
                pauseText.text = "Jogo pausado.\nAperte P para despausar.";
            }else{
                pauseText.text = "";
            }
            
        }
    }    

}