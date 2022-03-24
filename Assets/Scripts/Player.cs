using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 10, _bulletSpeed = 25;
    [SerializeField] private GameObject _bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    private void Shooting()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
             Instantiate(_bullet, transform.position, Quaternion.identity);
        }
    }

    private void Movement()
    {
        var HorizontalInput = Input.GetAxis("Horizontal"); 
        var xPos = Mathf.Clamp(transform.position.x, -24.5f, 24.5f);
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * _speed);

         if(transform.position.x > 24.5)
         {
             transform.position = new Vector3(24.5f, transform.position.y, transform.position.z);
         }

         if (transform.position.x < -24.5)
         {
             transform.position = new Vector3(-24.5f, transform.position.y, transform.position.z);
         } 

    }
}
