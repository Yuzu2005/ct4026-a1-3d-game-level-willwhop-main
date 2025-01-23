using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLerp : MonoBehaviour
{
    bool lerping;
    float lerpfloat;

    public enum eases
    {
        easeInSine, easeOutSine
    }

    public eases myEase;

    public void LerpButton()
    {
        if (lerping == false)
        {
            StartCoroutine(LerpFloat(myEase));
        }
    }

    IEnumerator LerpFloat (eases ease)
    {
        lerping = true;
        float time = 0;
        while(time < 1)
        {
            float perc = 0;
            if (ease == eases.easeInSine)
            {
                perc = 1f - Mathf.Cos(time * Mathf.PI * 0.5f);
            }
            else if (ease == eases.easeInSine)
            {
                perc = Mathf.Sin(time * Mathf.PI * 0.5f);
            }
            lerpfloat = Lerp(0, 10, perc);
            time += Time.deltaTime;
            yield return null;
        }
        lerping = false;
    }
    public static float Lerp (float startValue, float endValue, float t)
    {
        return (startValue + (endValue - startValue) * t);
    }

    // Start is called before the first frame update
    private void Start()
    {
        transform.position = new Vector3(-7, 15, lerpfloat - 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
