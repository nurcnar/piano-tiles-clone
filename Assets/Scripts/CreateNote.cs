using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNote : MonoBehaviour
{
    public GameObject note;
    int y;
    public static CreateNote instance;
    private void Awake()
    {
        instance = this;
    }
    public int SelectX()
    {
        int xx = 3;
        int r = Random.Range(0, 4);
        switch (r)
        {
            case 0:
                xx = 1;
                break;
            case 1:
                xx = 3;
                break;
            case 2:
                xx = 5;
                break;
            case 3:
                xx = 7;
                break;
        }
        return xx;
    }
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {

            int x = SelectX();
            y += 3;

            PoolingManager.instance.AddGamobjectToPool(Instantiate(note, new Vector2(x, y), Quaternion.identity));
        }
    }
}
