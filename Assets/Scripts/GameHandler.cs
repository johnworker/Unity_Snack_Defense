using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

namespace Leo
{
    public class GameHandler : MonoBehaviour
    {
        #region 資料
        [SerializeField] private Snake snake;

        private LevelGrid levelGrid;
        #endregion

        #region 事件
        private void Start()
        {

            levelGrid = new LevelGrid(20, 20);

            snake.Setup(levelGrid);
            levelGrid.Setup(snake);

        }
        #endregion

        #region 方法
        #endregion
    }

}
