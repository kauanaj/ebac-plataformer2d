using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ebac.Core.Singleton
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour // Limita para receber apenas como parametro scripts mono behaviour
    {
        public static T instance;

        public void Awake()
        {
            if (instance == null) // Verifica se ja existe uma instancia do Game object na cena 
            {
                instance = GetComponent<T>(); // pega o componente e atribui a instancia
            }
            else
                Destroy(gameObject);
        }
    }
}

