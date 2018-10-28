using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class TriggerExample : MonoBehaviour
    {
        private  GameManager_EventMaster eventMasterScript;

         void Start()
        {
            SetInitialReferences();
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")){
                eventMasterScript.CallMyGeneralEvent();
                Destroy(gameObject);
            }

        }

        void SetInitialReferences()
        {
            eventMasterScript = GameObject.Find("GameManager").GetComponent<GameManager_EventMaster>();

        }
    }
}
