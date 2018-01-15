using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class FadeLevel : MonoBehaviour {

    public Image image;
    public void Awake()
    {
        if (GetComponent<Image>() != null)
        {
            image = GetComponent<Image>();
        }
        else
        {
            Debug.LogWarning("Please make sure an image is on the same gameobject!");
        }
    }

    public void FadeToOpaque(float time)
    {
        StartCoroutine(FadeToOpaqueCoroutine(time, 1));
    }

    public void FadeToTransparent(float time)
    {
        StartCoroutine(FadeToTransparentCoroutine(time, 0));
    }

    private IEnumerator FadeToOpaqueCoroutine(float time, float targetAlpha)
    {
        float currentAlpha = image.color.a;
        while (image.color.a < targetAlpha)
        {
            float f = Time.deltaTime / time * targetAlpha;
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + Time.deltaTime / time * targetAlpha);
            yield return null;
        }
        image.color = new Color(image.color.r, image.color.g, image.color.b, targetAlpha);
    }

    private IEnumerator FadeToTransparentCoroutine(float time, float targetAlpha)
    {
        float currentAlpha = image.color.a;
        while (image.color.a > targetAlpha)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a - Time.deltaTime / time * targetAlpha);
            yield return null;
        }
        image.color = new Color(image.color.r, image.color.g, image.color.b, targetAlpha);
    }
}
