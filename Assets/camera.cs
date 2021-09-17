using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform player;
    //vector3 stores 3 floats ie positions(x,y,z)
    public Vector3 offset;  //we specifed offset values in unity console in camera 
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);  
        transform.position = player.position + offset;  //if we write transform with nin capital t,it reffers to transform of current object that means the object on which the script is sitting on ie here its camera because there is where the scrip is
                                                        //in the above code the camera is inside the cube this can be useful for 1st person view but we want only 3rd person view

    }
}

