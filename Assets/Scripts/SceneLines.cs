using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLines : MonoBehaviour
{
    public Transform target;
    private void OnDrawGizmos()
    {

        Gizmos.color = Color.blue;
        for (int i = 0; i < 5; i++)
        {
            Gizmos.DrawLine(new Vector2 (transform.position.x+i*2,transform.position.y),new Vector2(target.position.x+i*2,target.position.y));
        }
        
    }
}
