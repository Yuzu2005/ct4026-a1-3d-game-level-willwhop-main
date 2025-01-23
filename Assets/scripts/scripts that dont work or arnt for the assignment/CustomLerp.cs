//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CustomLerp : MonoBehaviour
//{
//    float z;

//    public void LerpButton()
//    {

//        StartCoroutine(LerpFloat());
//    }

//    IEnumerator LerpFloat()
//    {
//        float time = 0;
//        while (time < 1)
//        {
//            float t = Mathf.Pow(time, 3);
//            z = -5 + (5 - -5) * t;
//            time += time.deltaTime;
//            yeild return null;
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        transform.position = new Vector3(0, 0, z);
//    }
//}
