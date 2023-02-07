using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class GameAssets : MonoBehaviour
    {
        #region 資料
        public static GameAssets i;


        #endregion

        #region 事件
        private void Awake()
        {
            i = this;
        }

        public Sprite snakeHeadSprite;

        #endregion

        #region 方法
        #endregion


    }

}
