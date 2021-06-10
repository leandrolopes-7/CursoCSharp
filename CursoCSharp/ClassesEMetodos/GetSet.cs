using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            Cilindrada = cilindrada;
        }
    }
    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Honda", "CG", 150);
            Console.WriteLine("Marca "+moto1.GetMarca());
            Console.WriteLine("Modelo " +moto1.GetModelo());
            Console.WriteLine("Cilindrada " +moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Yamaha");
            moto2.SetModelo("Fazer");
            moto2.SetCilindrada(200);

            Console.WriteLine(moto2.GetMarca() + moto2.GetModelo() + moto2.GetCilindrada());
        }
    }
}
