﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoints = 30f;

        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0f);
            print("health: " + healthPoints);
            if (healthPoints <= 0)
            {
                ProcessDeath();
            }
        }

        private void ProcessDeath()
        {
            GetComponent<Animator>().SetTrigger("death");
        }
    }
}
