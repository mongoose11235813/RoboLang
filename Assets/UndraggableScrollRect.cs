using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

/// <summary>
/// A scroll rect with mouse dragging disabled.
/// </summary>
public class UndraggableScrollRect : UnityEngine.UI.ScrollRect
{
    public override void OnBeginDrag(PointerEventData eventData)
    {
    }
    public override void OnDrag(PointerEventData eventData)
    {
    }
    public override void OnEndDrag(PointerEventData eventData)
    {
    }
}
