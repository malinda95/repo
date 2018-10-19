using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1 
{
    public class Welcome : MonoBehaviour
    {
        public string myMessage = "Welcome";

        // Use this for initialization
        void Start()
        {
            MyWelcomeMessage(); 
        }

        // Update is called once per frame
       /* void Update()
        {

        }
        */

        void MyWelcomeMessage() 
        {
            Debug.Log(myMessage);
        }
    }
}

