using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (ControllerScript.activeCube != null) {
            ControllerScript.activeCube.GetComponent<Renderer>().material.color = Color.white;//turns last cube white
        }
        gameObject.GetComponent<Renderer>().material.color = Color.red;//turns current cube red
        ControllerScript.activeCube = gameObject;//sets currently clicked cube to active
    }
}
