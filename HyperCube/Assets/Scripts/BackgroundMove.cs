using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    // Bu script kameranın gördüğü açıyı küpün merkezine odaklamıştır. 
    // Küpün hareketine göre kamera yönlenecektir.
    private GameObject player;
    Vector3 vel;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Kup>().isDead)
            return;
        
        transform.position = Vector3.SmoothDamp
            (
                transform.position,
                new Vector3(Camera.main.transform.position.x + 3f, player.transform.position.y, transform.position.z),
                ref vel,
                1f
            );
    }
}
