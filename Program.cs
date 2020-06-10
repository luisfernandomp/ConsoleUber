using System;
using System.Threading;

namespace uberProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool teste1 = false, teste2 = false;
            string login = "", senha = "", op = "";
            Passageiro Paulo = new Passageiro();
            Cartao card = new Cartao();
            Pagamento pay = new Pagamento();
            Motorista mt = new Motorista();
            Corrida corrida = new Corrida();
            Conta ct = new Conta();
            Console.Clear();
            while(teste1 == false){
                Console.Clear();
                Console.WriteLine("----------------------------");
                Console.WriteLine("-       UBER - CONSOLE     -");
                Console.WriteLine("----------------------------");
                Console.WriteLine("\nBem - vindo!");
                Console.Write("\nLogin:  ");
                login =  Console.ReadLine();
                Console.Write("\nSenha:  ");
                senha =  Console.ReadLine();
                Paulo.Login(login, senha);
                while(Paulo.TokenLogin  != null && Paulo.TokenLogin != ""){
                    Console.Clear();
                    teste2 = false;
                    Console.WriteLine("Login autorizado!");
                    Console.WriteLine("Token: "+Paulo.TokenLogin+"\n\n");
                    Thread.Sleep(1500);
                    Console.Clear();
                    Console.Write("\nInforme seu nome: ");
                    string nomePassageiro = Console.ReadLine();
                    Paulo.Nome = nomePassageiro;
                    Console.Write("\nInforme sua localização: ");
                    string localizacao = Console.ReadLine();
                    Paulo.LocalizacaoAtual = localizacao;
                    Console.Write("\nInforme seu destino: ");
                    string destino = Console.ReadLine();
                    corrida.localChegada  = destino;
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("--- FORMA DE PAGAMENTO -----");
                    Console.WriteLine("- 1 - Dinheiro             -");
                    Console.WriteLine("- 2 - Cartão               -");
                    Console.WriteLine("----------------------------");
                    string fPagamento = Console.ReadLine();
                    pay.FormaPagamento = fPagamento;
                    switch (pay.FormaPagamento)
                    {
                        case "1": 
                            Console.Clear();
                            Console.Write("Pagamento em dinheiro!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            string solicitacao = Paulo.SolicitarMotorista();
                            Console.WriteLine(solicitacao);
                            Thread.Sleep(1800);
                            string retorno = mt.aceitarPassageiro(Paulo.Nome);
                            if(retorno == "Passageiro aceito"){
                                mt.receberPagamento();
                                pay.status = "Finalizada";
                                pay.data = DateTime.Today;
                                Console.WriteLine("Deseja confirmar a corrida? (responda com s - sim ou n - não)");
                                string confirmarCorrida = Console.ReadLine();
                                if(confirmarCorrida == "s"){
                                        corrida.statusCorrida = "Cancelada";
                                        pay.status = "Finalizada";
                                        pay.data = DateTime.Today;
                                    }else{
                                        string cancelarCorrida = corrida.Cancelar();
                                        Console.WriteLine("Status Corrida: "+cancelarCorrida);
                                        Thread.Sleep(2000);
                                        teste2 = true;
                                        teste1 = true;
                                        pay.status = "Corrida Cancelada!";
                                        Paulo.TokenLogin = "";
                                }
                                bool confirmacao = Paulo.Pagar(pay.status);
                                if(confirmacao == true){
                                    corrida.localInicio = Paulo.LocalizacaoAtual;
                                    corrida.motorista = "Luis";
                                    corrida.passageiro = Paulo.Nome;
                                        if(retorno == "Passageiro aceito"){
                                            corrida.statusCorrida = "Confirmada";
                                            ct.cadastrar();
                                            Console.Clear();
                                            Console.WriteLine("__________DADOS_DA_CORRIDA_____________");
                                            Console.WriteLine($"| Início: {corrida.localInicio}       ");
                                            Console.WriteLine($"| Destino: {corrida.localChegada}     ");
                                            Console.WriteLine($"| Forma de pagamento: {pay.FormaPagamento}");
                                            Console.WriteLine($"| Data: {pay.data}                    ");
                                            Console.WriteLine($"| Motorista: {corrida.motorista}      ");
                                            Console.WriteLine($"| Placa: {mt.placa}                   ");
                                            Console.WriteLine($"| Carro: {mt.carro}                   ");
                                            Console.WriteLine($"| Status: {corrida.statusCorrida}     ");
                                            Console.WriteLine("________________________________________");
                                            Console.WriteLine("Corrida finalizada");
                                            Thread.Sleep(5000);
                                            while(teste2 == false){
                                                Thread.Sleep(2000);
                                                Console.Clear();
                                                Console.WriteLine("\nDeseja realizar outra viagem? (Para s - sim, n - não)");
                                                op = Console.ReadLine();
                                                if(op == "s"){
                                                    teste2 = true;
                                                }else{
                                                    if(op == "n"){
                                                        Console.Clear();
                                                        Console.WriteLine("\nAté logo...");
                                                        Thread.Sleep(1000);
                                                        teste2 = true;
                                                        teste1 = true;
                                                        Paulo.TokenLogin = "";
                                                    }else{
                                                        Console.WriteLine("Opção inválida!");
                                                    }
                                                }
                                            }
                                        }else{
                                            corrida.statusCorrida = "Não confirmada";
                                            Console.WriteLine("Tente novamente!");
                                        }
                                }else{
                                        Console.WriteLine("Erro na confirmação do pagamento!");
                                    }
                            }else{
                                Console.WriteLine("Passageiro Recusado!");
                            }
                                ;break;
                            case "2": 
                                Console.Clear();
                                Console.Write("Pagamento no cartão!");
                                Thread.Sleep(2000);
                                Console.Clear();
                                string cadastrarCartao = card.Cadastrar();
                                Console.WriteLine(cadastrarCartao);
                                solicitacao = Paulo.SolicitarMotorista();
                                Console.WriteLine(solicitacao);
                                Thread.Sleep(1800);
                                retorno = mt.aceitarPassageiro(Paulo.Nome);
                                if(retorno == "Passageiro aceito"){
                                    mt.receberPagamento();
                                    Console.WriteLine("Deseja confirmar a corrida? (responda com s - sim ou n - não)");
                                    string confirmarCorrida = Console.ReadLine();
                                    if(confirmarCorrida == "s"){
                                        corrida.statusCorrida = "Cancelada";
                                        pay.status = "Finalizada";
                                        pay.data = DateTime.Today;
                                    }else{
                                        string cancelarCorrida = corrida.Cancelar();
                                        Console.WriteLine("Status Corrida: "+cancelarCorrida);
                                        Thread.Sleep(2000);
                                        teste2 = true;
                                        teste1 = true;
                                        pay.status = "Corrida Cancelada!";
                                        Paulo.TokenLogin = "";
                                    }
                                    bool confirmacao = Paulo.Pagar(pay.status);
                                    if(confirmacao == true && pay.status == "Finalizada"){
                                        corrida.localInicio = Paulo.LocalizacaoAtual;
                                        corrida.motorista = "Luis";
                                        corrida.passageiro = Paulo.Nome;
                                        if(retorno == "Passageiro aceito"){
                                            corrida.statusCorrida = "Confirmada";
                                            ct.cadastrar();
                                            Console.Clear();
                                            Console.WriteLine("__________DADOS_DA_CORRIDA_____________");
                                            Console.WriteLine($"| Início: {corrida.localInicio}       ");
                                            Console.WriteLine($"| Destino: {corrida.localChegada}     ");
                                            Console.WriteLine($"| Forma de pagamento: {pay.FormaPagamento}");
                                            Console.WriteLine($"| Data: {pay.data}                    ");
                                            Console.WriteLine($"| Motorista: {corrida.motorista}      ");
                                            Console.WriteLine($"| Placa: {mt.placa}                   ");
                                            Console.WriteLine($"| Carro: {mt.carro}                   ");
                                            Console.WriteLine($"| Status: {corrida.statusCorrida}     ");
                                            Console.WriteLine("________________________________________");
                                            Console.WriteLine("Corrida finalizada");
                                            Thread.Sleep(5000);
                                            while(teste2 == false){
                                                Thread.Sleep(2000);
                                                Console.Clear();
                                                Console.WriteLine("\nDeseja realizar outra viagem? (Para s - sim, n - não)");
                                                op = Console.ReadLine();
                                                if(op == "s"){
                                                    teste2 = true;
                                                }else{
                                                    if(op == "n"){
                                                        Console.Clear();
                                                        Console.WriteLine("\nAté logo...");
                                                        Thread.Sleep(1000);
                                                        teste2 = true;
                                                        teste1 = true;
                                                        Paulo.TokenLogin = "";
                                                    }else{
                                                        Console.WriteLine("Opção inválida!");
                                                    }
                                                }
                                            }
                                        }else{
                                            corrida.statusCorrida = "Não confirmada";
                                            Console.WriteLine("Tente novamente!");
                                        }
                                }else{
                                        Console.WriteLine("Erro na confirmação do pagamento!");
                                    }                            
                                }else{
                                    Console.WriteLine("Passageiro Recusado!");
                                }
                                ;break;
                            default: Console.WriteLine("Número inválido!"); break;
                        }
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("Não autorizado!");
                    }
                }
            Console.Clear();
            Console.WriteLine("Deseja apagar os dados do cartão? Responda com sim ou não");
            string apagarDados = Console.ReadLine();
            if(apagarDados == "sim"){
                card.Excluir();
                Thread.Sleep(2000);
                System.Environment.Exit(0);
            }else{
                System.Environment.Exit(0);            
            }
        }
    }
}
