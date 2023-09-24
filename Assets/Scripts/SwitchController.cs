using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;

    private bool isOn;
    private Renderer renderer;

    private void Start() {
        renderer = GetComponent<Renderer>();
        Set(false);
    }
    private void OnTriggerEnter(Collider other) {
        if(other == bola){
            Set(!isOn);
        }
    }

    private void Set(bool active){
        isOn = false;
        renderer.material = isOn ? onMaterial : offMaterial;
    }
}
