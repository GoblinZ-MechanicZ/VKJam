using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private Vector3 OnHoverPopup;
    [SerializeField] private float hoverAnimationTime = 0.5f;
    
    private IEnumerator doHover;

    public void OnHoverEnter() {
        if(doHover != null) {
            StopCoroutine(doHover);
        }

        doHover = DoHover(true);
    }

    public void OnHoverExit() {

    }

    private IEnumerator DoHover(bool show) {
        float hoverTimer = (show) ? 0 : hoverAnimationTime;

        while(hoverTimer > ((show) ? hoverAnimationTime : 0)) {
            if(show) hoverTimer += Time.deltaTime; 
            else hoverTimer -= Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
    }
}
