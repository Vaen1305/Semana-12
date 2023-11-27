using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speedX;
    public float directionX;
    public float speedY;
    public float directionY;
    private SpriteRenderer _compSpriteRenderer;

    void Awake()
    {
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            directionX = 1;
            _compSpriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            directionX = -1;
            _compSpriteRenderer.flipX = false;
        }
        else
        {
            directionX = 0;
        }
        if (Input.GetKey(KeyCode.W) == true)
        {
            directionY = 1;
            _compSpriteRenderer.flipY = true;
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            directionY = -1;
            _compSpriteRenderer.flipY = false;
        }
        else
        {
            directionY = 0;
        }
        transform.position = new Vector2(transform.position.x + speedX * directionX * Time.deltaTime, transform.position.y + speedY * directionY * Time.deltaTime);
    }
}
