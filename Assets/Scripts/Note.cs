using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Note : MonoBehaviour
{
    //bool isBack = false;
    public bool isSuccess = false;
    private void OnMouseUp()
    {
        if (isSuccess || PoolingManager.instance.tile.First(x => !x.GetComponent<Note>().isSuccess).gameObject != this.gameObject)
            return;

        ScoreManager.instance.AddScore();
        isSuccess = true;
        GetComponent<Renderer>().material.color = Color.white;
    }
    private void Update()
    {
        if(transform.position.y<CameraMovement.instance.transform.position.y-6)
        {
            if(isSuccess==false)
            {
                Time.timeScale = 0;
            }
            else
            {
                PoolingManager.instance.PutToTheEnd();
            } 
        }
    }
}
