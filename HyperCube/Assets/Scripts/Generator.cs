using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{      // Bu script rastgele dikdörtgenler oluşturarak oyunda devamlılığı sağlar.
    private const float V = 0f;
    public GameObject TilePreFab;
    public float xDiff = 1.1f;
    public float yDiffSmall = 0.5f;
    public float yDiffbig = 1.4f;

    private float xPos = 0f;
    private float yPos = 0f;

    private string smallTag = "smallTile";
    private string bigTile = "bigTile";
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 7; ++i)
        {
            GenerateTiles();
        }
    }

    public void GenerateTiles()
    {
        int random = Random.Range(0, 5);
        if (random <= 2)
        {
            GenerateSmallTile();
        }
        else
        {
            GenerateBigTile();
        }

    }


    void GenerateSmallTile()
    {
        xPos += xDiff;
        yPos += yDiffSmall;

        TilePreFab.tag = smallTag;
        Instantiate(TilePreFab, new Vector3(xPos, yPos, 0), TilePreFab.transform.rotation);   
    }
    void GenerateBigTile()
    {
        xPos += xDiff;
        yPos += yDiffbig;

        TilePreFab.tag = bigTile;
        Instantiate(TilePreFab, new Vector3(xPos, yPos, 0), TilePreFab.transform.rotation);
    }
}
