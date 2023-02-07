using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class Snake : MonoBehaviour
    {
        #region ���
        private Vector2Int gridMoveDirection;
        private Vector2Int gridPosition;
        private float gridMoveTimer;
        private float gridMoveTimerMax;

        #endregion

        #region �ƥ�
        private void Awake()
        {
            gridPosition = new Vector2Int(10, 10);
            gridMoveTimerMax = 1f;
            gridMoveTimer = gridMoveTimerMax;
            gridMoveDirection = new Vector2Int(1, 0);
        }

        private void Update()
        {
            HandleInput();

            HandleGridMovement();

            transform.position = new Vector3(gridPosition.x, gridPosition.y);
        }
        #endregion

        #region ��k

        private void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (gridMoveDirection.y != -1)
                {
                    gridMoveDirection.x = 0;
                    gridMoveDirection.y = +1;
                }
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (gridMoveDirection.y != +1)
                {
                    gridMoveDirection.x = 0;
                    gridMoveDirection.y = -1;
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (gridMoveDirection.x != +1)
                {
                    gridMoveDirection.x = -1;
                    gridMoveDirection.y = 0;
                }
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (gridMoveDirection.x != -1)
                {
                    gridMoveDirection.x = +1;
                    gridMoveDirection.y = 0;
                }
            }

        }

        private void HandleGridMovement()
        {
                        gridMoveTimer += Time.deltaTime;
            if(gridMoveTimer >= gridMoveTimerMax)
            {
                gridPosition += gridMoveDirection;
                gridMoveTimer -= gridMoveTimerMax;
            }

        } 
        #endregion
    }

}