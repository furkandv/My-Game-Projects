using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{   // Bu script uzun çubukların yok oldukça geri gelmesini sağlar.
    float ypos;
    Generator _Generator;
    // Start is called before the first frame update
    void Start()
    {
        ypos = transform.position.y;
        _Generator = GameObject.Find("TilesGenerator").GetComponent<Generator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < ypos - 10f)
        {
            _Generator.GenerateTiles();
            Destroy(this.gameObject);
        }
    }
}
