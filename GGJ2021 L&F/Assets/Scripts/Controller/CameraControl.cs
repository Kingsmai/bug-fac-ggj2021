using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player;
    
    // Start is called before the first frame update
    
    void Start()
    {
        this.transform.position = new Vector3(player.position.x - 25f, player.position.y + 15f, player.position.z - 25f);
        this.transform.LookAt(player);
    }


    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(player.position.x-10f, player.position.y+5f, player.position.z-10f);
    }
}
