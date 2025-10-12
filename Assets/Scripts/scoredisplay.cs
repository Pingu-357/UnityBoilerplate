using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoredisplay : MonoBehaviour
{
    public Text displayField;
// im crine bruh
    public ScoreManager displayedscore;

    void Update()
    {
        displayedscore = FindObjectOfType<ScoreManager>();
        displayField.text = "Score: " + displayedscore.ToString();
    }
}
