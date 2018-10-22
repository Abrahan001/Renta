using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class Clientes_BL
    {
       
        public BindingList<Clientes> ListaClientes { get; set; }
        public Clientes_BL()
        {
            ListaClientes = new BindingList<Clientes>();
            var cliente1 = new Clientes();
            cliente1.Id = 1;
            cliente1.Nombre = "Juan";
            cliente1.Correo = "juanhn12@gmail.com";
            cliente1.Telefono = 98223311;
            cliente1.Direccion = "San Pedro sula";
            cliente1.Activar = true;

            ListaClientes.Add(cliente1);

            var cliente2 = new Clientes();
            cliente2.Id = 2;
            cliente2.Nombre = "Karla";
            cliente2.Correo = "karlahn12@gmail.com";
            cliente2.Telefono =99675845;
            cliente2.Direccion = "La Ceiba";
            cliente2.Activar = true;

            ListaClientes.Add(cliente2);

            var cliente3 = new Clientes();
            cliente3.Id = 3;
            cliente3.Nombre = "Luis";
            cliente3.Correo = "luishn12@gmail.com";
            cliente3.Telefono = 97786543;
            cliente3.Direccion = "San Juan";
            cliente3.Activar = true;

            ListaClientes.Add(cliente3);

            var cliente4 = new Clientes();
            cliente4.Id = 4;
            cliente4.Nombre = "Jose";
            cliente4.Correo = "jons@gmail.com";
            cliente4.Telefono = 32762727;
            cliente4.Direccion = "Olancho";
            cliente4.Activar = true;

            ListaClientes.Add(cliente4);

            var cliente5 = new Clientes();
            cliente5.Id = 5;
            cliente5.Nombre = "Luisa";
            cliente5.Correo = "luisahn1322@gmail.com";
            cliente5.Telefono = 356674345;
            cliente5.Direccion = "Olanchito";
            cliente5.Activar = true;

            ListaClientes.Add(cliente5);

        }

        public object GuardarClientes(object cliente)
        {
            throw new NotImplementedException();
        }

        public BindingList<Clientes> ObtenerClientes()
        {
            return ListaClientes;
        }
        public Resultado GuardarClientes(Clientes cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso==false)
            {
                return resultado;
            }
            if (cliente.Id ==0)
            {
                cliente.Id = ListaClientes.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }
        public void Agregarcliente()
        {
            var nuevoCliente = new Clientes();
            ListaClientes.Add(nuevoCliente);

        }
        public bool EditarCliente(int id)
        {

            foreach (var clientess in ListaClientes)
            {
                if (clientess.Id == id)
                {


                 
    }
            }
            return false;
        }
   
        public bool EliminarCliente(int id)
        {
            foreach (var clientess in ListaClientes)
            {
                if (clientess.Id==id)
                {
                    ListaClientes.Remove(clientess);
                    return true;
                }
            }
            return false;
        }
        private Resultado Validar(Clientes cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            if (string.IsNullOrEmpty(cliente.Nombre)==true)
            {
                resultado.Mensaje = "Ingrese el Nombre";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(cliente.Correo) == true)
            {
                resultado.Mensaje = "Ingrese el Correo Electronico";
                resultado.Exitoso = false;
            }
            if (cliente.Telefono <= 0)
            {
                resultado.Mensaje = "Ingrese los 8 digitos de su numero telefonico";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(cliente.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese la Direccion";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }
 
       public class Clientes
    {
        public int Id { get; set; }
        public string  Nombre{ get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activar { get; set; }
    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

} 
