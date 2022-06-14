using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObject : MonoBehaviour
{

    public abstract void Activate();


    public Color baseColor = Color.blue;
    public Color highlightColor = Color.green;

    public bool highlighted = false;

    private Material material;

    private void Start() {
        material = GetComponent<MeshRenderer>().material;
        material.SetColor("_Fresnel_Color", baseColor);
    }

    private void OnMouseEnter() {
        ChangeColor(highlightColor);
    }

    private void OnMouseExit() {
        ChangeColor(baseColor);
    }

    private void OnMouseDown() {
        material.SetFloat("_Fresnel_Intensity", 0f);
        Activate();
    }

    public void ChangeColor(Color color) {
        material.SetColor("_Fresnel_Color", color);
    }


    
}
