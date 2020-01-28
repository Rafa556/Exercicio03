using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03
{
    class Veiculo
    {
        protected String modelo { get; set; }
        protected String marca { get; set; }
        protected String placa { get; set; }
        protected String cor { get; set; }
        protected int Km { get; set; }
        protected Boolean isLigado { get; set; }
        protected int litrosCombustivel { get; set; }
        protected int velocidade { get; set; }
        protected double preco { get; set; }

        public Veiculo(String modelo, String marca, String placa, String cor, int Km, Boolean isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.placa = placa;
            this.cor = cor;
            this.Km = Km;
            this.isLigado = isLigado;
            this.litrosCombustivel = litrosCombustivel;
            this.velocidade = velocidade;
            this.preco = preco;
        }

        public Veiculo() {

        }

        public void acelerar()
        {
            if (this.isLigado == true)
            {
                this.velocidade = this.velocidade + 20;
                this.litrosCombustivel -= 1;
            }
            else
            {

                Console.WriteLine("O carro não pode acelerar, pois está desligado");
            }
        }

        int dif;
        public void abastecer(int li) {
            if (this.litrosCombustivel < 100)
            { if (this.litrosCombustivel + li > 100)
                { this.litrosCombustivel = 100;
                    dif = li - 50;
                    Console.WriteLine("Não pode encher mais do limite");
                    Console.WriteLine("Você encheu " + dif + " do limite do tanque");
                }
                else
                {
                    this.litrosCombustivel += li;
                    Console.WriteLine("Você abasteceu: " + li + "litros de gasolina, atualmente o tanque tem: " + this.litrosCombustivel + "litros de gasolina");
                }
            }
            else {
                Console.WriteLine("Não há como abastecer, o tanque está cheio");
            }
        }
        public void frear()
        { if (this.isLigado == true)
            {
                if (this.velocidade < 0)
                {
                    Console.WriteLine("O carro está desligado.");
                }
            }
            else
            {
                this.velocidade = -10;
            }

        }

        public void pintar()
        {
            this.cor = cor;
        }

        public void ligar()
        {
            if (this.isLigado == false)
            {
                this.isLigado = true;

                Console.WriteLine("O carro ligou.");
            }
            else
            {
                Console.WriteLine("O carro está desligado.");
            }
        }

        public void desligar()
        {
            if (this.isLigado == true)
            { this.isLigado = false;
                Console.WriteLine("O carro desligou.");

            }
            else
            {
                Console.WriteLine("O carros está ligado");
            }
        }

        public void status()
        {
            Console.WriteLine("O modelo do veiculo é: " + this.modelo);
            Console.WriteLine("A marca do veiculo é: " + this.marca);
            Console.WriteLine("A placa do veiculo é: " + this.placa);
            Console.WriteLine("A cor do veiculo é: " + this.cor);
            Console.WriteLine("O Km do veiculo é: " + this.Km);
            Console.WriteLine("O veiculo está: " + this.isLigado);
            Console.WriteLine("O veiculo tem: " + this.litrosCombustivel);
            Console.WriteLine("A velocidade do veiculo é: " + this.velocidade);
            Console.WriteLine("O preço do veiculo é: " + this.preco);
        }
    }
}
