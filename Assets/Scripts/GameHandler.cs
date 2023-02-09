using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

namespace Leo
{
    public class GameHandler : MonoBehaviour
    {
        #region ���
        [SerializeField] private Snake snake;

        private LevelGrid levelGrid;
        #endregion

        #region �ƥ�
        private void Start()
        {

            levelGrid = new LevelGrid(20, 20);

            snake.Setup(levelGrid);
            levelGrid.Setup(snake);

        }
        #endregion

        #region ��k
        #endregion
    }

}
