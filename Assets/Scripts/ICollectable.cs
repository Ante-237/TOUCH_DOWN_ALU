using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectable
{
    public int Amount { get; set; }
    public void Collect();
}
