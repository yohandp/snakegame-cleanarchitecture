using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SnakeClean{
    public class ChangeColorUsecase : MonoBehaviour
    {
        public static void changeColor(int x, int y, int z)
        {
            Snake.alteraCor(x, y, z);
            PlayerPrefs.SetInt("colorX", Snake.color[0]);
            PlayerPrefs.SetInt("colorY", Snake.color[1]);
            PlayerPrefs.SetInt("colorZ", Snake.color[2]);
        }
        
    }
}