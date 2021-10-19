using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    void Start()
    {
        
    }

    void Update()
    {
        Movment();
    }

    public void Movment()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(HorizontalInput, 0, VerticalInput);

        transform.Translate(direction * speed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);


    }
}
