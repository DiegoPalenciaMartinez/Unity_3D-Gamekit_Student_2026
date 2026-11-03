using Gamekit3D;
using UnityEngine;

namespace _3DGamekitLite.Scripts.CustomScripts.Diego
{
    public class SurvivalMod : MonoBehaviour
    {
        [SerializeField] public float hunger;
        [SerializeField] private float speed;
        [SerializeField]  private int damage;
        
        private GameObject player;
        private Damageable.DamageMessage msg;
        public float timer;
        
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            
            hunger = 0;
            timer = 5f;
            
            msg = new Damageable.DamageMessage()
            {
                amount = damage,
                damager = this,
                direction = Vector3.up,
                stopCamera = false
            };
        }

        void Update()
        {
            hunger += (Time.deltaTime * speed);
            Debug.Log("Hunger: " + hunger);

            timer -= Time.deltaTime;
                
            if (hunger > 100 && timer <= 0)
            {
                player.GetComponent<Damageable>().ApplyDamage(msg);
                timer = 5f;
            }
            
        }

        public void ResetHunger()
        {
            hunger = 0;
            timer = 5f;
        }
    }
}
