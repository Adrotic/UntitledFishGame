using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    float startSpeed;
    float endSpeed;
    public GameObject projectileBase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn()
    {
        GameObject projectile = Instantiate(projectileBase, transform.position, transform.rotation);
        projectile.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(600, 0));
    }
}
