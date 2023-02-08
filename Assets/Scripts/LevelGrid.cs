using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;

namespace Leo
{
    public class LevelGrid
    {
        private Vector2Int fooGridPosition;
        private int width;
        private int height;

        public LevelGrid(int width, int height) 
        {
            this.width = width;
            this.height = height;

            SpawnFood();
        }

        private void SpawnFood()
        {
            fooGridPosition = new Vector2Int(Random.Range(0, width), Random.Range(0, height));

            GameObject foodGameObject = new GameObject("Food", typeof(SpriteRenderer));
            foodGameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.i.foodSprite;
            foodGameObject.transform.position = new Vector3(fooGridPosition.x, fooGridPosition.y);
        }
    }

}
