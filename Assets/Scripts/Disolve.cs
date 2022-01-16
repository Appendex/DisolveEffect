using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disolve : MonoBehaviour
{
    Material material;

    bool isDisolving = false;
    float fade = 1f;

    private void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        // Is Disolving
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            isDisolving = true;
        }

        if(isDisolving)
        {
            fade -= Time.deltaTime;
            
            if(fade <= 0f)
            {
                fade = 0f;
                isDisolving = false;
            }

            material.SetFloat("_Fade", fade);
        }
    }
}
