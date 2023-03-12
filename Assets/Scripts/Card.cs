using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private Vector3 OnHoverPopup;
    [SerializeField] private float hoverAnimationTime = 0.5f;
    
    public void OnHoverEnter() {
        
    }

    public void OnHoverExit() {

    }

    private IEnumerator DoHover() {
        float hoverTimer = hoverAnimationTime;

        while(hoverTimer > 0) {
            hoverTimer -= Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
    }
}
