using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Fade : MonoBehaviour
{
  public SpriteRenderer sprite;
  private float time = 20.0f;
  private float startValue = 0.0f;
  void Start()
  {

  }

  void Update ()
  {
    
  }
  
  public IEnumerator FadeTo()
  {
      float alpha = transform.GetComponent<Renderer>().material.color.a;
      for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / time)
      {
          Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha,startValue,t));
          transform.GetComponent<Renderer>().material.color = newColor;
          yield return null;
      }
  }
}
