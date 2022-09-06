using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    public List<GameObject> tile = new List<GameObject>();
    public static PoolingManager instance;
    private void Awake()
    {
        instance = this;
    }
    public void AddGamobjectToPool(GameObject note)
    {
        tile.Add(note);
    }
    //Listenin başındaki elemanı sonuna ekliyo, pozisyonunu da sonuncunun üstüne koycak

    public void PutToTheEnd()
    {
        if(tile.Count>1)
        {
            GameObject last = tile.Last();
            GameObject first = tile.First();

            tile.Remove(first);
            tile.Add(first);

            first.transform.position = new Vector3(CreateNote.instance.SelectX(), last.transform.position.y + 3, first.transform.position.z);
            first.GetComponent<Renderer>().material.color = Color.black;
            first.GetComponent<Note>().isSuccess = false;
        }
    }




















    /*public void PutToTheEnd()
    {
        if(tile.Count>1)
        {
            GameObject last = tile.Last();
            GameObject first = tile.First();

            tile.Remove(first);
            tile.Add(first);

            Vector3 newPos=new Vector3(CreateNote.instance.SelectX(), last.transform.position.y+3, first.transform.position.z);

            first.transform.position = newPos;
            first.GetComponent<Renderer>().material.color = Color.black;
            first.GetComponent<Note>().isSuccess = false;
        }

    }*/
        

}
