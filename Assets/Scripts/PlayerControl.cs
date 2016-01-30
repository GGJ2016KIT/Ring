using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    public Vector2 SPEED = new Vector2(0.05f, 0.05f);
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 Position = transform.position;
        if (Input.GetKey("left"))
        {
            Position.x -= SPEED.x;
        }
        else if (Input.GetKey("right"))
        {
            Position.x += SPEED.x;
        }
        transform.position = Position;
    }


}