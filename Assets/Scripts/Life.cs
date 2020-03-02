using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public static int lifeAmount;
    private Text lifeText;

    // Start is called before the first frame update
    void Start()
    {
        lifeText = GetComponent<Text>();
        lifeAmount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = " " + lifeAmount;
    }
}
