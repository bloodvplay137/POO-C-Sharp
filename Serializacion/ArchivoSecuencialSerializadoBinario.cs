using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;



namespace Serializacion
{
	[Serializable]
	class ArchivoSecuencialSerializadoBinario<T>
	{
		private string _strNombreArchivo;

		public string NombreArchivo
		{
			get { return _strNombreArchivo; }
			set { _strNombreArchivo = value; }
		}
		private System.IO.FileStream flujo;
		System.Runtime.Serialization.Formatters.Binary.BinaryFormatter seriador;
		public ArchivoSecuencialSerializadoBinario(string strNombreArchivo)
		{
			NombreArchivo = strNombreArchivo;
		}
		private void Crear()
		{
			flujo = new FileStream(NombreArchivo, FileMode.Create);
			seriador = new BinaryFormatter();
		}

		public void AbrirEnModoEscritura()
		{
			if (File.Exists(NombreArchivo))
			{
				flujo = new FileStream(NombreArchivo, FileMode.Append);
				seriador = new BinaryFormatter();
			}
			else {
				Crear();
			}
		}
		public void AbrirEnModoLectura()
		{
			if (File.Exists(NombreArchivo))
			{
				flujo = new FileStream(NombreArchivo, FileMode.Open);
				seriador = new BinaryFormatter();
			}
			else
			{
				throw new Exception($"No existe el arhivo {NombreArchivo}");
			}
		}

		public void AbrirEnModoLecturaYEscritura()
		{
			if (File.Exists(NombreArchivo))
			{
				flujo = new FileStream(NombreArchivo, FileMode.Open, FileAccess.ReadWrite);

			}
			else
			{
				Crear();
			}
			seriador = new BinaryFormatter();
		}
		public void GrabarObjeto(T miObjeto)
		{
			seriador.Serialize(flujo, miObjeto);
		}

		public T LeerObjeto()
		{
			T miObjeto;
			miObjeto = (T)seriador.Deserialize(flujo);
			return (miObjeto);
		}
		public bool Finarchivo
		{
			get
			{
				if (flujo.Position >= flujo.Length)
				{
					return true;
				}
				else return false;
			}
		}
		public void Cerrar()
		{
			if (flujo!=null)
			{
				flujo.Close();
			}
		}
		~ArchivoSecuencialSerializadoBinario()
		{
			Cerrar();
		}

	}
}
