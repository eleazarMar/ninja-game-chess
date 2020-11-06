using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePiece : MonoBehaviour
{
    public float scaleFactor;
    public float x;
    public float up;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(x*scaleFactor, up, y*scaleFactor);
        lockIntoSpace();
    }





    void lockIntoSpace()
    {
        x = Mathf.Ceil(x);
        y = Mathf.Ceil(y);
    }


    void MoveToSpace()
    {

    }


}
