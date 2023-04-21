using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.TurnBasedCombat.s01
{
    public class DamageControl : MonoBehaviour
    {
        float time;
        public Text textDamage;
        void Start()
        {
            textDamage.text = "-" + ButtonControl.damage;
        }

        void Update()
        {
            time += Time.deltaTime;
            gameObject.transform.Translate(0, 200 * Time.deltaTime, 0);
            if (time > 0.5f)
                Destroy(gameObject);
        }
    }
}
