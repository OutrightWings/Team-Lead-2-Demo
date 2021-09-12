using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public static Vector2 topRight;

    // Start is called before the first frame update
    void Start()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        if (this.tag == "Bottom")
        {
            transform.position = new Vector2(0, bottomLeft.y);
        }
        else if (this.tag == "Top")
        {
            transform.position = new Vector2(0, topRight.y);
        }
        else if (this.tag == "Left")
        {
            transform.position = new Vector2(bottomLeft.x, 0);
        }
        else if (this.tag == "Right")
        {
            transform.position = new Vector2(topRight.x, 0);
        }
    }
}
