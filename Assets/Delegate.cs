using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    public delegate void Clicked();
    public event Clicked wasClicked;
    
    private void OnMouseDown() {
        wasClicked();
    }
}
