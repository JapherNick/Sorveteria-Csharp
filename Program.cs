// See https://aka.ms/new-console-template for more information

using System;
namespace Sorveteria {
    class Program {
        static void Main(string[] args) {
            int Opcao1;
            Console.WriteLine(" Ola seja bem vindo a Lanchonete por favor escolha o que deseja! ");

            Console.WriteLine(" (1) ...  Sorvete ");
            Console.WriteLine(" (2) ... Acai ");
            Console.WriteLine(" (3) ... Milkshake ");
            Console.WriteLine(" (4) ... Lanches ");
            Opcao1 = int.Parse(Console.ReadLine());

            if (Opcao1 == 1) {
                Console.WriteLine("Voce Selecionou Sorvete!");

                int Copo;
                Console.WriteLine("\t Por favor selecione o seu copo: \n");

                Console.WriteLine("\t (1) ... 150ML \n");
                Console.WriteLine("\t (2) ... 300ML \n");
                Console.WriteLine("\t (3) ... 500ML \n");
                Copo = int.Parse(Console.ReadLine());

                while ((Copo < 1) || (Copo > 3)) ;
                switch (Copo) {
                    case 1:
                        Console.WriteLine(" Voce selecionou o copo de 150ML ");
                        break;

                    case 2:
                        Console.WriteLine(" Voce selecionou o copo de 300ML ");
                        break;

                    case 3:
                        Console.WriteLine(" Voce selecionou o copo de 500ML ");
                        break;
                }

                int Sabor;

                Console.WriteLine(" Por favor selecione o sabor: ");

                Console.WriteLine(" (1) ... Flocos ");
                Console.WriteLine(" (2) ... Chocolate ");
                Console.WriteLine(" (3) ... Morango ");
                Console.WriteLine(" (4) ... Chiclete ");
                Console.WriteLine(" (5) ... Leite condesado ");
                Sabor = int.Parse(Console.ReadLine());

                while ((Sabor < 1) || (Sabor > 5)) ;

                switch (Sabor) {
                    case 1:
                        Console.WriteLine(" Voce selecionou Flocos ");
                        break;

                    case 2:
                        Console.WriteLine(" Voce selecionou Chocolate ");
                        break;

                    case 3:
                        Console.WriteLine(" Voce Selecionou Morango ");
                        break;

                    case 4:
                        Console.WriteLine(" Voce Selecionou Chiclete ");
                        break;

                    case 5:
                        Console.WriteLine(" Voce Selecionou Leite Condesado ");
                        break;
                }
                int Calda;

                Console.WriteLine("\t Por favor Selecione a calda: \n");

                Console.WriteLine("\t (1) ... Chocolate \n");
                Console.WriteLine("\t (2) ... Caramelo \n");
                Console.WriteLine("\t (3) ... Morango \n");
                Console.WriteLine("\t (4) ... Leite Condesado \n");
                Console.WriteLine("\t (5) ... Doce De leite \n");
                Console.WriteLine("\t (6) ... Nenhuma \n");
                Calda = int.Parse(Console.ReadLine());

                while ((Calda < 1) || (Calda > 6)) ;


                switch (Calda) {
                    case 1:
                        Console.WriteLine("\t Voce escolheu Chocolate");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce escolheu Caramelo");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce escolheu morgango");
                        break;

                    case 4:
                        Console.WriteLine("\t Voce escolheu Leite Condesado");
                        break;

                    case 5:
                        Console.WriteLine("\t Voce escolheu Doce De leite \n");
                        break;

                    case 6:
                        Console.WriteLine("\t Voce escolheu Nenhuma \n");
                        break;
                }
                int Adicional;

                Console.WriteLine("\t Gostaria de um adiconal? \n");

                Console.WriteLine("\n (1) ... Nao \n");
                Console.WriteLine("\n (2) ... Granulado \n");
                Console.WriteLine("\n (3) ... Discos de Chocolate \n");
                Console.WriteLine("\n (4) ... Leite Ninho \n");
                Adicional = int.Parse(Console.ReadLine());


                while ((Adicional < 1) || (Adicional > 4)) ;

                switch (Adicional) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Nao \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou Granulado \n");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce Selecionou Discos de Chocolate \n");
                        break;

                    case 4:
                        Console.WriteLine("\t Voce Selecionou Leite Ninho \n");
                        break;

                }
                int Pagamento;

                Console.WriteLine("\n Escolha a forma de pagamento \n");

