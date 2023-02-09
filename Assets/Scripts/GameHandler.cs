using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

namespace Leo
{
    public class GameHandler : MonoBehaviour
    {
        [SerializeField] private Snake snake;

        private LevelGrid levelGrid;

        private void Start()
        {

            levelGrid = new LevelGrid(20, 20);

            snake.Setup(levelGrid);
            levelGrid.Setup(snake);

            //GameObject snakeHeadGameObject = new GameObject();
            //SpriteRenderer snakeSpriteRenderer = snakeHeadGameObject.AddComponent<SpriteRenderer>();
            //snakeSpriteRenderer.sprite = GameAssets.i.snakeHeadSprite;
        }
    }

}
