using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class GetWandPos : MonoBehaviour
{
    private Vector3 TipPos;
    public TMP_Text posText;

    // Start is called before the first frame update
    void Start()
    {
        TipPos.Set(0, 0, 0);
        posText.text = TipPos.ToString("F3");
    }

    // Update is called once per frame
    void Update()
    {
        TipPos = GameObject.Find("WandTip1").transform.position;
        posText.text = TipPos.ToString("F3");
    }
}