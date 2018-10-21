using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class Shoot : MonoBehaviour
    {
        private float fireRate = 0.3f;
        private float nextFire;
        private RaycastHit hit;
        private float range = 300;
        private Transform myTranform;

        // Use this for initialization
        void Start()
        {
            SetInitialRedference();
        }

        void SetInitialRedference()
        {
            myTranform = transform;
        }

        // Update is called once per frame
        void Update()
        {
            CheckForInput();
        }

        void CheckForInput()
        {
            if (Input.GetButton("Fire1")&& Time.time > nextFire)
            {
                Debug.DrawRay(myTranform.TransformPoint(0,0,1), myTranform.forward,Color.gray,3);

                if (Physics.Raycast(myTranform.TransformPoint(0,0,1), myTranform.forward,out hit, range))
                {
                    if (hit.transform.CompareTag("Enemy"))
                    {
                        Debug.Log("Enemy" + hit.transform.name);
                    }
                    else
                    {
                        Debug.Log("Not an Enemy");
                    }
                    
                 }
                nextFire = Time.time + fireRate;

              
            }
        }
    }
}
