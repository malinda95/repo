﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
    public class MainMenu : MonoBehaviour
    {

       public void PlayGame()
        {
            Application.LoadLevel(1);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
