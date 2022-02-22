using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckControls();
    }
    void CheckControls()
    {
        MovePlayer();
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        gameObject.GetComponent<SpawnProjectile>().Spawn(bullet,transform.position,10,10);
    }
    void MovePlayer() {
        Vector3 transform = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.x += speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.y += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.y -= speed;
        }
        this.gameObject.transform.position += transform;
    }
}
