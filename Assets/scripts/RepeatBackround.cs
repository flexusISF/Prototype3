using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackround : MonoBehaviour
{

    private float speed = 30;
    private PlayerController playerControllerscript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerscript =
            GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerscript.gameOver == false) { }
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        
    }
}
