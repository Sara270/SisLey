using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLey_ProyectoNo._1
{
    class Lista
    {
        private Asesor[] listaAsesor;
        private Reglamentos[] listaReglamentos;
        private int cima=-1;
        private int limite;
        private bool vacio;
        private bool lleno;

        private Asesor valor;

        public Lista(bool Diferenciar)
        {
            int  i = 0;
            if (Diferenciar == true){
                listaAsesor = new Asesor[8];
            }
            else{
                listaReglamentos = new Reglamentos[5];
            }
        }

        private bool Valida_vacia_Asesor()
        {
            if (listaAsesor[0] == default(Asesor))
            {
                vacio = true;
            }
            else
            {
                vacio = false;
            }
            return vacio;
        }

        private bool Valida_vacia_Reglamentos()
        {
            if (listaReglamentos[0] == default(Reglamentos))
            {
                vacio = true;
            }
            else
            {
                vacio = false;
            }
            return vacio;
        }

        private bool Valida_lleno_Asesor()
        {
            if (listaAsesor[0] != default(Asesor))
            {
                lleno = true;
            }
            else
            {
                lleno = false;
            }
            return lleno;
        }

        private bool Valida_lleno_Reglamentos()
        {
            if (listaReglamentos[0] != default(Reglamentos))
            {
                lleno = true;
            }
            else
            {
                lleno = false;
            }
            return lleno;
        }

        public void Add_Asesor(Asesor d)
        {
            if (Valida_vacia_Asesor() && cima < 0)
            {
                listaAsesor[0] = d;
                cima++;
            }
            else
            {
                if (cima < limite)
                {
                    cima++;
                    listaAsesor[cima] = d;
                }
            } 
        }
        public void Add_Reglamentos(Reglamentos e)
        {
            if (Valida_vacia_Reglamentos() && cima < 0)
            {
                listaReglamentos[0] = e;
                cima++;
            }
            else
            {
                if (cima < limite)
                {
                    cima++;
                    listaReglamentos[cima] = e;
                }
            }
        }

        // Revisar 

        public string Remove(int puntero)
        {
            if (Valida_lleno_Asesor() && puntero <= cima)
            {
                if (puntero == cima)
                {
                    valor = listaAsesor[puntero];
                    listaAsesor[cima] = default(Asesor);
                    cima--;
                }
                else
                {
                    valor = listaAsesor[puntero];
                    for (int i = puntero; i < cima; i++)
                    {
                        listaAsesor[i] = listaAsesor[i + 1];
                    }
                    listaAsesor[cima] = default(Asesor);
                    cima--;
                }
            }
            else
            {
                Console.WriteLine("La lista no posee valor en la posicion especificada");
            }
            return "valor"; //valor;
        }


    }
}
