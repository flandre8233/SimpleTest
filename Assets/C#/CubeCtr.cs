using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCtr : MonoBehaviour
{
    [SerializeField] float H;
    [SerializeField] float V;

    [SerializeField] GameObject Bullet;
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        Boom();
    }

    void Move()
    {
        H = Input.GetAxis("Horizontal");
        V = Input.GetAxis("Vertical");

        transform.position += new Vector3(H, V, 0) * Time.deltaTime;
    }


    void Boom()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject G = Instantiate(Bullet, transform.position, Quaternion.identity);
            Destroy(G, 5);
        }
    }
}
