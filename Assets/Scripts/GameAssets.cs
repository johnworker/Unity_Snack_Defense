using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leo
{
    public class GameAssets : MonoBehaviour
    {
        #region ���
        public static GameAssets i;


        #endregion

        #region �ƥ�
        private void Awake()
        {
            i = this;
        }

        public Sprite snakeHeadSprite;

        #endregion

        #region ��k
        #endregion


    }

}
