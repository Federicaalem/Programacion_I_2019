﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploMatriz2
{
    /// <summary>
    /// Clase que gestiona los elemntos en una lista
    /// </summary>
    public class lista
    {
        //propiedad que contiene la lista
        public System.String[] Lista = new System.String[1];
        //cantidad de elementos cargados en la lista
        public System.Int32 CantElem = 0;

        /// <summary>
        /// carga un elemento nuevo a la lista
        /// </summary>
        /// <param name="aElemento">Elemento a cargar en la lista</param>
        /// <returns></returns>
        public System.String CargarLista(System.String aElemento)
        {
            System.String mRes = "";

            if (CantElem == Lista.Length)
            {
                Lista = Redimensionar();
            }
            if (BuscaPorNombre(aElemento) == -1)
            {
                Lista[CantElem] = aElemento;
                CantElem++;
                mRes = Listado();
            }
            else
            {
                mRes = "El elemento " + aElemento + " ya existe";
            }
            return mRes;
        }

        /// <summary>
        /// devuelve en un string los elemntos de laa lista
        /// </summary>
        /// <returns></returns>
        public System.String Listado()
        {
            System.String Res = "Los lista contiene:\r\n";
            foreach (System.String mElemento in Lista)
            {
                if (mElemento == null)
                {
                    break;
                }
                Res = Res + mElemento + "\r\n";
            }

            return Res;

        }

        /// <summary>
        /// devuelve la posicion donde se encuentra un elemento dentro de la lista, 
        /// si el valor devuelto es -1 significa que no se encontro
        /// </summary>
        /// <param name="aElemento">elemnto a buscar en la lista</param>
        /// <returns></returns>
        public System.Int32 BuscaPorNombre(System.String aElemento)
        {
            System.Int32 mREs = -1;

            for (int i = 0; i < Lista.Length; i++)
            {
                if (Lista[i] == aElemento)
                {
                    mREs = i + 1;
                    break;
                }
            }
            return mREs;
        }

        /// <summary>
        /// redimensiona la lista para cuando se necesita un lugar para cargar un  nuevo elemento 
        /// </summary>
        /// <returns></returns>
        private System.String[] Redimensionar()
        {
            System.String[] Res = new System.String[Lista.Length + 1];
            System.Int32 j = 0;
            foreach (System.String mElemento in Lista)
            {
                Res[j] = mElemento;
                j++;
            }

            return Res;
        }

        public System.String BuscarPorPosicion(System.String aPosicion)
        {
            System.String mRes = "";

            System.Int32 mPosicion = System.Convert.ToInt32(aPosicion) - 1;
            if (!(mPosicion > Lista.Length - 1 || mPosicion < 0))
            {
                mRes = Lista[mPosicion];
            }
            return mRes;
        }

        /// <summary>
        /// Borra un elemento de la lista y reacomoda los demas elementos
        /// </summary>
        /// <param name="aElemento">Texto de la lista a borra</param>
        /// <returns></returns>
        public System.String BorraElemento(System.String aElemento)
        {
            System.String mRes = "";
            System.Int32 mPosicion = this.BuscaPorNombre(aElemento)-1;

            if (mPosicion == -1)
            {
                mRes = "No se pudo borrar el elemento " 
                    + aElemento 
                    + " por no estar en la lista.";
            }
            else
            {
                this.Lista[mPosicion] = null;
                for (int i = mPosicion; i < CantElem - 1; i++)
                {
                    this.Lista[i] = this.Lista[i + 1];
                    this.Lista[i + 1] = null;
                }
                CantElem = CantElem - 1;
                mRes = this.Listado();
            }
            return mRes;
        }

        public System.String OrdenarAlfa()
        {
            System.String mRes = "";
            if (this.Lista[1].CompareTo(this.Lista[0])>0)
            {
                mRes="mayor";
                //mRes = this.Lista[1]..Trim(System.Convert.ToChar("1"));
            }
            else if (this.Lista[1].CompareTo(this.Lista[0]) == 0)
            {
                mRes = "igual";
            }
            else if (this.Lista[1].CompareTo(this.Lista[0]) < 0)
            {
                mRes = "menor";
            }
            else
            {
                mRes = "NO SE";
            }
            return mRes;
        }
    }
}

//0 pepe
//1 juan
//2 rodri
//3 pepito
//4 null

//0 pepe
//1 null
//2 rodri
//3 pepito
//4 null


//0 pepe
//1 rodri
//2 null
//3 pepito
//4 null

//0 pepe
//1 rodri
//2 pepito
//3 null
//4 null








