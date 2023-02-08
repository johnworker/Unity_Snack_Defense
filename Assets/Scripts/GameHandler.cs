using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

namespace Leo
{
    public class GameHandler : MonoBehaviour
    {
        private LevelGrid levelGrid;

        private void Start()
        {

            levelGrid = new LevelGrid(20, 20);

            GameObject snakeHeadGameObject = new GameObject();
            SpriteRenderer snakeSpriteRenderer = snakeHeadGameObject.AddComponent<SpriteRenderer>();
            snakeSpriteRenderer.sprite = GameAssets.i.snakeHeadSprite;
        }
    }

}
