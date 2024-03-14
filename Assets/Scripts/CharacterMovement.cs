using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float MovementSpeed = 10f;

    private float HorizontalDirection;
    private float VerticalDirection;
    
    protected void Movements()
    {
        HorizontalDirection = Input.GetAxisRaw("Horizontal");
        VerticalDirection = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(VerticalDirection * MovementSpeed * Time.deltaTime, 0, HorizontalDirection * MovementSpeed * Time.deltaTime) ;
       // transform.Translate(HorizontalDirection * MovementSpeed * Time.deltaTime,0, VerticalDirection * MovementSpeed * Time.deltaTime);
    }
}
