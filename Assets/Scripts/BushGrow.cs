using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGrow : MonoBehaviour
{

    public float speed = 2f;
    public float minRefractoryTime = 5f;
    public float maxRefractoryTime = 20f;

    private float timeToNextGrow;
    private float timeElapsed;

    private bool growing = false;
    // Start is called before the first frame update
    void Start()
    {
        SetTimeToNextGrow();
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= timeToNextGrow && !growing) {
            StartCoroutine(Grow());
        }
        
    }

    private IEnumerator Grow() {
        growing = true;
        float startScale;
        float targetScale;
        float growTime = 0f;

        if (transform.localScale.x <= 0.001f) {
            startScale = 0f;
            targetScale = 1f;
        }
        else {
            startScale = 1f;
            targetScale = 0f;
        }

        while (growTime < speed) {
            growTime += Time.deltaTime;
            float scale = Mathf.Lerp(startScale, targetScale, growTime / speed);
            transform.localScale = new Vector3(scale, scale, scale);
            yield return null;
        }

        growing = false;
        timeElapsed = 0f;
        SetTimeToNextGrow();

    }

    private void SetTimeToNextGrow() {
        timeToNextGrow = Random.Range(minRefractoryTime, maxRefractoryTime);
    }
}
