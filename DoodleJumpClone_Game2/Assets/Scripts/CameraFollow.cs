using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float lerpValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(player.position.y > transform.position.y)
		{
            Vector3 newPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, lerpValue);

            // for a direct follow without lerping, use the code below
            //transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
    }
}
