using UnityEngine;
using System.Collections;

public class FlickerLight : MonoBehaviour
{
    [SerializeField] private Light targetlight;
    [SerializeField] private float minTime = 0.2f;
    [SerializeField] private float maxTime = 0.5f;
    //[SerializeField] float time = 0.5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Flicker());
    }

    IEnumerator Flicker(){
        while (true){
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            targetlight.enabled = !targetlight.enabled;
        }
        
        //GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
    }
}
