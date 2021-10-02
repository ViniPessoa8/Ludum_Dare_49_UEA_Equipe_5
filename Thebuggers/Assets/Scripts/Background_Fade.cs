using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Fade : MonoBehaviour
{
    private SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update ()
  {
    StartCoroutine(FadeTo(0.0f, 20.0f));
  }
  
  IEnumerator FadeTo(float aValue, float aTime)
  {
      float alpha = transform.GetComponent<Renderer>().material.color.a;
      for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
      {
          Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha,aValue,t));
          transform.GetComponent<Renderer>().material.color = newColor;
          yield return null;
      }
  }
}
