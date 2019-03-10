using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Material[] _material;
    private bool isMove = false;

    public void OnClick_Blue() {
        this.GetComponent<Renderer>().material = _material[1]; ;
    }
    public void OnClick_Red() {
        this.GetComponent<Renderer>().material = _material[2];
    }

    public void OnClick_Move_T() {
        isMove = true;
    }
    public void OnClick_Move_F() {
        isMove = false;
    }
    void Update() {
        if (isMove) {
            this.gameObject.transform.Translate(0.05f, 0, 0);
        }
        
    }
}
