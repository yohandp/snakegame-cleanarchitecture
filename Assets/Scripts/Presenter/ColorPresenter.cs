using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SnakeClean{
    public class ColorPresenter : MonoBehaviour
    {
        
        public static int[] color = new int[3];
        private void Update(){
            color[0] = PlayerPrefs.GetInt("colorX");
            color[1] = PlayerPrefs.GetInt("colorY");
            color[2] = PlayerPrefs.GetInt("colorZ");
            GetComponent<SpriteRenderer>().color = new Color(color[0]/255f, color[1]/255f, color[2]/255f);
            ChangeColorUsecase.changeColor(color[0], color[1], color[2]);
        }
    }
}