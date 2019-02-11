using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCell : MonoBehaviour
{
    virtual protected void OnTap() {}
    virtual protected void OnHold() {}
    virtual protected void OnDragOn(DraggableIcon icon) {}
    virtual protected void OnDragOff() {}
}
