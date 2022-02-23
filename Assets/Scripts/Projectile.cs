using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector2 acceleration;
    public Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(velocity.x, velocity.y));
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: convert acceleration to only update once per second
        Accelerate();
        CheckBounds();
        
    }
    void Accelerate()
    {
        if (acceleration.x != 0 || acceleration.y != 0) {
            GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(acceleration.x, acceleration.y));
        }
    }
    void CheckBounds() {
        if (transform.position.y > 10 ||
            transform.position.y < -10 ||
            transform.position.x > 10 ||
            transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
