using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereItem : MonoBehaviour, ICollectable
{
    [Range(0, 100)]
    public float RotationSpeed = 5f;
    public Vector3 RotationDirection = Vector3.up;
    
    private int amount = 30;

    public int Amount
    {
        set { amount = value;}
        get { return amount; }
    }

    public void Update()
    {
        transform.Rotate(RotationDirection * (RotationSpeed * Time.deltaTime));
    }


    public void Collect()
    {
        GameManager.Instance.UpdateSphereScore(amount);
        Destroy(gameObject, 0.2f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collect();
        }
    }
   
}
