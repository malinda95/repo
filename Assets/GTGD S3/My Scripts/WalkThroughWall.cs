using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class WalkThroughWall : MonoBehaviour
    {
        private Color myColor = new Color(0.5f,1,0.5f,0.3f);


        //void OnEnable()
        //{
        //    gameObject.layer = LayerMask.NameToLayer("NotSolid");
        //}

        //void OnDisable()
        //{
        //    gameObject.layer = LayerMask.NameToLayer("Default");
        //}

        public void SetLayerToNotSolid()
        {
            gameObject.layer = LayerMask.NameToLayer("NotSolid");
            GetComponent<Renderer>().material.SetColor("_Color",myColor);
        }
        public void SetLayerToDefault()
        {
            gameObject.layer = LayerMask.NameToLayer("Default");
            GetComponent<Renderer>().material.color = Color.white;
           
        }
    }
}
