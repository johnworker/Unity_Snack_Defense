using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class GameAssets : MonoBehaviour
    {
        #region ���
        public static GameAssets i;

        public Sprite snakeHeadSprite;
        public Sprite foodSprite;

        #endregion

        #region �ƥ�
        private void Awake()
        {
            i = this;
        }


        #endregion

        #region ��k
        #endregion


    }

}
