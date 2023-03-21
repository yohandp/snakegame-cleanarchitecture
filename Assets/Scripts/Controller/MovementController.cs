using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SnakeClean{
    public class MovementController : MonoBehaviour{   
        private void Update(){
            if (Input.GetKey(KeyCode.RightArrow)){
                MoveUsecase.dir = Vector2.right;
            }else if (Input.GetKey(KeyCode.DownArrow)){
                MoveUsecase.dir = -Vector2.up;
            }else if (Input.GetKey(KeyCode.LeftArrow)){
                MoveUsecase.dir = -Vector2.right;
            }else if (Input.GetKey(KeyCode.UpArrow)){
                MoveUsecase.dir = Vector2.up;
            }
        }

    }

}
