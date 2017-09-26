using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLey_ProyectoNo._1
{
    class Cola
    {
        private Asesor[] listaAsesor;
        private Reglamentos[] listaReglamentos;
        private int cima=-1;
        private int limite;
        private bool vacio;
        private bool lleno;
        
        /// /////////////////////
       
        private Asesor inicio;

        public Cola(bool Diferenciar)
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

        public void Enqueue_Asesor(Asesor h)
        {
            if (Valida_vacia_Asesor() && cima < 0)
            {
                listaAsesor[0] = h;
                cima++;
            }
            else
            {
                if (cima < limite)
                {
                    cima++;
                    listaAsesor[cima] = h;
                }
            }
        }
        public void Enqueue_Asesor(Reglamentos k)
        {
            if (Valida_vacia_Reglamentos() && cima < 0)
            {
                listaReglamentos[0] = k;
                cima++;
            }
            else
            {
                if (cima < limite)
                {
                    cima++;
                    listaReglamentos[cima] = k;
                }
            }
        }
        public string Dequeue_Asesor()
        {
            if (Valida_lleno_Asesor())
            {
                inicio = listaAsesor[0];
                for (int i = 0; i < cima; i++)
                {
                    listaAsesor[i] = listaAsesor[i + 1];
                }
                listaAsesor[cima] = default(Asesor);
                cima--;
            }
            else
            {
                Console.WriteLine("La cola esta vacia");
            }
            return "inicio"; //inicio
        }

    }
}
