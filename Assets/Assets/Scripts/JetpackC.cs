using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackC : MonoBehaviour
{
    public Transform PlatformTransform;
    public Transform PlayerTransform;
    public GameObject Platform;

    public bool isRising;

    // Start is called before the first frame update
    void Start()
    {
        Platform.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            JetpackUp(); // Start coroutine directly
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            StopJetpack(); // Start coroutine directly
        }
    }

    IEnumerator JetpackUp()
    {
        isRising = true;
        Platform.transform.SetParent(PlatformTransform);
        Platform.SetActive(true);
        yield return null; // Add this line
    }

    IEnumerator StopJetpack()
    {
        isRising = false;
        Platform.transform.SetParent(PlayerTransform);
        yield return new WaitForSeconds(0.1f); // Add this line
        Platform.SetActive(false);
        PlatformTransform.DetachChildren();
        yield return null; // Add this line
    }
}