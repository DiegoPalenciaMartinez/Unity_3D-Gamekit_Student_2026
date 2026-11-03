using Gamekit3D;
using UnityEngine;

namespace _3DGamekitLite.Scripts.CustomScripts.Diego
{
    public class SurvivalMod : MonoBehaviour
    {
        [SerializeField] private float hunger;
        [SerializeField] private float speed;
        [SerializeField]  private int damage;
        [SerializeField] public GameObject player;
        
        Damageable.DamageMessage msg;
        private Damageable d;
        
        public SurvivalMod()
        {
            hunger = 0;
            
            msg = new Damageable.DamageMessage()
            {
                amount = damage,
                damager = this,
                direction = Vector3.up,
                stopCamera = false
            };
            
        }

        void Start()
        {
           if(player != null) d = player.GetComponent<Damageable>(); 
        }
        void Update()
        {
            hunger += (Time.deltaTime * speed);
            Debug.Log("Hunger: " +  hunger);
            
            if (hunger > 100)
            {
                if (d != null)
                {
                    
                    d.ApplyDamage(msg);
                    hunger = 0;
                }
                
                
            }
        }
        
        
    }
}
