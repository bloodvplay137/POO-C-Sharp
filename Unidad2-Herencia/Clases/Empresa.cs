using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Herencia.Clases
{
	class Empresa
	{
		private string rfc;

		public string RFC
		{
			get { return rfc; }
			set { rfc = value; }
		}
		private string razonSocial;

		public string RazonSocial
		{
			get { return razonSocial; }
			set { razonSocial = value; }
		}
		private string gerente;

		public string Gerente
		{
			get { return gerente; }
			set { gerente = value; }
		}
		List<Departamento> listaDepartamentos;
		public Empresa(){
			listaDepartamentos = new List<Departamento>();
		}
		public void insertar(Departamento departamento) {
			listaDepartamentos.Add(departamento);
		}
		public IEnumerator<Departamento> GetEnumerator()
		{
			return listaDepartamentos.GetEnumerator();
		}
		public void eliminarDepartamento(int index)
		{
			listaDepartamentos.RemoveAt(index);
			
		}
		~Empresa(){
			listaDepartamentos.Clear();
		}
	}
}
