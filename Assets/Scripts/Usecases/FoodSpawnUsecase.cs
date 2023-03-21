using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace SnakeClean{
    public class FoodSpawnUsecase : MonoBehaviour{
        public GameObject foodPrefab;

        public Transform borderTop;
        public Transform borderBottom;
        public Transform borderLeft;
        public Transform borderRight;

        private void Start(){
            InvokeRepeating("Spawn", 3, 4);
        }

        private void Spawn(){
            int x = (int)Random.Range(borderLeft.position.x-0.5f, borderRight.position.x);
            int y = (int)Random.Range(borderBottom.position.y-0.5f, borderTop.position.y);
            Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
        }
    }
}

    