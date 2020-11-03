using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTele : MonoBehaviour
{
    public GameObject startPanel;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Teleprompter.isPaused = !Teleprompter.isPaused;
        }
        if (!Teleprompter.isPaused)
        {
            gameObject.transform.position += Vector3.up / 15 * Options.speed;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.GetComponent<Text>().text = "";
            Teleprompter.Manage(startPanel, true);
        }
    }
}
