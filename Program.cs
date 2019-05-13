using facturacion.Model;
using facturacion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facturacion
{
    class Program
    {

        static void Main(string[] args)
        {
            byte opcion=0;
            bool finMenu = false;
            bool validadorFormato = false;
            
            do
            {
                validadorFormato = false;
                Console.WriteLine("=================BIENVENIDO AL PROGRAMA DE PRUEBA =================" +
                                 "\n Para continuar seleccione una opción:" +
                                 "\n 1) Crear un cliente\n 2) Crear una dirección\n 3) Crear un albarán" +
                                 "\n 4) Crear una factura\n 6) Listar direcciones \n 7) Listar clientes" +
                                 "\n 8) Listar Albaranes \n 9) Listar facturas \n 0) Salir");
                do
                {
                    try
                    {
                        opcion = byte.Parse(Console.ReadLine());
                        validadorFormato = true;
                    }
                    catch (System.FormatException e)
                    {                      
                            Console.WriteLine("La entrada sólo admite números, vuelva a intentarlo");
                            
                    }catch (System.OverflowException e1)
                    {
                        Console.WriteLine("El valor es demasiado alto, por favor introduzca un nuevo valor.");
                    }
               
                    
                } while (!validadorFormato);


                switch (opcion)
                {
                    case 1: //CREAR UN CLIENTE

                        CrearCliente();
                        break;

                    case 2: //CREAR UNA DIRECCIÓN
                        CrearDireccion();
                        break;


                    case 3: //CREAR UN ALBARÁN
                        CrearAlbaran();
                        break;

                    case 4: //CREAR UNA FACTURA
                        crearFactura();
                        break;

                    //case 5:   //SIN USO

                    case 6: //LISTAR DIRECCIONES
                        ListarDirecciones();
                        break;

                    case 7: //LISTAR CLIENTES
                        ListarClientes();
                        break;

                    case 8: //LISTAR ALBARANES 
                        ListarAlbaranes();
                        break;

                    case 9: //LISTAR FACTURAS
                        ListarFacturas();
                        break;


                    case 0: //SALIR DEL PROGRAMA
                        finMenu = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Debe seleccionar una opcicón válida para continuar");
                        Console.WriteLine("Pulse una tecla para continuar...");
                        Console.Read();
                        break;
                }

            } while (!finMenu);

         
            
           
        }

        public static void CrearCliente()
        {
            FacturacionContext context = new FacturacionContext();
            Console.Clear();
            Console.WriteLine("========================================================\n" +
                              "=================CREACION DE UN NUEVO CLIENTE ==========");
            Console.WriteLine("Por favor a continuación introduzca el nombre del cliente");
            string nombre = Console.ReadLine().ToUpper();
            Console.WriteLine("Por favor a continuación introduzca el apellido del cliente");
            string apellido = Console.ReadLine().ToUpper();

            var cliente = new Cliente
            {
                Nombre = nombre,
                Apellidos = apellido
            };

            context.Cliente.Add(cliente);
            context.SaveChanges();
        }


        public static void ListarClientes()
        {
            FacturacionContext context = new FacturacionContext();
            
            Console.Clear();
            Console.WriteLine("========================================================\n" +
                              "=================LISTADO DE CLIENTES ===================");
            Console.WriteLine("Por favor a continuación introduzca el nombre del cliente");
            var clientes = context.Cliente.ToList();
            foreach (var c in clientes)
            {
                Console.WriteLine("Nombre: " + c.Nombre + "\t\t\tApellidos: " + c.Apellidos);
            }

            Console.WriteLine("Pulse una tecla para continuar...");
            Console.Read();
        }

        public static void ListarDirecciones()
        {
            FacturacionContext context = new FacturacionContext();
            var direcciones = context.Direccion.Include("ID_Cliente");

            Console.Clear();
            Console.WriteLine("========================================================\n" +
                              "=================LISTADO DE DIRECCIONES =================");

            foreach (var d in direcciones)
            {
                Console.WriteLine("Direccion: " + d.Nombre + "\t\t ID_Cliente: " + d.ID_Cliente.Nombre +
                    ", " + d.ID_Cliente.Apellidos +" (" + d.ID_Cliente.ClienteID + ")" );
            }

            Console.WriteLine("Pulse una tecla para continuar...");
            Console.Read();
        }


        public static void ListarAlbaranes()
        {
            FacturacionContext context = new FacturacionContext();
            var albaranes = context.Albaran.Include("ID_Cliente").OrderBy(a=> a.Fecha);

            Console.Clear();
            Console.WriteLine("========================================================\n" +
                              "================= LISTADO DE ALBARANES =================");

            foreach (var a in albaranes)
            {
                Console.WriteLine("Nº: " + a.AlbaranId + "\t ID_Cliente: " + a.Cliente.Nombre +
                    ", " + a.Cliente.Apellidos + " (" + a.Cliente.ClienteID + ") " +
                    "\t Fecha: " + a.Fecha + "\t Importe: " + a.Importe);
            }

            Console.WriteLine("Pulse una tecla para continuar...");
            Console.Read();
        }


        public static void ListarFacturas()
        {
            Console.Clear();
            FacturacionContext context = new FacturacionContext();
            var facturas = context.Factura.Include("ID_Cliente").OrderBy(f => f.Fecha);

            Console.WriteLine("========================================================\n" +
                              "================= LISTADO DE FACTURAS =================");

            foreach (var f in facturas)
            {
                Console.WriteLine("Nº: " + f.FacturaId+ "\t ID_Cliente: " + f.cliente.Nombre +
                    ", " + f.cliente.Apellidos + " (" + f.cliente.ClienteID + ") " +
                    "\t Fecha: " + f.Fecha + "\t Importe: " + f.Importe);
            }

            Console.WriteLine("Pulse una tecla para continuar...");
            Console.Read();


        }


        public static void CrearDireccion()
        {
            byte opcionFacCli = 0;
            bool validadorFormato = false;           
            FacturacionContext context = new FacturacionContext();


            Console.Clear();
            Console.WriteLine("========================================================\n" +
                              "==============CREACION DE UNA NUEVA DIRECCIÓN ==========");
            Console.WriteLine("Previo a la dirección seleccionaremos el cliente que se asociará " +
                                "a la misma.\n Por favor, seleccione una opción:" +
                                "\n1)Introducir ID 2)Buscar por Nombre o apellidos");

            do
            {
                try
                {
                    opcionFacCli = byte.Parse(Console.ReadLine());
                    validadorFormato = true;
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("La entrada sólo admite números, vuelva a intentarlo");

                }
                catch (System.OverflowException e1)
                {
                    Console.WriteLine("El valor es demasiado alto, por favor introduzca un nuevo valor.");
                }


            } while (!validadorFormato);

            Direccion d;
            int id;

            switch (opcionFacCli)
            {
                case 1:
                    validadorFormato = false;
                    do
                    {
                        try
                        {
                            id = int.Parse(Console.ReadLine());
                            validadorFormato = true;

                            d = new Direccion();
                            d.ID_Cliente = context.Cliente.Where(c => c.ClienteID == id).SingleOrDefault();
                            Console.WriteLine("Introcuzca el nombre de la calle");
                            d.Nombre = Console.ReadLine().ToUpper();

                            context.Direccion.Add(d);
                            context.SaveChanges();
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("La entrada sólo admite números, vuelva a intentarlo");

                        }
                        catch (System.OverflowException e1)
                        {
                            Console.WriteLine("El valor es demasiado alto, por favor introduzca un nuevo valor.");
                        }
                    } while (!validadorFormato);
                                        
                    break;

                case 2:

                    Console.WriteLine("Introduzca el nombre, apellido o id por el que buscar al cliente");
                    string busqueda = Console.ReadLine();
                    int cliente = BuscarCliente(busqueda);

                    if(cliente == -1)
                    {
                        Console.WriteLine("El cliente que ha intentado añadir no existe," +
                            " por favor cambie los paramertos de búsqueda e inténtelo de nuevo.");
                    }
                    else
                    {
                        d = new Direccion();
                        d.ID_Cliente = context.Cliente.Where(c => c.ClienteID == cliente).Single();
                        Console.WriteLine("Introcuzca el nombre de la calle");
                        d.Nombre = Console.ReadLine().ToUpper();

                        context.Direccion.Add(d);
                        context.SaveChanges();
                    }

                    List<Cliente> clientes = context.Cliente.Where(c => c.Nombre.Contains(busqueda)
                                                    || c.Apellidos.Contains(busqueda)).ToList<Cliente>();                   


                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Debe seleccionar una opción válida para continuar");
                    Console.WriteLine("Pulse una tecla para continuar...");
                    Console.Read();
                    break;
            }
        }//FIN CREAR DIRECCION

        public static void CrearAlbaran()
        {
            FacturacionContext context = new FacturacionContext();
            Albaran alb = new Albaran();
            Console.Clear();
            Console.WriteLine("========================================================\n" +
                              "=================CREACION DE UN NUEVO ALBARÁN ==========");
            Console.WriteLine("Por favor, introduzca el nombre, apellido o id del cliente");
            string busqueda = Console.ReadLine();
            int cliente = BuscarCliente(busqueda);
            if (cliente == -1)
            {
                Console.WriteLine("El cliente que ha intentado añadir no existe," +
                    " por favor cambie los paramertos de búsqueda e inténtelo de nuevo.");
            }
            else
            {
                alb.Cliente = context.Cliente.Where(c => c.ClienteID == cliente).Single();

                Console.WriteLine("Por favor, introduzca la fecha de creación del albarán. Si no introduce nada el valor por defecto será ahora.");
                string fechaString = Console.ReadLine();
                DateTime fecha;
                if (!DateTime.TryParse(fechaString, out fecha))
                {
                    fecha = DateTime.Now;
                }


                alb.Fecha = fecha;

                Console.WriteLine("Introduzca el importe del albarán");
                alb.Importe = Int32.Parse(Console.ReadLine());

                context.Albaran.Add(alb);
                context.SaveChanges();
            }
           
        }

        public static void crearFactura()
        {
            Console.Clear();
            FacturacionContext context = new FacturacionContext();
            Factura fac = new Factura();
            List<Albaran> albaranes;

            Console.WriteLine("========================================================\n" +
                              "================= CREACION DE UNA FACTURA ==============");

            Console.WriteLine("Introduzca el cliente a asociar, recuerde que puede realizar" +
                               "la busqueda por nombre, fecha o id.");

            string busqueda = Console.ReadLine();
            int cliente = BuscarCliente(busqueda);
            if (cliente == -1)
            {
                Console.WriteLine("El cliente que ha intentado añadir no existe," +
                    " por favor cambie los paramertos de búsqueda e inténtelo de nuevo.");
            }
            else
            {
                fac.cliente = context.Cliente.Where(c => c.ClienteID == cliente).Single();

                Console.WriteLine("Por favor, introduzca la fecha de inicio de los albaranes a añadir a la factura");
                DateTime fechaInicio = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Por favor, introduzca la fecha final de los albaranes a añadir. Si no introduce nada el valor por defecto será ahora");
                string fechaFinString = Console.ReadLine();
                DateTime fechaFin;
                Decimal importeTotal = 0;

                if (!DateTime.TryParse(fechaFinString, out fechaFin))
                {
                    fechaFin = DateTime.Now;
                }

                albaranes = context.Albaran
                            .Include("ID_Cliente")
                            .Where(a => a.Fecha >= fechaInicio && a.Fecha <= fechaFin && a.Cliente.ClienteID == cliente).ToList();

                fac.Albaranes = albaranes;                                  
                
                foreach (var a in albaranes)
                {
                    importeTotal += a.Importe;
                }


                fac.Fecha = DateTime.Now;
                fac.Importe = importeTotal;

                context.Factura.Add(fac);
                context.SaveChanges();
            }

        }


        public static int BuscarCliente(string busqueda)
        {
            bool validadorFormato;
            int id, n;
            int resultado = -1;
            List<Cliente> clientes = null;
            FacturacionContext context = new FacturacionContext();
            int.TryParse(busqueda, out n);
            if(n == -1 || n == 0)
            {
                clientes = context.Cliente.Where(c => c.Nombre.Contains(busqueda)
                                            || c.Apellidos.Contains(busqueda))
                                            .ToList<Cliente>();
            }
            else
            {
                clientes = context.Cliente.Where(c => c.ClienteID == n).ToList<Cliente>();
            }
            


            if (clientes.Count() == 0)
            {
                Console.WriteLine("No se han encontrado clientes que coincidan con sus parámetros de búsqueda." +
                                    "\n Pulse una tecla para continuar...");
                
            }
            else if (clientes.Count() == 1)
            {
                resultado = clientes.First().ClienteID;
            }
            else
            {
                Console.WriteLine("Se han encontrado los siguientes clientes con sus parametros de búsqueda");
                foreach (var i in clientes)
                {
                    Console.WriteLine($"{i.ClienteID} || {i.Nombre} , {i.Apellidos}");
                }
                validadorFormato = false;
                Console.WriteLine("Por favor introduzca el id del cliente deseado (primer valor mostrado en el listado)");
                do
                {
                    try
                    {
                        id = int.Parse(Console.ReadLine());
                        resultado =  context.Cliente.Where(c => c.ClienteID == id).SingleOrDefault().ClienteID;
                        validadorFormato = true;
                        
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("La entrada sólo admite números, vuelva a intentarlo");

                    }
                    catch (System.OverflowException e1)
                    {
                        Console.WriteLine("El valor es demasiado alto, por favor introduzca un nuevo valor.");
                    }
                } while (!validadorFormato);

            }

            return resultado;
        } // FIN BUSCAR CLIENTE

    }
}
