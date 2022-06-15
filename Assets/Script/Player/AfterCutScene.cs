using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AfterCutScene : MonoBehaviour
{
        [SerializeField] private PlayerInput _player;
        private bool isload = false;
        public void isLoad(GameObject timeline)
        {
            timeline.SetActive(!isload);
        } 
    public void onCutScene(bool isOn)
    {
        _player.enabled = isOn;
        isload = isOn;
        
    }
}
