using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float acceleration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Accelerate();
        CheckBounds();
        
    }
    void Accelerate()
    {
        if (acceleration != 0) {
            GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(acceleration, 0));
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