                Console.WriteLine("\t (1) Dinheiro \n");
                Console.WriteLine("\t (2) Cartao \n");
                Pagamento = int.Parse(Console.ReadLine());


                while ((Pagamento < 1) || (Pagamento > 2)) ;

                switch (Pagamento) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Dinheiro, retire sua senha e aguarde, agradecemos a preferencia \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce selecionou Cartao, retire sua senha e aguarde, agradecemos a preferencia \n");
                        break;


                }
            }
            if (Opcao1 == 2) {
                Console.WriteLine("\t Voce Selecionou Acai \n");

                int Acai;

                Console.WriteLine("\t Por favor selecione o seu copo: \n");

                Console.WriteLine("\t (1) ... 150ML \n");
                Console.WriteLine("\t (2) ... 300ML \n");
                Console.WriteLine("\t (3) ... 500ML \n");
                Acai = int.Parse(Console.ReadLine());


                while ((Acai < 1) || (Acai > 3)) ;

                switch (Acai) {
                    case 1:
                        Console.WriteLine("\t Voce selecionou o copo de 150ML \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce selecionou o copo de 300ML \n");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce selecionou o copo de 500ML");
                        break;
                }


                Console.WriteLine("\t Gostaria de um adiconal? \n");
                int Acai_ADC;


                Console.WriteLine("\n (1) ... Nao \n");
                Console.WriteLine("\n (2) ... Granola \n");
                Console.WriteLine("\n (3) ... Discos de Chocolate \n");
                Console.WriteLine("\n (4) ... Leite Ninho \n");
                Console.WriteLine("\n (5) ... Morango \n");
                Console.WriteLine("\n (6) ... Banana \n");
                Console.WriteLine("\n (7) ... Nutella \n");
                Console.WriteLine("\n (8) ... Gotas de Chocolate \n");
                Console.WriteLine("\n (9) ... Pacoca \n");
                Console.WriteLine("\n (10) ... Leite Condesado \n");
                Acai_ADC = int.Parse(Console.ReadLine());

                while ((Acai_ADC < 1) || (Acai_ADC > 10)) ;

                switch (Acai_ADC) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Nao \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou Granola \n");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce Selecionou Discos de Chocolate \n");
                        break;

                    case 4:
                        Console.WriteLine("\t Voce Selecionou Leite Ninho \n");
                        break;

                    case 5:
                        Console.WriteLine("\t Voce Selecionou Morango \n");
                        break;

                    case 6:
                        Console.WriteLine("\t Voce Selecionou Banana \n");
                        break;

                    case 7:
                        Console.WriteLine("\t Voce Selecionou Nutella \n");
                        break;

                    case 8:
                        Console.WriteLine("\t Voce Selecionou Gotas de Chocolate \n");
                        break;

                    case 9:
                        Console.WriteLine("\t Voce Selecionou Pacoca \n");
                        break;

                    case 10:
                        Console.WriteLine("\t Voce Selecionou Leite Condesado \n");
                        break;
                }
                int Acai_ADC2;

                Console.WriteLine("\t Gostaria de um adiconal? \n");

                Console.WriteLine("\n (1) ... Nao \n");
                Console.WriteLine("\n (2) ... Granola \n");
                Console.WriteLine("\n (3) ... Discos de Chocolate \n");
                Console.WriteLine("\n (4) ... Leite Ninho \n");
                Console.WriteLine("\n (5) ... Morango \n");
                Console.WriteLine("\n (6) ... Banana \n");
                Console.WriteLine("\n (7) ... Nutella \n");
                Console.WriteLine("\n (8) ... Gotas de Chocolate \n");
                Console.WriteLine("\n (9) ... Pacoca \n");
                Console.WriteLine("\n (10) ... Leite Condesado \n");
                Acai_ADC2 = int.Parse(Console.ReadLine());


                while ((Acai_ADC2 < 1) || (Acai_ADC2 > 10)) ;

                switch (Acai_ADC2) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Nao \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou Granola \n");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce Selecionou Discos de Chocolate \n");
                        break;

                    case 4:
                        Console.WriteLine("\t Voce Selecionou Leite Ninho \n");
                        break;

                    case 5:
                        Console.WriteLine("\t Voce Selecionou Morango \n");
                        break;

                    case 6:
                        Console.WriteLine("\t Voce Selecionou Banana \n");
                        break;

                    case 7:
                        Console.WriteLine("\t Voce Selecionou Nutella \n");
                        break;

                    case 8:
                        Console.WriteLine("\t Voce Selecionou Gotas de Chocolate \n");
                        break;

                    case 9:
                        Console.WriteLine("\t Voce Selecionou Pacoca \n");
                        break;

                    case 10:
                        Console.WriteLine("\t Voce Selecionou Leite Condesado \n");
                        break;
                }
                int Acai_ADC3;

                Console.WriteLine("\t Gostaria de um adiconal? \n");

                Console.WriteLine("\n (1) ... Nao \n");
                Console.WriteLine("\n (2) ... Granola \n");
                Console.WriteLine("\n (3) ... Discos de Chocolate \n");
                Console.WriteLine("\n (4) ... Leite Ninho \n");
                Console.WriteLine("\n (5) ... Morango \n");
                Console.WriteLine("\n (6) ... Banana \n");
                Console.WriteLine("\n (7) ... Nutella \n");
                Console.WriteLine("\n (8) ... Gotas de Chocolate \n");
                Console.WriteLine("\n (9) ... Pacoca \n");
                Console.WriteLine("\n (10) ... Leite Condesado \n");
                Acai_ADC3 = int.Parse(Console.ReadLine());

                while ((Acai_ADC3 < 1) || (Acai_ADC3 > 10)) ;

                switch (Acai_ADC3) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Nao \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou Granola \n");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce Selecionou Discos de Chocolate \n");
                        break;

                    case 4:
                        Console.WriteLine("\t Voce Selecionou Leite Ninho \n");
                        break;

                    case 5:
                        Console.WriteLine("\t Voce Selecionou Morango \n");
                        break;

                    case 6:
                        Console.WriteLine("\t Voce Selecionou Banana \n");
                        break;

                    case 7:
                        Console.WriteLine("\t Voce Selecionou Nutella \n");
                        break;

                    case 8:
                        Console.WriteLine("\t Voce Selecionou Gotas de Chocolate \n");
                        break;

                    case 9:
                        Console.WriteLine("\t Voce Selecionou Pacoca \n");
                        break;

                    case 10:
                        Console.WriteLine("\t Voce Selecionou Leite Condesado \n");
                        break;
                }
                int Acai_Calda;

                Console.WriteLine("\t Por favor Selecione a calda: \n");

                Console.WriteLine("\t (1) ... Chocolate \n");
                Console.WriteLine("\t (2) ... Caramelo \n");
                Console.WriteLine("\t (3) ... Morango \n");
                Console.WriteLine("\t (4) ... Leite Condesado \n");
                Console.WriteLine("\t (5) ... Doce De leite \n");
                Console.WriteLine("\t (6) ... Nenhuma \n");
                Acai_Calda = int.Parse(Console.ReadLine());

                while ((Acai_Calda < 1) || (Acai_Calda > 6)) ;


                switch (Acai_Calda) {
                    case 1:
                        Console.WriteLine("\t Voce escolheu Chocolate");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce escolheu Caramelo");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce escolheu morgango");
                        break;

                    case 4:
                        Console.WriteLine("\t Voce escolheu Leite Condesado");
                        break;

                    case 5:
                        Console.WriteLine("\t Voce escolheu Doce De leite \n");
                        break;

                    case 6:
                        Console.WriteLine("\t Voce escolheu Nenhuma \n");
                        break;
                }
                int Acai_PGT;

                Console.WriteLine("\t Por favor Selecione o meio de pagamento: \n");

                Console.WriteLine("\t (1) ... Dinheiro \n");
                Console.WriteLine("\t (2) ... Cartao \n");
                Acai_PGT = int.Parse(Console.ReadLine());


                while ((Acai_PGT < 1) || (Acai_PGT > 2)) ;

                switch (Acai_PGT) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Dinheiro, retire sua senha e aguarde, agradecemos a preferencia! \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou Cartao, retire sua senha e aguarde, agradecemos a prederencia! \n");
                        break;
                }

            }
            if (Opcao1 == 3) {

                int MILKSHAKE;


                Console.WriteLine("\t Voce Selecionou Milkshake");


                Console.WriteLine("\t Por favor selecione o tamanho do copo: \n");

                Console.WriteLine("\t (1) ... 150ML \n");
                Console.WriteLine("\t (2) ... 300ML \n");
                Console.WriteLine("\t (3) ... 500ML \n");
                MILKSHAKE = int.Parse(Console.ReadLine());

                while ((MILKSHAKE < 1) || (MILKSHAKE > 3)) ;

                switch (MILKSHAKE) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou o copo de: 150ML \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce selecionou o copo de: 300ML \n");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce selecionou o copo de: 500ML \n");
                        break;

                }
                int MILKSHAKE_Sabor;

                Console.WriteLine("\t Por favor Selecione o sabor: \n");

                Console.WriteLine("\t (1) ... Ovomaltine \n");
                Console.WriteLine("\t (2) ... Leite Condesado \n");
                Console.WriteLine("\t (3) ... Frutas Vermelhas \n");
                MILKSHAKE_Sabor = int.Parse(Console.ReadLine());


                while ((MILKSHAKE_Sabor < 1) || (MILKSHAKE_Sabor > 3)) ;

                switch (MILKSHAKE_Sabor) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou: Ovomaltine \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou: Leite Condesado \n");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce Selecionou: Frutas Vermelhas \n");
                        break;
                }
                int MILKSHAKE_PGT;

                Console.WriteLine("\t Por favor, selecione o meio de pagamento \n");

                Console.WriteLine("\t (1) ... Dinheiro \n");
                Console.WriteLine("\t (2) ... Cartao \n");
                MILKSHAKE_PGT = int.Parse(Console.ReadLine());


                while ((MILKSHAKE_PGT < 1) || (MILKSHAKE_PGT > 2)) ;

                switch (MILKSHAKE_PGT) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Dinheiro, retire sua senha e aguarde, agradecemos a preferencia! \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou Cartao, retire sua senha e aguarde, agradecemos a prederencia! \n");
                        break;
                }
            }


            if (Opcao1 == 4) {
                Console.WriteLine("\t Voce Selecionou: Lanche \n");

                int Lanches;


                Console.WriteLine("\t Selecione seu lanche \n");

                Console.WriteLine("\t (1) ... Hot Dog \n");
                Console.WriteLine("\t (2) ... Misto Quente \n");
                Console.WriteLine("\t (3) ... Coxinha \n");
                Console.WriteLine("\t (4) ... Panqueca \n");
                Lanches = int.Parse(Console.ReadLine());

                while ((Lanches < 1) || (Lanches > 4)) ;

                switch (Lanches) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Hot Dog \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou Misto Quente \n");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce Selecionou Coxinha \n");
                        break;

                    case 4:
                        Console.WriteLine("\t Voce Selecionou Panqueca \n");
                        break;
                }

                int Bebida;

                Console.WriteLine("\t Por favor, selecione sua bebida: \n");

                Console.WriteLine("\t (1) ... Suco De Laranja Copo de 500ML \n");
                Console.WriteLine("\t (2) ... Coca Cola Lata 350ML \n");
                Console.WriteLine("\t (3) ... Guarana Antartica Lata 350ML \n");
                Console.WriteLine("\t (4) ... Fanta Laranja Lata 350ML \n");
                Console.WriteLine("\t (5) ... Sprite Lata 350ML \n");
                Bebida = int.Parse(Console.ReadLine());


                while ((Bebida < 1) || (Bebida > 5)) ;

                switch (Bebida) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Suco de Laranja Copo 500ML \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou Coca Cola Lata 350ML \n");
                        break;

                    case 3:
                        Console.WriteLine("\t Voce Selecionou Guarana Antartica Lata 350ML \n");
                        break;

                    case 4:
                        Console.WriteLine("\t Voce Selecionou Fanta Laranja Lata 350ML \n");
                        break;

                    case 5:
                        Console.WriteLine("\t Voce Selecionou Sprite Lata 350ML \n");
                        break;
                }

                int Lanche_PGT;

                Console.WriteLine("\t Por favor, selecione o meio de pagamento \n");

                Console.WriteLine("\t (1) ... Dinheiro \n");
                Console.WriteLine("\t (2) ... Cartao \n");
                Lanche_PGT = int.Parse(Console.ReadLine());


                while ((Lanche_PGT < 1) || (Lanche_PGT > 2)) ;

                switch (Lanche_PGT) {
                    case 1:
                        Console.WriteLine("\t Voce Selecionou Dinheiro, retire sua senha e aguarde, agradecemos a preferencia! \n");
                        break;

                    case 2:
                        Console.WriteLine("\t Voce Selecionou Cartao, retire sua senha e aguarde, agradecemos a preferencia! \n");
                        break;
                }





            }



        }

    }







}


