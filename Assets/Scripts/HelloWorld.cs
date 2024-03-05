using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int speed = 12;
    public GameObject helloText;
    public string MyText = "Hello World 2";
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        Application.targetFrameRate = 30;
        helloText.GetComponent<TextMeshPro>().text = "Hello World 2";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1,0,0)* Time.deltaTime * speed);
    }
}
