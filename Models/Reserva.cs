using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes{ get; set; }
        public Suite Suite{ get; set; }
        public int DiasReservados{ get; set; }

        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            this.Hospedes = hospedes;
            if(hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        public decimal CalcularValorHospedagem()
        {
            decimal valor = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados >= 10)
            {
                valor = (Suite.ValorDiaria * 0.9M) * DiasReservados;
            } 
            return valor;
        }
    }
}
