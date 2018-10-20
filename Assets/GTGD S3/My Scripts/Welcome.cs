﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter1 
{
    public class Welcome : MonoBehaviour
    {
        public string myMessage = "Welcome";
        private Text textWelcome;

        // Use this for initialization
        void Start()
        {
            SetInitialReferences();
            MyWelcomeMessage(); 
        }

        void SetInitialReferences()
        {
            textWelcome = GameObject.Find("TextWelcome").GetComponent<Text>();
        }

        void MyWelcomeMessage() 
        {
            if (textWelcome != null)
            {
                textWelcome.text = myMessage;
            }
            else
            {
                Debug.LogWarning("Welcome message is not assigned");
            }
        }
    }
}

