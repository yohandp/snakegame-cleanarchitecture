using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

namespace SnakeClean{
public class MoveUsecase : MonoBehaviour{
        public static Vector2 dir = Vector2.right;
        public static bool isPaused = Snake.isPaused;

        List<Transform> tail = new List<Transform>();
        public GameObject tailPrefab;
        private void Start(){
            InvokeRepeating("Move", 0.1f, 0.1f);
        }

        private void Update(){
            Snake.isPaused = isPaused;
        }

        private void Move(){
            Vector2 v = transform.position;
            transform.Translate(dir);

            if (Snake.ate) {
                GameObject g = (GameObject)Instantiate(tailPrefab, v, Quaternion.identity);
                tail.Insert(0, g.transform);
                Snake.ate = false;
            }
            else if (tail.Count > 0) {
                tail.Last().position = v;
                tail.Insert(0, tail.Last());
                tail.RemoveAt(tail.Count-1);
            }
        }

        private void OnTriggerEnter2D(Collider2D coll) {
            if (coll.tag.Equals("Food")){
                Snake.ate = true;
                Destroy(coll.gameObject);
                Snake.score += 1;
            }else{
                SceneManager.LoadScene(0);
                Snake.isPaused = true;
            }
        }

    }
}

