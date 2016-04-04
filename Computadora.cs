using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio18
{
    class Computadora
    {
        private bool _estaEncendida;
        private Enumerados.EMarca _marca;
        private float _peso;
        private Enumerados.EProcesador _procesador;

        public Computadora(bool Encendida, Enumerados.EMarca Marca, float Peso, Enumerados.EProcesador Procesador)
        {
            this._estaEncendida = Encendida;
            this._marca = Marca;
            this._peso = Peso;
            this._procesador = Procesador;
        }

        public bool getEstaEncendida()
        {
            return this._estaEncendida;
        }

        public Enumerados.EMarca getMarca()
        {
            return this._marca;
        }

        public float getPeso()
        {
            return this._peso;
        }

        public Enumerados.EProcesador getProcesador()
        {
            return this._procesador;
        }

        public void setEstaEncendida(bool encender)
        {
            this._estaEncendida = encender;
        }

        public void setMarca(Enumerados.EMarca marca)
        {
            this._marca = marca;
        }

        public void setPeso(float peso)
        {
            this._peso = peso;
        }

        public void setProcesador(Enumerados.EProcesador procesador)
        {
            this._procesador = procesador;
        }
    }
}

namespace Enumerados
{
    public enum EMarca
    {
        Asus, Apple, Samsung, Toshiba, IBM
    }

    public enum EProcesador
    {
        Intel_Core_i7, ADM_Phenom_II, ADM_Athlon_II, Intel_Celeron_430, ADM_Sempron_145
    }
}
