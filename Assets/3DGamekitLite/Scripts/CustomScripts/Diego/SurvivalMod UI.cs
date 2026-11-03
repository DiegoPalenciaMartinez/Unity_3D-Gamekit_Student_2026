using UnityEngine;
using UnityEngine.UI;

namespace _3DGamekitLite.Scripts.CustomScripts.Diego
{
    public class SurvivalModUI : MonoBehaviour
    {
        [SerializeField] private SurvivalMod s;
        [SerializeField] private Slider slider;
        
        void Start()
        {
            slider.value = 1;
            slider.gameObject.SetActive(true);
        }
        
        void Update()
        {
            slider.value =  Mathf.Clamp((1 - (s.hunger / 100)), 0f, 1f);
        }
        
    }
}
