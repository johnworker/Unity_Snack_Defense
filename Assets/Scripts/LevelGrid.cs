using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

namespace Leo
{
    public class LevelGrid
    {
        #region 資料
        private Vector2Int fooGridPosition;
        private GameObject foodGameObject;
        private int width;
        private int height;
        private Snake snake;

        #endregion

        #region 事件
        public LevelGrid(int width, int height) 
        {
            this.width = width;
            this.height = height;

            SpawnFood();

        }

        public void Setup(Snake snake) 
        {
            this.snake = snake;
        }

        #endregion

        #region 方法
        private void SpawnFood()
        {
            do
            {
                fooGridPosition = new Vector2Int(Random.Range(0, width), Random.Range(0, height));
            }
            while (snake.GetFullSnakeGridPositionList().IndexOf(fooGridPosition) != -1);

            foodGameObject = new GameObject("Food", typeof(SpriteRenderer));
            foodGameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.i.foodSprite;
            foodGameObject.transform.position = new Vector3(fooGridPosition.x, fooGridPosition.y);
        }

        public bool TrySnakeEatFood(Vector2Int snakeGridPosition) 
        { 
            if(snakeGridPosition == fooGridPosition)
            {
                Object.Destroy(foodGameObject);
                SpawnFood();
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }

}
