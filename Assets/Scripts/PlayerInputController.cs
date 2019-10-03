using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{

    public GameObject Car;
    public string Forward;
    public string Left;
    public string Right;
    public string Down;

    private AutoController _AutoController;

    // Start is called before the first frame update
    void Start()
    {
        _AutoController = Car.GetComponent<AutoController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(Forward))
        {
            _AutoController.Forward = true;
        } else
        {
            _AutoController.Forward = false;
        }
        if (Input.GetButton(Left))
        {
            _AutoController.Left = true;
        } else
        {
            _AutoController.Left = false;
        }
        
        if (Input.GetButton(Right))
        {
            _AutoController.Right = true;
        } else
        {
            _AutoController.Right = false;
        }

        if (Input.GetButton(Down))
        {
            _AutoController.Down = true;
        }
        else
        {
            _AutoController.Down = false;
        }
    }
}
