using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColourChanger : MonoBehaviour
{

    private Renderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        // Subscribe to GameManager to recieve messages
        // from the WebSocket:
        GameManager.OnMessageRecieved += GameManager_OnMessageRecieved;
    }

    private void GameManager_OnMessageRecieved(string message)
    {
        print($"Got Message: {message}");

        ChangeColor(message);
    }

    public void ChangeColor(string colorName)
    {

        ColorUtility.TryParseHtmlString(colorName, out var MyColour);

        _renderer.material.color = MyColour;
    }
}
