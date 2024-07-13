using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   //public access to gameobject "player"
    public GameObject player;
    //vector on top of vector for correct positioning
    private Vector3 offset = new Vector3(0,5,-7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //follow position of player
       transform.position = player.transform.position + offset; 
    }
}
