using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    private PlayerController playerController;
    private float leftBound = -10.0f;
    
    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (playerController.isGameover == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacles")) {
            Destroy(gameObject);
        }
    }
}
