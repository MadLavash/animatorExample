using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testZone : MonoBehaviour {

    [Range(-100f, 100f)]
    public float positionX;
    [Range(-100f, 100f)]
    public float positionY;
    [SerializeField]
    private RectTransform testRect;
    private Vector2 anchoredPos;

    private void Update()
    {
        SetPosition();
    }

    void SetPosition()
    {
        testRect.anchoredPosition = new Vector2(positionX, positionY);
    }


}
