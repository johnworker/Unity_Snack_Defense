using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class GameAssets : MonoBehaviour
    {
        #region 資料
        public static GameAssets i;

        public Sprite snakeHeadSprite;
        public Sprite foodSprite;

        #endregion

        #region 事件
        private void Awake()
        {
            i = this;
        }


        #endregion

        #region 方法
        #endregion


    }

}
