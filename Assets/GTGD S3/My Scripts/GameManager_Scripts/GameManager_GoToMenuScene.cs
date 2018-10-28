using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
    public class GameManager_GoToMenuScene : MonoBehaviour
    {


        private GameManager_Master gameManagerMaster ;

    void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.GoToMenueSceneEvent += GoToMenuScene;
        }

        void OnDisable()
        {
            gameManagerMaster.GoToMenueSceneEvent -= GoToMenuScene;
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManager_Master>();
        }

        void GoToMenuScene()
        {
            Application.LoadLevel(0);
        }
    }
}
