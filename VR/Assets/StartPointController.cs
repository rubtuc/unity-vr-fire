using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPointController : MonoBehaviour
{
    // define 3 public variables - we can then assign their color values in the inspector.
    public Color red;
    public Color yellow;
    public Color purple;

    // reference to the material we want to change the color of.
    Material material;

    /// Awake is called when the script instance is being loaded.
    void Awake()
    {
        // get the material that is used to render this object (via the MeshRenderer component)
        material = GetComponent<MeshRenderer>().material;
    }

    //协程是（貌似）与其余任务并行运行的函数，我们希望它在延迟后变为绿色
    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(0.5f);
        material.color = red;
    }

    /// OnTriggerEnter is called when the Collider 'other' enters the trigger.
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Countdown());//协程开始
        material.color = yellow;
    }

    /// OnTriggerExit is called when the Collider 'other' has stopped touching the trigger.
    void OnTriggerExit(Collider other)
    {
        StopAllCoroutines();//协程结束
        material.color = purple;
    }
}