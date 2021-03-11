using System;

namespace Clase03_10_21
{
    class Cliente{
        string nombre;
        int monto, deposito;
        public Cliente(string nom){
            nombre = nom;
        }
        public int deporsitar(int dep){
            deposito = dep;
            return monto += dep;
        }
        public int extraer(int dep){
            deposito = dep;
            return monto -= dep;
        }
        public int RetornarMonto(){
            return monto;
        }
    }
    class Banco{
        Cliente cliente_1; Cliente cliente_2; Cliente cliente_3;
    public Banco(){
        Console.WriteLine("Ingrese el nombre de los clientes: ");
        cliente_1 = new Cliente(Console.ReadLine());
        cliente_2 = new Cliente(Console.ReadLine());
        cliente_3 = new Cliente(Console.ReadLine());
        Console.WriteLine("\n");
    }
    public void Asignar_Deposito(){
        Console.WriteLine("Ingrese los depositos de los clientes");
        int un = cliente_1.deporsitar(int.Parse(Console.ReadLine()));
        int dos = cliente_2.deporsitar(int.Parse(Console.ReadLine()));
        int tres =cliente_3.deporsitar(int.Parse(Console.ReadLine()));
        Console.WriteLine("\n");

        Console.WriteLine("Clientes 1: {0} ", un);
        Console.WriteLine("Clientes 2: {0}", dos);
        Console.WriteLine("Clientes 3: {0}\n", tres);
    }
    public void Asignar_Extraccion(){
        Console.WriteLine("Ingrese la cantidad que desea extraer de los clientes");
        int uno = cliente_1.extraer(int.Parse(Console.ReadLine()));
        int dos = cliente_2.extraer(int.Parse(Console.ReadLine()));
        int tres = cliente_3.extraer(int.Parse(Console.ReadLine()));
        Console.WriteLine("\n");

        Console.WriteLine("Clientes 1 saco: {0}", uno);
        Console.WriteLine("Clientes 2 saco: {0}", dos);
        Console.WriteLine("Clientes 3 saco: {0}\n", tres);
    }
    public void MostrarTodo(){
        Console.WriteLine("El cliente 1 deposito " + cliente_1.RetornarMonto());
        Console.WriteLine("El cliente 2 deposito " + cliente_2.RetornarMonto());
        Console.WriteLine("El cliente 3 deposito " + cliente_3.RetornarMonto());
        Console.WriteLine("\n");
    }
    public void Deposito_Total(){
     int deptotal = cliente_1.RetornarMonto() + cliente_2.RetornarMonto() + cliente_3.RetornarMonto();
     Console.WriteLine("El total de depositos es de {0}", deptotal);  
     Console.WriteLine("\n");
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Banco banc = new Banco();
            banc.Asignar_Deposito();
            banc.MostrarTodo();
            banc.Asignar_Extraccion();
            banc.MostrarTodo();
            banc.Deposito_Total();
        }
    }
}
