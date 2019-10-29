using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaener : MonoBehaviour
{
    public GameObject pinPrefabs;
    private void Update() {
        if(Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
    }


    void SpawnPin(){
        Instantiate(pinPrefabs,transform.position,transform.rotation);
    }
}
