using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisible : MonoBehaviour
{

    public GameObject checkObject;


    // Update is called once per frame
    void Update()
    {
      if(checkObject.activeInHierarchy == true){
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
      }  
    }
}
