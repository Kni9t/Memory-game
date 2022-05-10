using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;
    public Color highlightColor = Color.cyan;

    public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = highlightColor;
        }
    }
    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }
    }

    public void OnMouseDown()
    {
        transform.localScale = new Vector3(1.6f, 1.6f, 1.6f);
    }
    public void OnMouseUp()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        if (targetObject != null)
        {
            targetObject.SendMessage(targetMessage);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
