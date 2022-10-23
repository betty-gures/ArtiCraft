using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit.UI;

public class CoreMechanic : MonoBehaviour
{
    [SerializeField] GameObject _rightHand, _leftHand;
    [SerializeField] GameObject[] objToSpawn;
    
    GameObject _newCreation;
    bool rightButtonClicked, leftButtonClicked, bothControllersPressed, objectCreated;
    
    private int i=0;
    private  Rigidbody rb;
    
    void CreateObject()
    {
        //spawn object
        var instantiated = false;
        if (!instantiated)
        {
            _newCreation = Instantiate(objToSpawn[i],  (_rightHand.transform.position + _leftHand.transform.position)/2 ,Quaternion.identity);
            _newCreation.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            instantiated = true;
        }
        bothControllersPressed = false;
        objectCreated = true;
        /*Add Components
        rb= objToSpawn[i].AddComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;
        */
        
        
    }

    public void ActivateRightHand()
    {
        rightButtonClicked = true;
        Debug.Log("Right hand True");
    }
    public void ActivateLeftHand()
    {
        leftButtonClicked = true;
        Debug.Log("Left hand True");
    }
    public void DeactivateRightHand()
    {
        rightButtonClicked = false;
        Debug.Log("Right hand False");
    }
    public void DeactivateLeftHand()
    {
        leftButtonClicked = false;
        Debug.Log("Left hand False");
    }
    
    private void Update()
    {
        if (rightButtonClicked && leftButtonClicked)
        {
            
            if (bothControllersPressed)
            CreateObject();
            

            var distance = Mathf.Abs(_rightHand.transform.position.x - _leftHand.transform.position.x);
            if (distance > 0.5)
            {
                _newCreation.transform.localScale += new Vector3(0.1f,0.1f,0.1f) * Time.deltaTime;
            }
            else if (distance < 0.5)
            {
                _newCreation.transform.localScale -= new Vector3(0.1f,0.1f,0.1f) * Time.deltaTime;
            }
            else if (_newCreation.transform.localScale.x < 0.01f && distance < 0.5)
            {
                _newCreation.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
            }
        }
        else
        {
            bothControllersPressed = true;
        }
    }
}
