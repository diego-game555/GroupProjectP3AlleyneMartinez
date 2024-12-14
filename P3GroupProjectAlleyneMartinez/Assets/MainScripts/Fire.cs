using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
   public GameObject targetObject;
   private float timer = 0f;
    private bool isObjectActive = false;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (!isObjectActive && timer >= 3f)
        {
            targetObject.SetActive(true);
            isObjectActive = true;
            timer = 0f;
        }
        else if (isObjectActive && timer >= 3f)
        {
            targetObject.SetActive(false);
            isObjectActive = false;
            timer = 0f;
        }
    }
}
