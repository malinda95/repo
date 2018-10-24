using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class TriggerExample : MonoBehaviour
    {
        private WalkThroughWall walkThroughWallScript;

         void Start()
        {
            SetInitialReferences();
        }
        void OnTriggerEnter(Collider other)
        {
            walkThroughWallScript.SetLayerToNotSolid();
            //Debug.Log(other.name + " has entered");
        }

        void OnTriggerExit(Collider other)
        {
            walkThroughWallScript.SetLayerToDefault();
            //Debug.Log(other.name + " has exited");
        }

        //void OnTriggerStay(Collider other)
        //{
        //    Debug.Log(other.name + " is staying");
        //}

        void SetInitialReferences()
        {
            if (GameObject.Find("Wall") != null)
            {
                walkThroughWallScript = GameObject.Find("Wall").GetComponent<WalkThroughWall>();
            }
            
        }
    }
}
