using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum PixelType 
{
    Start = 1,
    End = -10,
    Wall = -1,
    Plain = 0
}

public class Pixel : MonoBehaviour
{
    SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    void SetStart() {
        sr.color = Color.green;
    }
    void SetEnd() {

        sr.color = Color.red;
    }
    void SetWall() {

        sr.color = Color.black;
    }
    void SetPlain() {

        sr.color = Color.white;
    }
}
