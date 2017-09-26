using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLey_ProyectoNo._1
{
    class Grupos
    {
        private Lista listaAsesor;
	private Lista listaReglamentos;
	private Ley  [] listaLeyes;
	private Parlamentario parla;
    
	
	
	public Lista getListaAsesor() {
		return listaAsesor;
	}
	public void setListaAsesor(Lista listaAsesor) {
		this.listaAsesor = listaAsesor;
	}
	public Lista getListaReglamentos() {
		return listaReglamentos;
	}
	public void setListaReglamentos(Lista listaReglamentos) {
		this.listaReglamentos = listaReglamentos;
	}
	public Ley[] getListaLeyes() {
		return listaLeyes;
	}
	public void setListaLeyes(Ley[] listaLeyes) {
		this.listaLeyes = listaLeyes;
	}
	public Parlamentario getParla() {
		return parla;
	}
	public void setParla(Parlamentario parla) {
		this.parla = parla;
	}
	
	public void Prestamo () {
		
	}
	public void PrestamosLotes(Ley [] listLeyes) {
		
	}
	public void Devolucion() {
		
	}
	public void InformePorLey() {
	    	
	}
	public void InformePorGrupo() {
		
	}
    }
}
